using System.IO;
using System.Windows.Forms;

namespace RA2_YR_Config
{
    public static class Files
    {
        public static string OldLauncherExecutable = Path.ChangeExtension(Application.ExecutablePath, ".old");
        public static string NewLauncherExecutable = Program.path + "RA2_YR_Config.new";
    }
}
