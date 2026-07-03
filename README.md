# Auto Save Scene

A Unity Editor extension that automatically saves timestamped backup copies of the
currently open scene at a configurable interval, so you never lose editor work to a
crash or a bad Ctrl+Z session.

## Installation

This project is distributed as a Unity Package Manager (UPM) package.

### Via Package Manager (git URL)

1. Open **Window > Package Manager** in Unity.
2. Click the **+** button and choose **Add package from git URL...**
3. Enter:
   ```
   https://github.com/liortal53/AutoSaveScene.git
   ```

### Via manifest.json

Add the following line to your project's `Packages/manifest.json`:

```json
"com.liortal53.autosavescene": "https://github.com/liortal53/AutoSaveScene.git"
```

## Usage

Once installed, the package works automatically — no setup required. While the
Unity Editor is open, it periodically saves a timestamped copy of the active
scene to `Assets/Editor/AutoSaves` in your project (default interval: 5 minutes).

To change the autosave interval, edit the value passed to `RegisterOnEditorUpdate`
in `Editor/AutoSaveScene.cs`.
