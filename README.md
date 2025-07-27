# AutoSaveScene

A Unity Editor extension that automatically saves your scenes at regular intervals, creating timestamped backup copies to prevent data loss.

## What is AutoSaveScene?

AutoSaveScene is a lightweight Unity Editor tool that runs in the background and automatically saves copies of your current scene at configurable intervals. This helps prevent work loss due to crashes, power outages, or other unexpected interruptions during development.

### Features

- **Automatic Scene Backup**: Saves your scene every 5 minutes by default (configurable)
- **Timestamped Copies**: Creates uniquely named backup files with timestamp format: `SceneName_yyyy-MM-dd_HH-mm-ss.unity`
- **Non-Intrusive**: Runs silently in the background without disrupting your workflow
- **Organized Storage**: Stores all auto-saves in a dedicated `Assets/Editor/AutoSaves/` folder
- **Zero Configuration**: Works immediately after installation with sensible defaults

## Installation

### Method 1: Direct File Copy
1. Download or copy the `AutoSaveScene.cs` file from this repository
2. In your Unity project, create an `Editor` folder inside your `Assets` folder (if it doesn't already exist)
3. Place the `AutoSaveScene.cs` file in the `Assets/Editor/` directory
4. Unity will automatically compile the script and start auto-saving

### Method 2: Git Submodule (for version control)
```bash
# Navigate to your Unity project's Assets folder
cd Assets
git submodule add https://github.com/liortal53/AutoSaveScene.git Editor/AutoSaveScene
```

### Folder Structure
After installation, your project should look like this:
```
YourUnityProject/
├── Assets/
│   ├── Editor/
│   │   └── AutoSaveScene.cs
│   └── (your other assets)
└── (other Unity project files)
```

## Usage

### Automatic Operation
Once installed, AutoSaveScene works automatically:
- The tool starts when Unity Editor loads
- It saves your current scene every 5 minutes (default interval)
- Backup files are created in `Assets/Editor/AutoSaves/`
- You'll see log messages in the Console confirming each auto-save

### Configuration
To customize the auto-save interval, edit the `AutoSaveScene.cs` file:

```csharp
// Change this number to modify the autosave interval (in minutes)
RegisterOnEditorUpdate(5); // Default: 5 minutes
```

Common intervals:
- `1` = 1 minute (frequent saves for critical work)
- `3` = 3 minutes (balanced approach)
- `5` = 5 minutes (default, good for most workflows)
- `10` = 10 minutes (less frequent, for stable workflows)

### Backup File Naming
Auto-saved files follow this naming convention:
```
OriginalSceneName_2023-12-15_14-30-25.unity
```
Where:
- `OriginalSceneName` is your scene's name
- `2023-12-15` is the date (YYYY-MM-DD)
- `14-30-25` is the time (HH-MM-SS)

### Console Output
You'll see messages like this in Unity's Console:
```
Enabling AutoSave
Auto saving scene: Assets/YourScene.unity
```

## Requirements

- **Unity Version**: Compatible with Unity 4.5.4f1 and newer
- **Platform**: Works on all platforms supported by Unity Editor
- **Dependencies**: None (uses only built-in Unity APIs)

## Troubleshooting

### Auto-save not working?
1. Ensure the script is in an `Editor` folder within `Assets`
2. Check the Unity Console for any compilation errors
3. Verify you have an active scene open in the Editor

### Performance concerns?
The auto-save operation is lightweight and should not impact editor performance. If you experience issues:
- Increase the auto-save interval to reduce frequency
- Consider the size of your scenes and available disk space

### Missing auto-save folder?
The tool automatically creates the `Assets/Editor/AutoSaves/` folder when needed. If it's missing, it will be recreated on the next auto-save.

## Contributing

Contributions are welcome! Please feel free to submit issues, feature requests, or pull requests.

### Development Setup
1. Fork this repository
2. Create a feature branch
3. Make your changes
4. Test with a Unity project
5. Submit a pull request

## Contact

- **Author**: [liortal53](https://github.com/liortal53)
- **Repository**: [https://github.com/liortal53/AutoSaveScene](https://github.com/liortal53/AutoSaveScene)
- **Issues**: [Report bugs or request features](https://github.com/liortal53/AutoSaveScene/issues)

## License

This project is available under the terms specified in the repository. Please check the license file for details.

## Acknowledgments

Built for the Unity development community to help prevent the frustration of lost work due to unexpected editor crashes or system failures.

---

*Save often, worry less! 🎮✨*