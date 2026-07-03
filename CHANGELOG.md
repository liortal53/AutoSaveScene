# Changelog

All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

## [1.0.0] - 2026-07-03

### Changed

- Restructured the repository as a Unity Package Manager (UPM) package: added
  `package.json`, moved the editor script to a package-relative `Editor/` folder,
  and added an assembly definition for it.
- Removed the standalone `Assets/` and `ProjectSettings/` Unity project scaffolding,
  which is no longer needed now that the repository itself is a package consumed
  via the Package Manager.
