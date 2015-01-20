using System;
using System.IO;
using System.Globalization;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class AutoSaveScene
{
	private const string SAVE_FOLDER = "Editor/AutoSaves";

	private static System.DateTime lastSaveTime = System.DateTime.Now;
	private static System.TimeSpan updateInterval;

	static AutoSaveScene()
	{
		EnsureAutoSavePathExists();

		// Register for autosaves.
		// Change this number to modify the autosave interval.
		RegisterOnEditorUpdate(5);
	}

	public static void RegisterOnEditorUpdate(int interval)
	{
		Debug.Log ("Enabling AutoSave");

		updateInterval = new TimeSpan(0, interval, 0);
		EditorApplication.update += OnUpdate;
	}

	/// <summary>
	/// Makes sure the target save path exists.
	/// </summary>
	private static void EnsureAutoSavePathExists()
	{
		var path = Path.Combine(Application.dataPath, SAVE_FOLDER);

		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
		}
	}

	/// <summary>
	/// Saves a copy of the currently open scene.
	/// </summary>
	private static void SaveScene()
	{
		Debug.Log("Auto saving scene: " + EditorApplication.currentScene);

		EnsureAutoSavePathExists();

		// Get the new saved scene name.
		var newName = GetNewSceneName(EditorApplication.currentScene);
		var folder = Path.Combine("Assets", SAVE_FOLDER);

		EditorApplication.SaveScene(Path.Combine(folder, newName), true);
		EditorApplication.SaveAssets();
	}

	/// <summary>
	/// Helper method that creates a new scene name.
	/// </summary>
	private static string GetNewSceneName(string originalSceneName)
	{
		var scene = Path.GetFileNameWithoutExtension(originalSceneName);

		return string.Format(
			"{0}_{1}.unity",
			scene,
			System.DateTime.Now.ToString(
			"yyyy-MM-dd_HH-mm-ss",
			CultureInfo.InvariantCulture));
	}

	private static void OnUpdate()
	{
		if ((System.DateTime.Now - lastSaveTime) >= updateInterval)
		{
			SaveScene();
			lastSaveTime = System.DateTime.Now;
		}
	}
}