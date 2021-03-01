[![BugSplat](https://s3.amazonaws.com/bugsplat-public/npm/header.png)](https://www.bugsplat.com)

# MyUnityCrasher
Example demonstrating BugSplat's native Windows C++ SDK integrated in a Unity game.

## Steps
1. Clone this repo and open the MyUnityCrasher project in Unity
2. Download the BugSplat [Unity SDK](https://www.bugsplat.com/docs/sdk/)
3. Modify this [line](https://github.com/BugSplat-Git/MyUnityCrasher/blob/0e74c8918bb8cfa629b9f4715a570185b8619d76/Assets/Code/Editor/PostBuild.cs#L32) and add the path to the bin directory within the BugSplat SDK
4. In the Unity Editor, double click the **Main** scene to ensure it's loaded
5. `File > Build Settings` and ensure **Copy PDB File** is checked
6. `File > Build and Run`
7. Hold shift and press the m key to generate a crash and submit the crash report
8. Navigate to the [Crashes](https://app.bugsplat.com/v2/crashes?c0=appName&f0=CONTAINS&v0=MyUnityCrasher&database=Fred) page to view details about the crash - when prompted to log in use the credentials `fred@bugsplat.com` and password `Flintstone`
