using System.Runtime.InteropServices;

public static class BugSplat {

    public const int MDSF_NONINTERACTIVE = 0x0001;
    public const int MDSF_LOGCONSOLE = 0x1000;
    public const int MDSF_LOGFILE = 0x2000;

    const string CRASH_LIB_NAME = "BugSplatUnity";

    [DllImport(CRASH_LIB_NAME)]
    static extern void BsCreateCrashReporter(
        [MarshalAs(UnmanagedType.LPWStr)] string company,
        [MarshalAs(UnmanagedType.LPWStr)] string database,
        [MarshalAs(UnmanagedType.LPWStr)] string appName,
        [MarshalAs(UnmanagedType.LPWStr)] string version,
        [MarshalAs(UnmanagedType.LPWStr)] string userDescription,
        int flags);
    [DllImport(CRASH_LIB_NAME)]
    static extern void BsSetDefaultUserName([MarshalAs(UnmanagedType.LPWStr)] string name);
    [DllImport(CRASH_LIB_NAME)]
    static extern void BsSetDefaultUserEmail([MarshalAs(UnmanagedType.LPWStr)] string email);
    [DllImport(CRASH_LIB_NAME)]
    static extern void BsSetDefaultUserDescription([MarshalAs(UnmanagedType.LPWStr)] string description);
    [DllImport(CRASH_LIB_NAME)]
    static extern void BsAddAdditionalFile([MarshalAs(UnmanagedType.LPWStr)] string pathToFile);
    [DllImport(CRASH_LIB_NAME)]
    static extern bool BsRemoveAdditionalFile([MarshalAs(UnmanagedType.LPWStr)] string pathToFile);
    [DllImport(CRASH_LIB_NAME)]
    static extern void BsCrashImmediately();

    /// <summary>
    /// Initialize the BugSplat crash reporter.
    /// </summary>
    /// <param name="company"></param>
    /// <param name="database"></param>
    /// <param name="appName"></param>
    /// <param name="version"></param>
    /// <param name="userDescription"></param>
    /// <param name="flags"></param>
    public static void Init(string company, string database, string appName, string version, string userDescription, int flags)
    {
        BsCreateCrashReporter(company, database, appName, version, userDescription, flags);
    }

    /// <summary>
    /// Default user name to be displayed in the BugSplat crash dialog.
    /// </summary>
    /// <param name="name"></param>
    public static void SetDefaultUserName(string name)
    {
        BsSetDefaultUserName(name);
    }

    /// <summary>
    /// Default user email to be displayed in the BugSplat crash dialog.
    /// </summary>
    /// <param name="email"></param>
    public static void SetDefaultUserEmail(string email)
    {
        BsSetDefaultUserEmail(email);
    }

    /// <summary>
    /// Default user description to be displayed in the BugSplat crash dialog.
    /// </summary>
    /// <param name="description"></param>
    public static void SetDefaultUserDescription(string description)
    {
        BsSetDefaultUserDescription(description);
    }

    /// <summary>
    /// Added to the crash report at crash time.
    /// </summary>
    /// <param name="pathToFile"></param>
    public static void AddAdditionalFile(string pathToFile)
    {
        BsAddAdditionalFile(pathToFile);
    }

    /// <summary>
    /// Remove a file that was scheduled to be uploaded at crash time.
    /// </summary>
    /// <param name="pathToFile"></param>
    public static void RemoveAdditionalFile(string pathToFile)
    {
        BsRemoveAdditionalFile(pathToFile);
    }

    /// <summary>
    /// Generate a native crash to test your BugSplat integration.
    /// </summary>
    public static void NativeCrash()
    {
        BsCrashImmediately();
    }
}