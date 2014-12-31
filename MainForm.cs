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
        public static GameHotkeys GameHotkeysYR = new GameHotkeys();

        public MainForm()
        {
            InitializeComponent();
        }

        public void Load_Or_Create_INI(ref IniFile Ini, string path, string RawIniText)
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
            Load_Or_Create_INI(ref RA2INI, RA2INIPath, Properties.Resources.ra2ini);
            Load_Or_Create_INI(ref RA2MDINI, RA2MDINIPath, Properties.Resources.ra2mdini);
            Load_Or_Create_INI(ref KeyboardINI, KeyboardINIPath, Properties.Resources.keyboardini);
            Load_Or_Create_INI(ref KeyboardMDINI, KeyboardMDINIPath, Properties.Resources.keyboardmdini);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Save_Settings();
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Load_Settings();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Save_Settings();
        }

        private void Load_Settings()
        {
            Load_Settings_INI_Files();
            ResolutionComboBox.Items.Clear();

            Load_Resolutions(cmbResolutionRA2, RA2INI);
            Load_Hotkey_Editor(HotkeyEditorDataGridRA2, GameHotkeysRA2, KeyboardINI);
            Load_Hotkey_Editor(HotkeyEditorDataGridYR, GameHotkeysYR, KeyboardMDINI);

            try
            {
                trbrScrollRateRA2.Value = RA2INI.GetIntValue("Options", "ScrollRate", 1);
                trbrDetailLevelRA2.Value= RA2INI.GetIntValue("Options", "DetailLevel", 2);

                trbrVoiceVolumeRA2.Value = Convert.ToInt32( RA2INI.GetFloatValue("Audio", "VoiceVolume", 0.3) * 20 );
                trbrAudioVolumeRA2.Value = Convert.ToInt32( RA2INI.GetFloatValue("Audio", "SoundVolume", 0.3) * 20 );
                trbrMusicVolumeRA2.Value = Convert.ToInt32( RA2INI.GetFloatValue("Audio", "ScoreVolume", 0.3) * 20 );
            }
            catch
            {
            }

            chbAllowVRAMSidebarRA2.Checked = RA2INI.GetBoolValue("Video", "AllowVRAMSidebar", false);
            chbVideoBackBufferRA2.Checked = RA2INI.GetBoolValue("Video", "VideoBackBuffer", true);

            chbShowToolTipsRA2.Checked = RA2INI.GetBoolValue("Options", "ToolTips", true);
            chbShowTargetLinesRA2.Checked = RA2INI.GetBoolValue("Options", "UnitActionLines", true);

            chbEnableNoCDRA2.Checked = RA2INI.GetBoolValue("Options", "NoCD", true);
            chbShowHiddenObjectsRA2.Checked = RA2INI.GetBoolValue("Options", "ShowHidden", true);
            chbWindowedModeRA2.Checked = RA2INI.GetBoolValue("Video", "Windowed", false);
            chbUseGraphicsPatchRA2.Checked = RA2INI.GetBoolValue("Video", "UseGraphicsPatch", true);
            chbRepeatMusicRA2.Checked = RA2INI.GetBoolValue("Audio", "IsScoreRepeat", true);
            chbShuffleMusicRA2.Checked = RA2INI.GetBoolValue("Audio", "IsScoreShuffle", true);
        }

        private void Load_Resolutions(ComboBox cmbox, IniFile Inifile)
        {
            List<String> resolutions = screenres.ScreenResolutionOperations.getScreenResolutions(640, 400, 16);
            String resolution = getCurrentGameRes(Inifile);
            cmbox.DataSource = resolutions;
            if (resolutions.Contains(resolution))
                cmbox.SelectedIndex = resolutions.IndexOf(resolution);
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

        private void Save_Settings()
        {
            GameHotkeysRA2.Save_Hotkeys(KeyboardINI);
            GameHotkeysYR.Save_Hotkeys(KeyboardMDINI);

            RA2INI.SetFloatValue("Audio", "VoiceVolume", ((double)trbrVoiceVolumeRA2.Value / 20));
            RA2INI.SetFloatValue("Audio", "SoundVolume", ((double)trbrAudioVolumeRA2.Value / 20));
            RA2INI.SetFloatValue("Audio", "ScoreVolume", ((double)trbrMusicVolumeRA2.Value / 20));

            RA2INI.SetIntValue("Options", "ScrollRate", trbrScrollRateRA2.Value);
            RA2INI.SetIntValue("Options", "DetailLevel", trbrDetailLevelRA2.Value);

            var res = cmbResolutionRA2.SelectedItem.ToString().Split('x');
            RA2INI.SetStringValue("Video", "ScreenWidth", res[0]);
            RA2INI.SetStringValue("Video", "ScreenHeight", res[1]);

            RA2INI.SetBoolValue("Video", "AllowVRAMSidebar", chbAllowVRAMSidebarRA2.Checked);
            RA2INI.SetBoolValue("Video", "VideoBackBuffer", chbVideoBackBufferRA2.Checked);

            RA2INI.SetBoolValue("Options", "ToolTips", chbShowToolTipsRA2.Checked);
            RA2INI.SetBoolValue("Options", "UnitActionLines", chbShowTargetLinesRA2.Checked);

            RA2INI.SetBoolValue("Options", "NoCD", chbEnableNoCDRA2.Checked);
            RA2INI.SetBoolValue("Options", "ShowHidden", chbShowHiddenObjectsRA2.Checked);
            RA2INI.SetBoolValue("Video", "Windowed", chbWindowedModeRA2.Checked);
            RA2INI.SetBoolValue("Video", "UseGraphicsPatch", chbUseGraphicsPatchRA2.Checked);
            RA2INI.SetBoolValue("Audio", "IsScoreRepeat", chbRepeatMusicRA2.Checked);
            RA2INI.SetBoolValue("Audio", "IsScoreShuffle", chbShuffleMusicRA2.Checked);

            RA2INI.WriteIni();
        }

        private void HotkeyEditorDataGridRA2_KeyDown(object sender, KeyEventArgs e)
        {
            Hotkey_Editor_Key_Down(e, HotkeyEditorDataGridRA2, GameHotkeysRA2);
        }


        private void HotkeyEditorDataGridYR_KeyDown(object sender, KeyEventArgs e)
        {
            Hotkey_Editor_Key_Down(e, HotkeyEditorDataGridYR, GameHotkeysYR);
        }

        private void Hotkey_Editor_Key_Down(KeyEventArgs e, DataGridView dgv, GameHotkeys ghks)
        {
            e.SuppressKeyPress = true;

            if (e.Modifiers != Keys.None && (e.KeyCode == Keys.Menu || e.KeyCode == Keys.ControlKey
                || e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.RControlKey
                || e.KeyCode == Keys.RMenu || e.KeyCode == Keys.RShiftKey))
            {
                dgv.CurrentCell.Value = "";

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

        private void HotkeyEditorDataGridRA2_MouseEnter(object sender, EventArgs e)
        {
            Hotkey_Editor_Mouse_Enter(HotkeyEditorDataGridRA2);
        }

        private void HotkeyEditorDataGridYR_MouseEnter(object sender, EventArgs e)
        {
            Hotkey_Editor_Mouse_Enter(HotkeyEditorDataGridYR);
        }

        private void Hotkey_Editor_Mouse_Enter(DataGridView dgv)
        {
            dgv.Select();
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

        private void HotkeyEditorDataGridRA2_KeyUp(object sender, KeyEventArgs e)
        {
            Set_Datagrid_Current_Cell_Value_To_Internal_GameHotkey_Data(HotkeyEditorDataGridRA2, GameHotkeysRA2);
        }

        private void HotkeyEditorDataGridYR_KeyUp(object sender, KeyEventArgs e)
        {
            Set_Datagrid_Current_Cell_Value_To_Internal_GameHotkey_Data(HotkeyEditorDataGridYR, GameHotkeysYR);
        }

        private void Set_Datagrid_Current_Cell_Value_To_Internal_GameHotkey_Data(DataGridView dgv, GameHotkeys ghks)
        {
            dgv.CurrentCell.Value = ghks.Hotkey_Display_Value(dgv.CurrentCell.RowIndex);
        }

        private void ButResetToDefaultHotkeysYR_Click(object sender, EventArgs e)
        {
            IniFile OrigKeyboardMDINI = new IniFile("", Properties.Resources.keyboardmdini);
            Load_Hotkey_Editor(HotkeyEditorDataGridYR, GameHotkeysYR, OrigKeyboardMDINI);
        }

        private void butResetToDefaultHotkeysRA2_Click(object sender, EventArgs e)
        {
            IniFile OrigKeyboardINI = new IniFile("", Properties.Resources.keyboardini);
            Load_Hotkey_Editor(HotkeyEditorDataGridRA2, GameHotkeysRA2, OrigKeyboardINI);
        }

    }
}
