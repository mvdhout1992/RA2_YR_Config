namespace RA2_YR_Config
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RA2OptionsTab = new System.Windows.Forms.TabPage();
            this.lblDetailLevelRA2 = new System.Windows.Forms.Label();
            this.trbrDetailLevelRA2 = new System.Windows.Forms.TrackBar();
            this.chbVideoBackBufferRA2 = new System.Windows.Forms.CheckBox();
            this.chbAllowVRAMSidebarRA2 = new System.Windows.Forms.CheckBox();
            this.trbrVoiceVolumeRA2 = new System.Windows.Forms.TrackBar();
            this.lblVoiceVolumeRA2 = new System.Windows.Forms.Label();
            this.chbShuffleMusicRA2 = new System.Windows.Forms.CheckBox();
            this.chbRepeatMusicRA2 = new System.Windows.Forms.CheckBox();
            this.chbUseGraphicsPatchRA2 = new System.Windows.Forms.CheckBox();
            this.chbWindowedModeRA2 = new System.Windows.Forms.CheckBox();
            this.lblScreenResolutionRA2 = new System.Windows.Forms.Label();
            this.cmbResolutionRA2 = new System.Windows.Forms.ComboBox();
            this.chbShowHiddenObjectsRA2 = new System.Windows.Forms.CheckBox();
            this.chbEnableNoCDRA2 = new System.Windows.Forms.CheckBox();
            this.lblScrollRateRA2 = new System.Windows.Forms.Label();
            this.chbShowTargetLinesRA2 = new System.Windows.Forms.CheckBox();
            this.trbrScrollRateRA2 = new System.Windows.Forms.TrackBar();
            this.trbrMusicVolumeRA2 = new System.Windows.Forms.TrackBar();
            this.lblMusicVolumeRA2 = new System.Windows.Forms.Label();
            this.chbShowToolTipsRA2 = new System.Windows.Forms.CheckBox();
            this.lblAudioVolumeRA2 = new System.Windows.Forms.Label();
            this.trbrAudioVolumeRA2 = new System.Windows.Forms.TrackBar();
            this.RA2HotkeyTab = new System.Windows.Forms.TabPage();
            this.HotkeyEditorDataGridRA2 = new System.Windows.Forms.DataGridView();
            this.Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YROptionsTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SingleProcessorAffinityCheckBox = new System.Windows.Forms.CheckBox();
            this.ForceDirectDrawEmulationCheckBox = new System.Windows.Forms.CheckBox();
            this.FakeVsyncCheckBox = new System.Windows.Forms.CheckBox();
            this.NoVideoMemoryCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowFPSCheckBox = new System.Windows.Forms.CheckBox();
            this.VideoBackBufferCheckBox = new System.Windows.Forms.CheckBox();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.ResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.BitsPerPixelLabel = new System.Windows.Forms.Label();
            this.BitsPerPixelComboBox = new System.Windows.Forms.ComboBox();
            this.YRHotkeysTab = new System.Windows.Forms.TabPage();
            this.HotkeyEditorDataGridYR = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.RA2OptionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbrDetailLevelRA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbrVoiceVolumeRA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbrScrollRateRA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbrMusicVolumeRA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbrAudioVolumeRA2)).BeginInit();
            this.RA2HotkeyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotkeyEditorDataGridRA2)).BeginInit();
            this.YROptionsTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.YRHotkeysTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotkeyEditorDataGridYR)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.RA2OptionsTab);
            this.tabControl1.Controls.Add(this.RA2HotkeyTab);
            this.tabControl1.Controls.Add(this.YROptionsTab);
            this.tabControl1.Controls.Add(this.YRHotkeysTab);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // RA2OptionsTab
            // 
            this.RA2OptionsTab.Controls.Add(this.lblDetailLevelRA2);
            this.RA2OptionsTab.Controls.Add(this.trbrDetailLevelRA2);
            this.RA2OptionsTab.Controls.Add(this.chbVideoBackBufferRA2);
            this.RA2OptionsTab.Controls.Add(this.chbAllowVRAMSidebarRA2);
            this.RA2OptionsTab.Controls.Add(this.trbrVoiceVolumeRA2);
            this.RA2OptionsTab.Controls.Add(this.lblVoiceVolumeRA2);
            this.RA2OptionsTab.Controls.Add(this.chbShuffleMusicRA2);
            this.RA2OptionsTab.Controls.Add(this.chbRepeatMusicRA2);
            this.RA2OptionsTab.Controls.Add(this.chbUseGraphicsPatchRA2);
            this.RA2OptionsTab.Controls.Add(this.chbWindowedModeRA2);
            this.RA2OptionsTab.Controls.Add(this.lblScreenResolutionRA2);
            this.RA2OptionsTab.Controls.Add(this.cmbResolutionRA2);
            this.RA2OptionsTab.Controls.Add(this.chbShowHiddenObjectsRA2);
            this.RA2OptionsTab.Controls.Add(this.chbEnableNoCDRA2);
            this.RA2OptionsTab.Controls.Add(this.lblScrollRateRA2);
            this.RA2OptionsTab.Controls.Add(this.chbShowTargetLinesRA2);
            this.RA2OptionsTab.Controls.Add(this.trbrScrollRateRA2);
            this.RA2OptionsTab.Controls.Add(this.trbrMusicVolumeRA2);
            this.RA2OptionsTab.Controls.Add(this.lblMusicVolumeRA2);
            this.RA2OptionsTab.Controls.Add(this.chbShowToolTipsRA2);
            this.RA2OptionsTab.Controls.Add(this.lblAudioVolumeRA2);
            this.RA2OptionsTab.Controls.Add(this.trbrAudioVolumeRA2);
            this.RA2OptionsTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.RA2OptionsTab.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RA2OptionsTab.Location = new System.Drawing.Point(4, 35);
            this.RA2OptionsTab.Name = "RA2OptionsTab";
            this.RA2OptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.RA2OptionsTab.Size = new System.Drawing.Size(625, 322);
            this.RA2OptionsTab.TabIndex = 0;
            this.RA2OptionsTab.Text = "RA2 options";
            this.RA2OptionsTab.UseVisualStyleBackColor = true;
            // 
            // lblDetailLevelRA2
            // 
            this.lblDetailLevelRA2.AutoSize = true;
            this.lblDetailLevelRA2.Location = new System.Drawing.Point(6, 113);
            this.lblDetailLevelRA2.Name = "lblDetailLevelRA2";
            this.lblDetailLevelRA2.Size = new System.Drawing.Size(76, 18);
            this.lblDetailLevelRA2.TabIndex = 34;
            this.lblDetailLevelRA2.Text = "Detail level";
            // 
            // trbrDetailLevelRA2
            // 
            this.trbrDetailLevelRA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trbrDetailLevelRA2.Location = new System.Drawing.Point(95, 113);
            this.trbrDetailLevelRA2.Maximum = 2;
            this.trbrDetailLevelRA2.Name = "trbrDetailLevelRA2";
            this.trbrDetailLevelRA2.Size = new System.Drawing.Size(100, 45);
            this.trbrDetailLevelRA2.TabIndex = 33;
            this.trbrDetailLevelRA2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbrDetailLevelRA2.Value = 2;
            // 
            // chbVideoBackBufferRA2
            // 
            this.chbVideoBackBufferRA2.AutoSize = true;
            this.chbVideoBackBufferRA2.Location = new System.Drawing.Point(223, 161);
            this.chbVideoBackBufferRA2.Name = "chbVideoBackBufferRA2";
            this.chbVideoBackBufferRA2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbVideoBackBufferRA2.Size = new System.Drawing.Size(140, 22);
            this.chbVideoBackBufferRA2.TabIndex = 32;
            this.chbVideoBackBufferRA2.Text = "Video back buffer";
            this.chbVideoBackBufferRA2.UseVisualStyleBackColor = true;
            // 
            // chbAllowVRAMSidebarRA2
            // 
            this.chbAllowVRAMSidebarRA2.AutoSize = true;
            this.chbAllowVRAMSidebarRA2.Location = new System.Drawing.Point(212, 114);
            this.chbAllowVRAMSidebarRA2.Name = "chbAllowVRAMSidebarRA2";
            this.chbAllowVRAMSidebarRA2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbAllowVRAMSidebarRA2.Size = new System.Drawing.Size(151, 22);
            this.chbAllowVRAMSidebarRA2.TabIndex = 31;
            this.chbAllowVRAMSidebarRA2.Text = "Allow VRAM sidebar";
            this.chbAllowVRAMSidebarRA2.UseVisualStyleBackColor = true;
            // 
            // trbrVoiceVolumeRA2
            // 
            this.trbrVoiceVolumeRA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trbrVoiceVolumeRA2.Location = new System.Drawing.Point(92, 277);
            this.trbrVoiceVolumeRA2.Maximum = 20;
            this.trbrVoiceVolumeRA2.Name = "trbrVoiceVolumeRA2";
            this.trbrVoiceVolumeRA2.Size = new System.Drawing.Size(100, 45);
            this.trbrVoiceVolumeRA2.TabIndex = 30;
            this.trbrVoiceVolumeRA2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbrVoiceVolumeRA2.Value = 20;
            // 
            // lblVoiceVolumeRA2
            // 
            this.lblVoiceVolumeRA2.AutoSize = true;
            this.lblVoiceVolumeRA2.Location = new System.Drawing.Point(3, 280);
            this.lblVoiceVolumeRA2.Name = "lblVoiceVolumeRA2";
            this.lblVoiceVolumeRA2.Size = new System.Drawing.Size(87, 18);
            this.lblVoiceVolumeRA2.TabIndex = 29;
            this.lblVoiceVolumeRA2.Text = "Voice Volume";
            // 
            // chbShuffleMusicRA2
            // 
            this.chbShuffleMusicRA2.AutoSize = true;
            this.chbShuffleMusicRA2.Location = new System.Drawing.Point(424, 260);
            this.chbShuffleMusicRA2.Name = "chbShuffleMusicRA2";
            this.chbShuffleMusicRA2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbShuffleMusicRA2.Size = new System.Drawing.Size(116, 22);
            this.chbShuffleMusicRA2.TabIndex = 28;
            this.chbShuffleMusicRA2.Text = " Shuffle music";
            this.chbShuffleMusicRA2.UseVisualStyleBackColor = true;
            // 
            // chbRepeatMusicRA2
            // 
            this.chbRepeatMusicRA2.AutoSize = true;
            this.chbRepeatMusicRA2.Location = new System.Drawing.Point(435, 232);
            this.chbRepeatMusicRA2.Name = "chbRepeatMusicRA2";
            this.chbRepeatMusicRA2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbRepeatMusicRA2.Size = new System.Drawing.Size(105, 22);
            this.chbRepeatMusicRA2.TabIndex = 26;
            this.chbRepeatMusicRA2.Text = "Repeat music";
            this.chbRepeatMusicRA2.UseVisualStyleBackColor = true;
            // 
            // chbUseGraphicsPatchRA2
            // 
            this.chbUseGraphicsPatchRA2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbUseGraphicsPatchRA2.AutoSize = true;
            this.chbUseGraphicsPatchRA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbUseGraphicsPatchRA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbUseGraphicsPatchRA2.Location = new System.Drawing.Point(399, 204);
            this.chbUseGraphicsPatchRA2.Name = "chbUseGraphicsPatchRA2";
            this.chbUseGraphicsPatchRA2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbUseGraphicsPatchRA2.Size = new System.Drawing.Size(139, 22);
            this.chbUseGraphicsPatchRA2.TabIndex = 18;
            this.chbUseGraphicsPatchRA2.Text = "Use graphics patch";
            this.chbUseGraphicsPatchRA2.UseVisualStyleBackColor = true;
            // 
            // chbWindowedModeRA2
            // 
            this.chbWindowedModeRA2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbWindowedModeRA2.AutoSize = true;
            this.chbWindowedModeRA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbWindowedModeRA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbWindowedModeRA2.Location = new System.Drawing.Point(415, 161);
            this.chbWindowedModeRA2.Name = "chbWindowedModeRA2";
            this.chbWindowedModeRA2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbWindowedModeRA2.Size = new System.Drawing.Size(123, 22);
            this.chbWindowedModeRA2.TabIndex = 17;
            this.chbWindowedModeRA2.Text = "Windowed mode";
            this.chbWindowedModeRA2.UseVisualStyleBackColor = true;
            // 
            // lblScreenResolutionRA2
            // 
            this.lblScreenResolutionRA2.AutoSize = true;
            this.lblScreenResolutionRA2.Location = new System.Drawing.Point(6, 19);
            this.lblScreenResolutionRA2.Name = "lblScreenResolutionRA2";
            this.lblScreenResolutionRA2.Size = new System.Drawing.Size(119, 18);
            this.lblScreenResolutionRA2.TabIndex = 15;
            this.lblScreenResolutionRA2.Text = "Screen resolution:";
            // 
            // cmbResolutionRA2
            // 
            this.cmbResolutionRA2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbResolutionRA2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResolutionRA2.FormattingEnabled = true;
            this.cmbResolutionRA2.Location = new System.Drawing.Point(136, 15);
            this.cmbResolutionRA2.Name = "cmbResolutionRA2";
            this.cmbResolutionRA2.Size = new System.Drawing.Size(138, 26);
            this.cmbResolutionRA2.TabIndex = 16;
            // 
            // chbShowHiddenObjectsRA2
            // 
            this.chbShowHiddenObjectsRA2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbShowHiddenObjectsRA2.AutoSize = true;
            this.chbShowHiddenObjectsRA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbShowHiddenObjectsRA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbShowHiddenObjectsRA2.Location = new System.Drawing.Point(387, 113);
            this.chbShowHiddenObjectsRA2.Name = "chbShowHiddenObjectsRA2";
            this.chbShowHiddenObjectsRA2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbShowHiddenObjectsRA2.Size = new System.Drawing.Size(151, 22);
            this.chbShowHiddenObjectsRA2.TabIndex = 13;
            this.chbShowHiddenObjectsRA2.Text = "Show hidden objects";
            this.chbShowHiddenObjectsRA2.UseVisualStyleBackColor = true;
            // 
            // chbEnableNoCDRA2
            // 
            this.chbEnableNoCDRA2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbEnableNoCDRA2.AutoSize = true;
            this.chbEnableNoCDRA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbEnableNoCDRA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbEnableNoCDRA2.Location = new System.Drawing.Point(435, 85);
            this.chbEnableNoCDRA2.Name = "chbEnableNoCDRA2";
            this.chbEnableNoCDRA2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbEnableNoCDRA2.Size = new System.Drawing.Size(103, 22);
            this.chbEnableNoCDRA2.TabIndex = 14;
            this.chbEnableNoCDRA2.Text = "Enable NoCD";
            this.chbEnableNoCDRA2.UseVisualStyleBackColor = true;
            // 
            // lblScrollRateRA2
            // 
            this.lblScrollRateRA2.AutoSize = true;
            this.lblScrollRateRA2.Location = new System.Drawing.Point(3, 165);
            this.lblScrollRateRA2.Name = "lblScrollRateRA2";
            this.lblScrollRateRA2.Size = new System.Drawing.Size(76, 18);
            this.lblScrollRateRA2.TabIndex = 3;
            this.lblScrollRateRA2.Text = "Scroll Rate";
            // 
            // chbShowTargetLinesRA2
            // 
            this.chbShowTargetLinesRA2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbShowTargetLinesRA2.AutoSize = true;
            this.chbShowTargetLinesRA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbShowTargetLinesRA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbShowTargetLinesRA2.Location = new System.Drawing.Point(408, 45);
            this.chbShowTargetLinesRA2.Name = "chbShowTargetLinesRA2";
            this.chbShowTargetLinesRA2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbShowTargetLinesRA2.Size = new System.Drawing.Size(130, 22);
            this.chbShowTargetLinesRA2.TabIndex = 11;
            this.chbShowTargetLinesRA2.Text = "Show target lines";
            this.chbShowTargetLinesRA2.UseVisualStyleBackColor = true;
            // 
            // trbrScrollRateRA2
            // 
            this.trbrScrollRateRA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trbrScrollRateRA2.Location = new System.Drawing.Point(92, 165);
            this.trbrScrollRateRA2.Maximum = 6;
            this.trbrScrollRateRA2.Name = "trbrScrollRateRA2";
            this.trbrScrollRateRA2.Size = new System.Drawing.Size(100, 45);
            this.trbrScrollRateRA2.TabIndex = 2;
            this.trbrScrollRateRA2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbrScrollRateRA2.Value = 4;
            // 
            // trbrMusicVolumeRA2
            // 
            this.trbrMusicVolumeRA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trbrMusicVolumeRA2.Location = new System.Drawing.Point(92, 248);
            this.trbrMusicVolumeRA2.Maximum = 20;
            this.trbrMusicVolumeRA2.Name = "trbrMusicVolumeRA2";
            this.trbrMusicVolumeRA2.Size = new System.Drawing.Size(100, 45);
            this.trbrMusicVolumeRA2.TabIndex = 6;
            this.trbrMusicVolumeRA2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbrMusicVolumeRA2.Value = 20;
            // 
            // lblMusicVolumeRA2
            // 
            this.lblMusicVolumeRA2.AutoSize = true;
            this.lblMusicVolumeRA2.Location = new System.Drawing.Point(6, 248);
            this.lblMusicVolumeRA2.Name = "lblMusicVolumeRA2";
            this.lblMusicVolumeRA2.Size = new System.Drawing.Size(89, 18);
            this.lblMusicVolumeRA2.TabIndex = 7;
            this.lblMusicVolumeRA2.Text = "Music Volume";
            // 
            // chbShowToolTipsRA2
            // 
            this.chbShowToolTipsRA2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbShowToolTipsRA2.AutoSize = true;
            this.chbShowToolTipsRA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbShowToolTipsRA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbShowToolTipsRA2.Location = new System.Drawing.Point(432, 15);
            this.chbShowToolTipsRA2.Name = "chbShowToolTipsRA2";
            this.chbShowToolTipsRA2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbShowToolTipsRA2.Size = new System.Drawing.Size(106, 22);
            this.chbShowToolTipsRA2.TabIndex = 10;
            this.chbShowToolTipsRA2.Text = "Show tooltips";
            this.chbShowToolTipsRA2.UseVisualStyleBackColor = true;
            // 
            // lblAudioVolumeRA2
            // 
            this.lblAudioVolumeRA2.AutoSize = true;
            this.lblAudioVolumeRA2.Location = new System.Drawing.Point(3, 204);
            this.lblAudioVolumeRA2.Name = "lblAudioVolumeRA2";
            this.lblAudioVolumeRA2.Size = new System.Drawing.Size(89, 18);
            this.lblAudioVolumeRA2.TabIndex = 5;
            this.lblAudioVolumeRA2.Text = "Audio Volume";
            // 
            // trbrAudioVolumeRA2
            // 
            this.trbrAudioVolumeRA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trbrAudioVolumeRA2.Location = new System.Drawing.Point(92, 204);
            this.trbrAudioVolumeRA2.Maximum = 20;
            this.trbrAudioVolumeRA2.Name = "trbrAudioVolumeRA2";
            this.trbrAudioVolumeRA2.Size = new System.Drawing.Size(100, 45);
            this.trbrAudioVolumeRA2.TabIndex = 4;
            this.trbrAudioVolumeRA2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbrAudioVolumeRA2.Value = 20;
            // 
            // RA2HotkeyTab
            // 
            this.RA2HotkeyTab.Controls.Add(this.HotkeyEditorDataGridRA2);
            this.RA2HotkeyTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.RA2HotkeyTab.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RA2HotkeyTab.Location = new System.Drawing.Point(4, 35);
            this.RA2HotkeyTab.Name = "RA2HotkeyTab";
            this.RA2HotkeyTab.Padding = new System.Windows.Forms.Padding(3);
            this.RA2HotkeyTab.Size = new System.Drawing.Size(625, 322);
            this.RA2HotkeyTab.TabIndex = 1;
            this.RA2HotkeyTab.Text = "RA2 Hotkeys";
            this.RA2HotkeyTab.UseVisualStyleBackColor = true;
            // 
            // HotkeyEditorDataGridRA2
            // 
            this.HotkeyEditorDataGridRA2.AllowUserToAddRows = false;
            this.HotkeyEditorDataGridRA2.AllowUserToDeleteRows = false;
            this.HotkeyEditorDataGridRA2.AllowUserToResizeRows = false;
            this.HotkeyEditorDataGridRA2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HotkeyEditorDataGridRA2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.HotkeyEditorDataGridRA2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HotkeyEditorDataGridRA2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.HotkeyEditorDataGridRA2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotkeyEditorDataGridRA2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Function,
            this.AssignedKey});
            this.HotkeyEditorDataGridRA2.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HotkeyEditorDataGridRA2.DefaultCellStyle = dataGridViewCellStyle8;
            this.HotkeyEditorDataGridRA2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.HotkeyEditorDataGridRA2.Location = new System.Drawing.Point(6, 6);
            this.HotkeyEditorDataGridRA2.MultiSelect = false;
            this.HotkeyEditorDataGridRA2.Name = "HotkeyEditorDataGridRA2";
            this.HotkeyEditorDataGridRA2.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HotkeyEditorDataGridRA2.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.HotkeyEditorDataGridRA2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HotkeyEditorDataGridRA2.Size = new System.Drawing.Size(613, 310);
            this.HotkeyEditorDataGridRA2.TabIndex = 1;
            this.HotkeyEditorDataGridRA2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyEditorDataGridRA2_KeyDown);
            this.HotkeyEditorDataGridRA2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyEditorDataGridRA2_KeyUp);
            this.HotkeyEditorDataGridRA2.MouseEnter += new System.EventHandler(this.HotkeyEditorDataGridRA2_MouseEnter);
            // 
            // Function
            // 
            this.Function.Frozen = true;
            this.Function.HeaderText = "Function";
            this.Function.Name = "Function";
            this.Function.ReadOnly = true;
            this.Function.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Function.Width = 400;
            // 
            // AssignedKey
            // 
            this.AssignedKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssignedKey.HeaderText = "Assigned Key";
            this.AssignedKey.Name = "AssignedKey";
            this.AssignedKey.ReadOnly = true;
            this.AssignedKey.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // YROptionsTab
            // 
            this.YROptionsTab.Controls.Add(this.groupBox2);
            this.YROptionsTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.YROptionsTab.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YROptionsTab.Location = new System.Drawing.Point(4, 35);
            this.YROptionsTab.Name = "YROptionsTab";
            this.YROptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.YROptionsTab.Size = new System.Drawing.Size(625, 322);
            this.YROptionsTab.TabIndex = 2;
            this.YROptionsTab.Text = "YR options";
            this.YROptionsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.SingleProcessorAffinityCheckBox);
            this.groupBox2.Controls.Add(this.ForceDirectDrawEmulationCheckBox);
            this.groupBox2.Controls.Add(this.FakeVsyncCheckBox);
            this.groupBox2.Controls.Add(this.NoVideoMemoryCheckBox);
            this.groupBox2.Controls.Add(this.ShowFPSCheckBox);
            this.groupBox2.Controls.Add(this.VideoBackBufferCheckBox);
            this.groupBox2.Controls.Add(this.ResolutionLabel);
            this.groupBox2.Controls.Add(this.ResolutionComboBox);
            this.groupBox2.Controls.Add(this.BitsPerPixelLabel);
            this.groupBox2.Controls.Add(this.BitsPerPixelComboBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 221);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video Options";
            // 
            // SingleProcessorAffinityCheckBox
            // 
            this.SingleProcessorAffinityCheckBox.AutoSize = true;
            this.SingleProcessorAffinityCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingleProcessorAffinityCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingleProcessorAffinityCheckBox.Location = new System.Drawing.Point(66, 96);
            this.SingleProcessorAffinityCheckBox.Name = "SingleProcessorAffinityCheckBox";
            this.SingleProcessorAffinityCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SingleProcessorAffinityCheckBox.Size = new System.Drawing.Size(179, 22);
            this.SingleProcessorAffinityCheckBox.TabIndex = 26;
            this.SingleProcessorAffinityCheckBox.Text = "Single Processor Affinity";
            this.SingleProcessorAffinityCheckBox.UseVisualStyleBackColor = true;
            // 
            // ForceDirectDrawEmulationCheckBox
            // 
            this.ForceDirectDrawEmulationCheckBox.AutoSize = true;
            this.ForceDirectDrawEmulationCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForceDirectDrawEmulationCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForceDirectDrawEmulationCheckBox.Location = new System.Drawing.Point(290, 34);
            this.ForceDirectDrawEmulationCheckBox.Name = "ForceDirectDrawEmulationCheckBox";
            this.ForceDirectDrawEmulationCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ForceDirectDrawEmulationCheckBox.Size = new System.Drawing.Size(195, 22);
            this.ForceDirectDrawEmulationCheckBox.TabIndex = 25;
            this.ForceDirectDrawEmulationCheckBox.Text = "Force DirectDraw Emulation";
            this.ForceDirectDrawEmulationCheckBox.UseVisualStyleBackColor = true;
            // 
            // FakeVsyncCheckBox
            // 
            this.FakeVsyncCheckBox.AutoSize = true;
            this.FakeVsyncCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FakeVsyncCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FakeVsyncCheckBox.Location = new System.Drawing.Point(393, 65);
            this.FakeVsyncCheckBox.Name = "FakeVsyncCheckBox";
            this.FakeVsyncCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FakeVsyncCheckBox.Size = new System.Drawing.Size(92, 22);
            this.FakeVsyncCheckBox.TabIndex = 24;
            this.FakeVsyncCheckBox.Text = "Fake Vsync";
            this.FakeVsyncCheckBox.UseVisualStyleBackColor = true;
            // 
            // NoVideoMemoryCheckBox
            // 
            this.NoVideoMemoryCheckBox.AutoSize = true;
            this.NoVideoMemoryCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoVideoMemoryCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoVideoMemoryCheckBox.Location = new System.Drawing.Point(355, 96);
            this.NoVideoMemoryCheckBox.Name = "NoVideoMemoryCheckBox";
            this.NoVideoMemoryCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NoVideoMemoryCheckBox.Size = new System.Drawing.Size(130, 22);
            this.NoVideoMemoryCheckBox.TabIndex = 23;
            this.NoVideoMemoryCheckBox.Text = "No Video Memory";
            this.NoVideoMemoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowFPSCheckBox
            // 
            this.ShowFPSCheckBox.AutoSize = true;
            this.ShowFPSCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowFPSCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowFPSCheckBox.Location = new System.Drawing.Point(160, 65);
            this.ShowFPSCheckBox.Name = "ShowFPSCheckBox";
            this.ShowFPSCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowFPSCheckBox.Size = new System.Drawing.Size(85, 22);
            this.ShowFPSCheckBox.TabIndex = 22;
            this.ShowFPSCheckBox.Text = "Show FPS";
            this.ShowFPSCheckBox.UseVisualStyleBackColor = true;
            // 
            // VideoBackBufferCheckBox
            // 
            this.VideoBackBufferCheckBox.AutoSize = true;
            this.VideoBackBufferCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VideoBackBufferCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VideoBackBufferCheckBox.Location = new System.Drawing.Point(112, 34);
            this.VideoBackBufferCheckBox.Name = "VideoBackBufferCheckBox";
            this.VideoBackBufferCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VideoBackBufferCheckBox.Size = new System.Drawing.Size(133, 22);
            this.VideoBackBufferCheckBox.TabIndex = 21;
            this.VideoBackBufferCheckBox.Text = "Video BackBuffer";
            this.VideoBackBufferCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(104, 139);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(70, 18);
            this.ResolutionLabel.TabIndex = 20;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // ResolutionComboBox
            // 
            this.ResolutionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResolutionComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResolutionComboBox.FormattingEnabled = true;
            this.ResolutionComboBox.ItemHeight = 18;
            this.ResolutionComboBox.Location = new System.Drawing.Point(180, 136);
            this.ResolutionComboBox.Name = "ResolutionComboBox";
            this.ResolutionComboBox.Size = new System.Drawing.Size(112, 26);
            this.ResolutionComboBox.TabIndex = 19;
            // 
            // BitsPerPixelLabel
            // 
            this.BitsPerPixelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BitsPerPixelLabel.AutoSize = true;
            this.BitsPerPixelLabel.Location = new System.Drawing.Point(325, 139);
            this.BitsPerPixelLabel.Name = "BitsPerPixelLabel";
            this.BitsPerPixelLabel.Size = new System.Drawing.Size(89, 18);
            this.BitsPerPixelLabel.TabIndex = 18;
            this.BitsPerPixelLabel.Text = "Bits Per Pixel";
            // 
            // BitsPerPixelComboBox
            // 
            this.BitsPerPixelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BitsPerPixelComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BitsPerPixelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BitsPerPixelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BitsPerPixelComboBox.FormattingEnabled = true;
            this.BitsPerPixelComboBox.ItemHeight = 18;
            this.BitsPerPixelComboBox.Items.AddRange(new object[] {
            "8",
            "16"});
            this.BitsPerPixelComboBox.Location = new System.Drawing.Point(420, 136);
            this.BitsPerPixelComboBox.Name = "BitsPerPixelComboBox";
            this.BitsPerPixelComboBox.Size = new System.Drawing.Size(112, 26);
            this.BitsPerPixelComboBox.TabIndex = 17;
            // 
            // YRHotkeysTab
            // 
            this.YRHotkeysTab.Controls.Add(this.HotkeyEditorDataGridYR);
            this.YRHotkeysTab.Location = new System.Drawing.Point(4, 35);
            this.YRHotkeysTab.Name = "YRHotkeysTab";
            this.YRHotkeysTab.Padding = new System.Windows.Forms.Padding(3);
            this.YRHotkeysTab.Size = new System.Drawing.Size(625, 322);
            this.YRHotkeysTab.TabIndex = 3;
            this.YRHotkeysTab.Text = "YR hotkeys";
            this.YRHotkeysTab.UseVisualStyleBackColor = true;
            // 
            // HotkeyEditorDataGridYR
            // 
            this.HotkeyEditorDataGridYR.AllowUserToDeleteRows = false;
            this.HotkeyEditorDataGridYR.AllowUserToOrderColumns = true;
            this.HotkeyEditorDataGridYR.AllowUserToResizeRows = false;
            this.HotkeyEditorDataGridYR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HotkeyEditorDataGridYR.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.HotkeyEditorDataGridYR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HotkeyEditorDataGridYR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.HotkeyEditorDataGridYR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotkeyEditorDataGridYR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.HotkeyEditorDataGridYR.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HotkeyEditorDataGridYR.DefaultCellStyle = dataGridViewCellStyle11;
            this.HotkeyEditorDataGridYR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.HotkeyEditorDataGridYR.Location = new System.Drawing.Point(0, 0);
            this.HotkeyEditorDataGridYR.MultiSelect = false;
            this.HotkeyEditorDataGridYR.Name = "HotkeyEditorDataGridYR";
            this.HotkeyEditorDataGridYR.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HotkeyEditorDataGridYR.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.HotkeyEditorDataGridYR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HotkeyEditorDataGridYR.Size = new System.Drawing.Size(456, 322);
            this.HotkeyEditorDataGridYR.TabIndex = 2;
            this.HotkeyEditorDataGridYR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyEditorDataGridYR_KeyDown);
            this.HotkeyEditorDataGridYR.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyEditorDataGridYR_KeyUp);
            this.HotkeyEditorDataGridYR.MouseEnter += new System.EventHandler(this.HotkeyEditorDataGridYR_MouseEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Function";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.FillWeight = 600F;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Assigned Key";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 600;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 600;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(22, 377);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(102, 27);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(533, 377);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(102, 27);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(398, 377);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(102, 27);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ApplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton.Location = new System.Drawing.Point(157, 377);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(102, 27);
            this.ApplyButton.TabIndex = 4;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 414);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dune 2000 Config";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.RA2OptionsTab.ResumeLayout(false);
            this.RA2OptionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbrDetailLevelRA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbrVoiceVolumeRA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbrScrollRateRA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbrMusicVolumeRA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbrAudioVolumeRA2)).EndInit();
            this.RA2HotkeyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HotkeyEditorDataGridRA2)).EndInit();
            this.YROptionsTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.YRHotkeysTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HotkeyEditorDataGridYR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RA2OptionsTab;
        private System.Windows.Forms.TabPage RA2HotkeyTab;
        private System.Windows.Forms.DataGridView HotkeyEditorDataGridRA2;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Function;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedKey;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TabPage YROptionsTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.ComboBox ResolutionComboBox;
        private System.Windows.Forms.Label BitsPerPixelLabel;
        private System.Windows.Forms.ComboBox BitsPerPixelComboBox;
        private System.Windows.Forms.CheckBox VideoBackBufferCheckBox;
        private System.Windows.Forms.CheckBox ShowFPSCheckBox;
        private System.Windows.Forms.CheckBox NoVideoMemoryCheckBox;
        private System.Windows.Forms.CheckBox ForceDirectDrawEmulationCheckBox;
        private System.Windows.Forms.CheckBox FakeVsyncCheckBox;
        private System.Windows.Forms.CheckBox SingleProcessorAffinityCheckBox;
        private System.Windows.Forms.TabPage YRHotkeysTab;
        private System.Windows.Forms.DataGridView HotkeyEditorDataGridYR;
        private System.Windows.Forms.CheckBox chbShowHiddenObjectsRA2;
        private System.Windows.Forms.CheckBox chbEnableNoCDRA2;
        private System.Windows.Forms.Label lblScrollRateRA2;
        private System.Windows.Forms.CheckBox chbShowTargetLinesRA2;
        private System.Windows.Forms.TrackBar trbrScrollRateRA2;
        private System.Windows.Forms.TrackBar trbrMusicVolumeRA2;
        private System.Windows.Forms.Label lblMusicVolumeRA2;
        private System.Windows.Forms.CheckBox chbShowToolTipsRA2;
        private System.Windows.Forms.Label lblAudioVolumeRA2;
        private System.Windows.Forms.TrackBar trbrAudioVolumeRA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.CheckBox chbShuffleMusicRA2;
        private System.Windows.Forms.CheckBox chbRepeatMusicRA2;
        private System.Windows.Forms.CheckBox chbUseGraphicsPatchRA2;
        private System.Windows.Forms.CheckBox chbWindowedModeRA2;
        private System.Windows.Forms.Label lblScreenResolutionRA2;
        private System.Windows.Forms.ComboBox cmbResolutionRA2;
        private System.Windows.Forms.TrackBar trbrVoiceVolumeRA2;
        private System.Windows.Forms.Label lblVoiceVolumeRA2;
        private System.Windows.Forms.Label lblDetailLevelRA2;
        private System.Windows.Forms.TrackBar trbrDetailLevelRA2;
        private System.Windows.Forms.CheckBox chbVideoBackBufferRA2;
        private System.Windows.Forms.CheckBox chbAllowVRAMSidebarRA2;
    }
}

