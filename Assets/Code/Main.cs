using System.IO;
using UnityEngine;

public class Main : MonoBehaviour {

    static readonly string TempDir = Path.GetTempPath();

    void Start()
    {
        var flags = BugSplat.MDSF_LOGCONSOLE | BugSplat.MDSF_LOGFILE | BugSplat.MDSF_NONINTERACTIVE;
        var additionalFilePath = Path.Combine(TempDir, "additionalFile.txt");
        File.WriteAllText(additionalFilePath, "Hello world!");

        BugSplat.Init(Application.companyName, "Fred", Application.productName, Application.version, "Test description", flags);
        BugSplat.AddAdditionalFile(additionalFilePath);
        BugSplat.SetDefaultUserDescription("BugSplat rocks!");
        BugSplat.SetDefaultUserEmail("fred@bedrock.com");
        BugSplat.SetDefaultUserName("Fred Flintstone");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            BugSplat.NativeCrash();
        }
    }
}
