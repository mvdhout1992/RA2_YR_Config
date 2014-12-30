using System.IO;
using System.Windows.Forms;

namespace RA2_YR_Config
{
    public static class Files
    {
        public static string Dune2000Cfg = Program.path + "dune2000.cfg";
        public static string LauncherLogfile = Program.path + "Dune2000Launcher.log";
        public static string Dune2000Exe = Program.path + "DUNE2000.EXE";
        public static string Dune2000Dat = Program.path + "DUNE2000.DAT";
        public static string wolapiDll = Program.path + "WOLAPI.DLL";
        public static string wolapiWar = Program.path + "WOLAPI.WAR";
        public static string nlCfg = Program.path + "NL.CFG";
        public static string OldLauncherExecutable = Path.ChangeExtension(Application.ExecutablePath, ".old");
        public static string NewLauncherExecutable = Program.path + "Dune2000Launcher.new";
        public static string dpipxspDll = Program.path + "dpipxsp.dll";
        public static string wsock32Dll = Program.path + "wsock32.dll";
        public static string Dune2000ChatExe = Program.path + "Dune2000Chat.exe";
        public static string MultiplayerMapsIni = Program.path + "Data" + Path.DirectorySeparatorChar + "maps" + Path.DirectorySeparatorChar + "MultiplayerMaps.ini";
        public static string textUib = Program.path + "Data" + Path.DirectorySeparatorChar + "UI_DATA" + Path.DirectorySeparatorChar + "text.uib";
        public static string NRClientCmdExe = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + 
            Path.DirectorySeparatorChar + "ZebraNetworkSystems" + Path.DirectorySeparatorChar + "NeoRouter" + Path.DirectorySeparatorChar + "NRClientCmd.exe";
        public static string NeoRouterInstaller = Program.path + "NeoRouter-2.1.1.4300-free-Setup.exe";
        public static string NeoRouterInstallLog = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) +
            Path.DirectorySeparatorChar + "ZebraNetworkSystems" + Path.DirectorySeparatorChar + "NeoRouter" + Path.DirectorySeparatorChar + "install.log";
        public static string NeoRouterClientXml = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData) +
            Path.DirectorySeparatorChar + "ZebraNetworkSystems" + Path.DirectorySeparatorChar + "NeoRouter" + Path.DirectorySeparatorChar + "Client.xml";
        public static string WritePermissionTestFile = Program.path + "Dune2000LauncherWritePermissionTestFile.txt";
    }
}
