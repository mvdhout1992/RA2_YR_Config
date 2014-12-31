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
        public static IniFile RA2INI, RA2MDINI, KeyboardINI, KeyboardMDINI;
        public static string RA2INIPath = Program.path + "ra2.ini";
        public static string RA2MDINIPath = Program.path + "ra2md.ini";
        public static string KeyboardINIPath = Program.path + "keyboard.ini";
        public static string KeyboardMDINIPath = Program.path + "keyboardmd.ini";

        public static GameHotkeys GameHotkeysRA2 = new GameHotkeys();

        public MainForm()
        {
            InitializeComponent();
        }

        public void Load_Or_Create_INI(IniFile Ini, string path, string RawIniText)
        {
            if (File.Exists(path)) Ini = new IniFile(path);
            else Ini = new IniFile(path, RawIniText);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Load_Settings();
        }

        private void Load_Settings_INI_Files()
        {
            Load_Or_Create_INI(RA2INI, RA2INIPath, Properties.Resources.ra2ini);
            Load_Or_Create_INI(RA2MDINI, RA2MDINIPath, Properties.Resources.ra2mdini);
            Load_Or_Create_INI(KeyboardINI, KeyboardINIPath, Properties.Resources.keyboardini);
            Load_Or_Create_INI(KeyboardMDINI, KeyboardMDINIPath, Properties.Resources.keyboardmdini);
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
            RA2INI = new IniFile(Dune2000IniPath, Properties.Resources.ra2ini);
            aqritCfg = new IniFile(aqritCfgPath, Properties.Resources.aqrit) { BooleanWriteMode = BooleanMode.ONE_ZERO };
            Load_Settings();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void Load_Settings()
        {
            Load_Settings_INI_Files();
            //### dune2000.ini ###
            ResolutionComboBox.Items.Clear();

            List<String> resolutions = screenres.ScreenResolutionOperations.getScreenResolutions(640, 400, 16);
            String resolution = getCurrentGameRes(RA2INI);
            cmbResolutionRA2.DataSource = resolutions;
            if (resolutions.Contains(resolution))
                cmbResolutionRA2.SelectedIndex = resolutions.IndexOf(resolution);

            Load_Hotkey_Editor(HotkeyEditorDataGridRA2, GameHotkeysRA2, RA2INI);

            try
            {
                trbrScrollRateRA2.Value = RA2INI.GetIntValue("Options", "ScrollRate", 20);
                trbtrAudioVolumeRA2.Value = RA2INI.GetIntValue("Options", "SFXVolume", 100);
                trbrMusicVolumeRA2.Value = RA2INI.GetIntValue("Options", "MusicVolume", 100);
            }
            catch
            {
            }
            chbShowToolTipsRA2.Checked = RA2INI.GetBoolValue("Options", "MoviesEnabled", true);
            chbShowTargetLinesRA2.Checked = RA2INI.GetBoolValue("Options", "SoundsEnabled", true);
            VideoBackBufferCheckBox.Checked = RA2INI.GetBoolValue("Options", "VideoBackBuffer", true);
            chbEnableNoCDRA2.Checked = RA2INI.GetBoolValue("Options", "ForceNoCD", true);
            chbShowHiddenObjectsRA2.Checked = RA2INI.GetBoolValue("Options", "SlowSideBarScrolling", false);

        }

        private void Load_Hotkey_Editor(DataGridView dgv, GameHotkeys ghks, IniFile inifile)
        {
            int HotkeysLoadedNum = ghks.Load_Hotkeys(inifile);
            if (HotkeysLoadedNum != 0)
            {
                dgv.Rows.Clear();
                dgv.Rows.Add(HotkeysLoadedNum);
                for (int i = 0; i < HotkeysLoadedNum; i++)
                {
                    dgv.Rows[i].Cells[0].Value = ghks.Get_Hotkey(i).HotkeyName;
                    dgv.Rows[i].Cells[1].Value = ghks.Hotkey_Display_Value(i);
                }
            }
        }

        private void SaveSettings()
        {
            //### dune2000.ini ###
            GameHotkeysRA2.Save_Hotkeys(RA2INI);

            RA2INI.SetIntValue("Options", "ScrollRate", trbrScrollRateRA2.Value);
            RA2INI.SetIntValue("Options", "SFXVolume", trbtrAudioVolumeRA2.Value);
            RA2INI.SetIntValue("Options", "MusicVolume", trbrMusicVolumeRA2.Value);
            RA2INI.SetBoolValue("Options", "MoviesEnabled", chbShowToolTipsRA2.Checked);
            RA2INI.SetBoolValue("Options", "SoundsEnabled", chbShowTargetLinesRA2.Checked);
            RA2INI.SetBoolValue("Options", "VideoBackBuffer", VideoBackBufferCheckBox.Checked);
            RA2INI.SetBoolValue("Options", "ForceNoCD", chbEnableNoCDRA2.Checked);
            RA2INI.SetBoolValue("Options", "SlowSideBarScrolling", chbShowHiddenObjectsRA2.Checked);
            RA2INI.SetStringValue("Options", "GameBitsPerPixel", (string)BitsPerPixelComboBox.SelectedItem);

            var res = ResolutionComboBox.SelectedItem.ToString().Split('x');
            RA2INI.SetStringValue("Options", "GameWidth", res[0]);
            RA2INI.SetStringValue("Options", "GameHeight", res[1]);

            RA2INI.WriteIni();

        }

        private void HotkeyEditorDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            Hotkey_Editor_Key_Down(e, HotkeyEditorDataGridRA2, GameHotkeysRA2);
        }

        private void Hotkey_Editor_Key_Down(KeyEventArgs e, DataGridView dgv, GameHotkeys ghks)
        {
            e.SuppressKeyPress = true;

            if (e.Modifiers != Keys.None && (e.KeyCode == Keys.Menu || e.KeyCode == Keys.ControlKey
                || e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.RControlKey
                || e.KeyCode == Keys.RMenu || e.KeyCode == Keys.RShiftKey))
            {
                HotkeyEditorDataGridRA2.CurrentCell.Value = "";

                if ((int)(e.Modifiers & Keys.Control) == (int)Keys.Control)
                    dgv.CurrentCell.Value += "Crl+";

                if ((int)(e.Modifiers & Keys.Alt) == (int)Keys.Alt)
                    dgv.CurrentCell.Value += "Alt+";

                if ((int)(e.Modifiers & Keys.Shift) == (int)Keys.Shift)
                    dgv.CurrentCell.Value += "Shift";

                return;
            }

            if (!dgv.Visible || dgv.CurrentCell == null) return;

            if (dgv.CurrentCell.ColumnIndex == 0)
                dgv.CurrentCell = dgv.Rows[dgv.CurrentCell.RowIndex].Cells[1];

            ghks.Set_Hotkey_Value(e, dgv.CurrentCell.RowIndex);
            dgv.CurrentCell.Value = ghks.Hotkey_Display_Value(dgv.CurrentCell.RowIndex);
        }

        private void HotkeyEditorDataGrid_MouseEnter(object sender, EventArgs e)
        {
            Hotkey_Editor_Mouse_Enter(HotkeyEditorDataGridRA2);
        }

        private void Hotkey_Editor_Mouse_Enter(DataGridView dgv)
        {
            dgv.Select();
        }

        private void HotkeyEditorDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void HotkeyEditorDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public String getCurrentGameRes(IniFile inifile)
        {
            bool success;
            int width = 800;
            int height = 600;
            width = inifile.GetIntValue("Video", "ScreenWidth", 800, out success);
            if (success)
                height = inifile.GetIntValue("Video", "ScreenHeight", 600, out success);

            return width + "x" + height;
        }

        private void HotkeyEditorDataGrid_KeyUp(object sender, KeyEventArgs e)
        {
            Set_Datagrid_Current_Cell_Value_To_Internal_GameHotkey_Data(HotkeyEditorDataGridRA2);
        }

        private void Set_Datagrid_Current_Cell_Value_To_Internal_GameHotkey_Data(DataGridView dgv)
        {
            dgv.CurrentCell.Value = GameHotkeysRA2.Hotkey_Display_Value(dgv.CurrentCell.RowIndex);
        }

    }
}
