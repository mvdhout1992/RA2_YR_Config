using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace RA2_YR_Config
{
    public static class Updater
    {
        public static bool GetUpdates()
        {
            using (var updaterForm = new UpdaterForm())
            {
                if (updaterForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Process.Start(Application.ExecutablePath, Program.SkipUpdateParam);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return true;
                }
                else if (updaterForm.DialogResult != DialogResult.Ignore)
                {
                    return false;
                    //do not allow to continue if update failed
                    //return true;
                }
                else return false;
            }
        }

        public static bool ExecutableWasUpdated()
        {
            for (int i = 0; i < 20 && File.Exists(Files.OldLauncherExecutable); i++)
            {
                try
                {
                    File.Delete(Files.OldLauncherExecutable);
                }
                catch
                {
                    Thread.Sleep(100);
                }
            }

            if (File.Exists(Files.NewLauncherExecutable))
            {
                try
                {
                    if (File.Exists(Files.OldLauncherExecutable)) File.Delete(Files.OldLauncherExecutable);
                    File.Move(Application.ExecutablePath, Files.OldLauncherExecutable);
                    File.Move(Files.NewLauncherExecutable, Application.ExecutablePath);
                    Process.Start(Application.ExecutablePath, Program.SkipUpdateParam);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return true;
            }
            else return false;
        }


    }
}
