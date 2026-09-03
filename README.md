# StudySessionTracker
StudySessionTracker is a small C# console app that allows users to record study sessions and review basic stats about their study activity.

By stepping through a console menu, users can:
- add a study session
- record subject, duration in minutes, and focus rating out of 5
- view recorded study sessions
- view simplistic study statistics

Study session data is stored in-memory and does not persist after exiting the application.

## Technologies
- C#
- .NET 10.0
- WiX Toolset v5
- Visual Studio 2026

## Project structure
Multiple projects are used to modularise application functionality:
- `StudySessionTracker`: the main console application and menu
- `StudySessionCore`: the library containing the `StudySession` class
- `StudyStatistics`: the library containing the study statistics functionality
- WiX setup project: packages the application and required assemblies into an MSI installer for Windows :)

## Deployment
The application was packaged as a Windows MSI installer using WiX Toolset v5. The installer includes the main executable and the referenced class library assemblies, as well as supports installation and uninstallation (do this through Apps and Features for a clean uninstall) through Windows.
