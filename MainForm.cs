using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Nyerguds.Ini;
using System.IO;

namespace RA2_YR_Config
{
    public partial class MainForm : Form
    {
        public static IniFile Dune2000Ini, aqritCfg;
        public static string Dune2000IniPath = Program.path + "dune2000.ini";
        public static string aqritCfgPath = Program.path + "aqrit.cfg";
        public static string ddrawDllPath = Program.path + "ddraw.dll";
        public static GameHotkeys gameHotkeys = new GameHotkeys();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(Dune2000IniPath)) Dune2000Ini = new IniFile(Dune2000IniPath);
            else Dune2000Ini = new IniFile(Dune2000IniPath, Properties.Resources.dune2000);

            if (File.Exists(aqritCfgPath)) aqritCfg = new IniFile(aqritCfgPath) { BooleanWriteMode = BooleanMode.ONE_ZERO };
            else aqritCfg = new IniFile(aqritCfgPath, Properties.Resources.aqrit) { BooleanWriteMode = BooleanMode.ONE_ZERO };

            LoadSettings();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Dune2000Ini = new IniFile(Dune2000IniPath, Properties.Resources.dune2000);
            aqritCfg = new IniFile(aqritCfgPath, Properties.Resources.aqrit) { BooleanWriteMode = BooleanMode.ONE_ZERO };
            LoadSettings();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void LoadSettings()
        {
            //### dune2000.ini ###
            int HotkeysLoadedNum = gameHotkeys.Load_Hotkeys(Dune2000Ini);
            if (HotkeysLoadedNum != 0)
            {
                HotkeyEditorDataGrid.Rows.Clear();
                HotkeyEditorDataGrid.Rows.Add(HotkeysLoadedNum);
                for (int i = 0; i < HotkeysLoadedNum; i++)
                {
                    HotkeyEditorDataGrid.Rows[i].Cells[0].Value = gameHotkeys.Get_Hotkey(i).HotkeyName;
                    HotkeyEditorDataGrid.Rows[i].Cells[1].Value = gameHotkeys.Hotkey_Display_Value(i);
                }
            }

            try
            {
                GameSpeedTrackBar.Value = Dune2000Ini.GetIntValue("Options", "GameSpeed", 75);
                ScrollRateTrackBar.Value = Dune2000Ini.GetIntValue("Options", "ScrollRate", 20);
                SFXVolumeTrackBar.Value = Dune2000Ini.GetIntValue("Options", "SFXVolume", 100);
                MusicVolumeTrackBar.Value = Dune2000Ini.GetIntValue("Options", "MusicVolume", 100);
            }
            catch
            {
            }
            MoviesEnabledCheckBox.Checked = Dune2000Ini.GetBoolValue("Options", "MoviesEnabled", true);
            SoundsEnabledCheckBox.Checked = Dune2000Ini.GetBoolValue("Options", "SoundsEnabled", true);
            VideoBackBufferCheckBox.Checked = Dune2000Ini.GetBoolValue("Options", "VideoBackBuffer", true);
            ForceNoCDCheckBox.Checked = Dune2000Ini.GetBoolValue("Options", "ForceNoCD", true);
            SlowSidebarScrollingCheckBox.Checked = Dune2000Ini.GetBoolValue("Options", "SlowSideBarScrolling", false);
            BitsPerPixelComboBox.SelectedIndex = (Dune2000Ini.GetIntValue("Options", "GameBitsPerPixel", 16) == 8) ? 0 : 1;

            ResolutionComboBox.Items.Clear();
            try
            {
                var resolutions = screenres.ScreenResolutionOperations.getScreenResolutions(640, 400, 32).ToArray();
                ResolutionComboBox.Items.AddRange(resolutions);
            }
            catch
            {
            }

            if (!ResolutionComboBox.Items.Contains("640x400")) ResolutionComboBox.Items.Insert(0, "640x400");
            ResolutionComboBox.SelectedItem = string.Format("{0}x{1}", Dune2000Ini.GetStringValue("Options", "GameWidth", "640"),
                Dune2000Ini.GetStringValue("Options", "GameHeight", "400"));
            if (ResolutionComboBox.SelectedIndex == -1) ResolutionComboBox.SelectedIndex = 0;

            //### aqrit.cfg ###
            ShowFPSCheckBox.Checked = aqritCfg.GetIntValue("ddraw", "ShowFPS", 0) == 15;
            NoVideoMemoryCheckBox.Checked = aqritCfg.GetBoolValue("ddraw", "NoVideoMemory", false);
            FakeVsyncCheckBox.Checked = aqritCfg.GetBoolValue("ddraw", "FakeVsync", false);
            ForceDirectDrawEmulationCheckBox.Checked = aqritCfg.GetBoolValue("ddraw", "ForceDirectDrawEmulation", false);
            SingleProcessorAffinityCheckBox.Checked = aqritCfg.GetBoolValue("ddraw", "SingleProcAffinity", false);
        }

        private void SaveSettings()
        {
            //### dune2000.ini ###
            gameHotkeys.Save_Hotkeys(Dune2000Ini);

            Dune2000Ini.SetIntValue("Options", "GameSpeed", GameSpeedTrackBar.Value);
            Dune2000Ini.SetIntValue("Options", "ScrollRate", ScrollRateTrackBar.Value);
            Dune2000Ini.SetIntValue("Options", "SFXVolume", SFXVolumeTrackBar.Value);
            Dune2000Ini.SetIntValue("Options", "MusicVolume", MusicVolumeTrackBar.Value);
            Dune2000Ini.SetBoolValue("Options", "MoviesEnabled", MoviesEnabledCheckBox.Checked);
            Dune2000Ini.SetBoolValue("Options", "SoundsEnabled", SoundsEnabledCheckBox.Checked);
            Dune2000Ini.SetBoolValue("Options", "VideoBackBuffer", VideoBackBufferCheckBox.Checked);
            Dune2000Ini.SetBoolValue("Options", "ForceNoCD", ForceNoCDCheckBox.Checked);
            Dune2000Ini.SetBoolValue("Options", "SlowSideBarScrolling", SlowSidebarScrollingCheckBox.Checked);
            Dune2000Ini.SetStringValue("Options", "GameBitsPerPixel", (string)BitsPerPixelComboBox.SelectedItem);

            var res = ResolutionComboBox.SelectedItem.ToString().Split('x');
            Dune2000Ini.SetStringValue("Options", "GameWidth", res[0]);
            Dune2000Ini.SetStringValue("Options", "GameHeight", res[1]);

            Dune2000Ini.WriteIni();

            //### aqrit.cfg ###
            aqritCfg.SetIntValue("ddraw", "ShowFPS", ShowFPSCheckBox.Checked ? 15 : 0);
            aqritCfg.SetBoolValue("ddraw", "NoVideoMemory", NoVideoMemoryCheckBox.Checked);
            aqritCfg.SetBoolValue("ddraw", "FakeVsync", FakeVsyncCheckBox.Checked);
            aqritCfg.SetBoolValue("ddraw", "ForceDirectDrawEmulation", ForceDirectDrawEmulationCheckBox.Checked);
            aqritCfg.SetBoolValue("ddraw", "SingleProcAffinity", SingleProcessorAffinityCheckBox.Checked);

            aqritCfg.WriteIni();

            if (ShowFPSCheckBox.Checked || NoVideoMemoryCheckBox.Checked || FakeVsyncCheckBox.Checked
                || ForceDirectDrawEmulationCheckBox.Checked || SingleProcessorAffinityCheckBox.Checked)
                File.WriteAllBytes(ddrawDllPath, Properties.Resources.ddwrapper);
            else if (File.Exists(ddrawDllPath)) File.Delete(ddrawDllPath);
        }

        private void HotkeyEditorDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

            if (e.Modifiers != Keys.None && (e.KeyCode == Keys.Menu || e.KeyCode == Keys.ControlKey 
                || e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.RControlKey 
                || e.KeyCode == Keys.RMenu || e.KeyCode == Keys.RShiftKey)) return;

            if (!HotkeyEditorDataGrid.Visible || HotkeyEditorDataGrid.CurrentCell == null) return;

            if (HotkeyEditorDataGrid.CurrentCell.ColumnIndex == 0)
                HotkeyEditorDataGrid.CurrentCell = HotkeyEditorDataGrid.Rows[HotkeyEditorDataGrid.CurrentCell.RowIndex].Cells[1];

            gameHotkeys.Set_Hotkey_Value(e, HotkeyEditorDataGrid.CurrentCell.RowIndex);
            HotkeyEditorDataGrid.CurrentCell.Value = gameHotkeys.Hotkey_Display_Value(HotkeyEditorDataGrid.CurrentCell.RowIndex);
        }

        private void HotkeyEditorDataGrid_MouseEnter(object sender, EventArgs e)
        {
            HotkeyEditorDataGrid.Select();
        }

        private void HotkeyEditorDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void HotkeyEditorDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
