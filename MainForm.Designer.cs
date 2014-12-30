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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OptionsTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ForceNoCDCheckBox = new System.Windows.Forms.CheckBox();
            this.SlowSidebarScrollingCheckBox = new System.Windows.Forms.CheckBox();
            this.SoundsEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.MoviesEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.MusicVolumeLabel = new System.Windows.Forms.Label();
            this.MusicVolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.SFXVolumeLabel = new System.Windows.Forms.Label();
            this.SFXVolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.ScrollRateLabel = new System.Windows.Forms.Label();
            this.ScrollRateTrackBar = new System.Windows.Forms.TrackBar();
            this.GameSpeedLabel = new System.Windows.Forms.Label();
            this.GameSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.HotkeyTab = new System.Windows.Forms.TabPage();
            this.HotkeyEditorDataGrid = new System.Windows.Forms.DataGridView();
            this.Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoTab = new System.Windows.Forms.TabPage();
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
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.OptionsTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicVolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SFXVolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollRateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameSpeedTrackBar)).BeginInit();
            this.HotkeyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotkeyEditorDataGrid)).BeginInit();
            this.VideoTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.OptionsTab);
            this.tabControl1.Controls.Add(this.HotkeyTab);
            this.tabControl1.Controls.Add(this.VideoTab);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 316);
            this.tabControl1.TabIndex = 0;
            // 
            // OptionsTab
            // 
            this.OptionsTab.Controls.Add(this.groupBox1);
            this.OptionsTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.OptionsTab.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsTab.Location = new System.Drawing.Point(4, 35);
            this.OptionsTab.Name = "OptionsTab";
            this.OptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsTab.Size = new System.Drawing.Size(578, 277);
            this.OptionsTab.TabIndex = 0;
            this.OptionsTab.Text = "Game Options";
            this.OptionsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ForceNoCDCheckBox);
            this.groupBox1.Controls.Add(this.SlowSidebarScrollingCheckBox);
            this.groupBox1.Controls.Add(this.SoundsEnabledCheckBox);
            this.groupBox1.Controls.Add(this.MoviesEnabledCheckBox);
            this.groupBox1.Controls.Add(this.MusicVolumeLabel);
            this.groupBox1.Controls.Add(this.MusicVolumeTrackBar);
            this.groupBox1.Controls.Add(this.SFXVolumeLabel);
            this.groupBox1.Controls.Add(this.SFXVolumeTrackBar);
            this.groupBox1.Controls.Add(this.ScrollRateLabel);
            this.groupBox1.Controls.Add(this.ScrollRateTrackBar);
            this.groupBox1.Controls.Add(this.GameSpeedLabel);
            this.groupBox1.Controls.Add(this.GameSpeedTrackBar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(566, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Options";
            // 
            // ForceNoCDCheckBox
            // 
            this.ForceNoCDCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ForceNoCDCheckBox.AutoSize = true;
            this.ForceNoCDCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForceNoCDCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForceNoCDCheckBox.Location = new System.Drawing.Point(383, 96);
            this.ForceNoCDCheckBox.Name = "ForceNoCDCheckBox";
            this.ForceNoCDCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ForceNoCDCheckBox.Size = new System.Drawing.Size(102, 22);
            this.ForceNoCDCheckBox.TabIndex = 14;
            this.ForceNoCDCheckBox.Text = "Force No-CD";
            this.ForceNoCDCheckBox.UseVisualStyleBackColor = true;
            // 
            // SlowSidebarScrollingCheckBox
            // 
            this.SlowSidebarScrollingCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SlowSidebarScrollingCheckBox.AutoSize = true;
            this.SlowSidebarScrollingCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlowSidebarScrollingCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlowSidebarScrollingCheckBox.Location = new System.Drawing.Point(319, 127);
            this.SlowSidebarScrollingCheckBox.Name = "SlowSidebarScrollingCheckBox";
            this.SlowSidebarScrollingCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SlowSidebarScrollingCheckBox.Size = new System.Drawing.Size(166, 22);
            this.SlowSidebarScrollingCheckBox.TabIndex = 13;
            this.SlowSidebarScrollingCheckBox.Text = "Slow Sidebar Scrolling";
            this.SlowSidebarScrollingCheckBox.UseVisualStyleBackColor = true;
            // 
            // SoundsEnabledCheckBox
            // 
            this.SoundsEnabledCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SoundsEnabledCheckBox.AutoSize = true;
            this.SoundsEnabledCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SoundsEnabledCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoundsEnabledCheckBox.Location = new System.Drawing.Point(364, 65);
            this.SoundsEnabledCheckBox.Name = "SoundsEnabledCheckBox";
            this.SoundsEnabledCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SoundsEnabledCheckBox.Size = new System.Drawing.Size(121, 22);
            this.SoundsEnabledCheckBox.TabIndex = 11;
            this.SoundsEnabledCheckBox.Text = "Sounds Enabled";
            this.SoundsEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // MoviesEnabledCheckBox
            // 
            this.MoviesEnabledCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesEnabledCheckBox.AutoSize = true;
            this.MoviesEnabledCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoviesEnabledCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoviesEnabledCheckBox.Location = new System.Drawing.Point(367, 34);
            this.MoviesEnabledCheckBox.Name = "MoviesEnabledCheckBox";
            this.MoviesEnabledCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MoviesEnabledCheckBox.Size = new System.Drawing.Size(118, 22);
            this.MoviesEnabledCheckBox.TabIndex = 10;
            this.MoviesEnabledCheckBox.Text = "Movies Enabled";
            this.MoviesEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // MusicVolumeLabel
            // 
            this.MusicVolumeLabel.AutoSize = true;
            this.MusicVolumeLabel.Location = new System.Drawing.Point(59, 129);
            this.MusicVolumeLabel.Name = "MusicVolumeLabel";
            this.MusicVolumeLabel.Size = new System.Drawing.Size(89, 18);
            this.MusicVolumeLabel.TabIndex = 7;
            this.MusicVolumeLabel.Text = "Music Volume";
            // 
            // MusicVolumeTrackBar
            // 
            this.MusicVolumeTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusicVolumeTrackBar.Location = new System.Drawing.Point(154, 129);
            this.MusicVolumeTrackBar.Maximum = 100;
            this.MusicVolumeTrackBar.Name = "MusicVolumeTrackBar";
            this.MusicVolumeTrackBar.Size = new System.Drawing.Size(100, 45);
            this.MusicVolumeTrackBar.TabIndex = 6;
            this.MusicVolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MusicVolumeTrackBar.Value = 100;
            // 
            // SFXVolumeLabel
            // 
            this.SFXVolumeLabel.AutoSize = true;
            this.SFXVolumeLabel.Location = new System.Drawing.Point(68, 98);
            this.SFXVolumeLabel.Name = "SFXVolumeLabel";
            this.SFXVolumeLabel.Size = new System.Drawing.Size(80, 18);
            this.SFXVolumeLabel.TabIndex = 5;
            this.SFXVolumeLabel.Text = "SFX Volume";
            // 
            // SFXVolumeTrackBar
            // 
            this.SFXVolumeTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SFXVolumeTrackBar.Location = new System.Drawing.Point(154, 98);
            this.SFXVolumeTrackBar.Maximum = 100;
            this.SFXVolumeTrackBar.Name = "SFXVolumeTrackBar";
            this.SFXVolumeTrackBar.Size = new System.Drawing.Size(100, 45);
            this.SFXVolumeTrackBar.TabIndex = 4;
            this.SFXVolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SFXVolumeTrackBar.Value = 100;
            // 
            // ScrollRateLabel
            // 
            this.ScrollRateLabel.AutoSize = true;
            this.ScrollRateLabel.Location = new System.Drawing.Point(72, 67);
            this.ScrollRateLabel.Name = "ScrollRateLabel";
            this.ScrollRateLabel.Size = new System.Drawing.Size(76, 18);
            this.ScrollRateLabel.TabIndex = 3;
            this.ScrollRateLabel.Text = "Scroll Rate";
            // 
            // ScrollRateTrackBar
            // 
            this.ScrollRateTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScrollRateTrackBar.Location = new System.Drawing.Point(154, 67);
            this.ScrollRateTrackBar.Maximum = 40;
            this.ScrollRateTrackBar.Minimum = 4;
            this.ScrollRateTrackBar.Name = "ScrollRateTrackBar";
            this.ScrollRateTrackBar.Size = new System.Drawing.Size(100, 45);
            this.ScrollRateTrackBar.TabIndex = 2;
            this.ScrollRateTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ScrollRateTrackBar.Value = 4;
            // 
            // GameSpeedLabel
            // 
            this.GameSpeedLabel.AutoSize = true;
            this.GameSpeedLabel.Location = new System.Drawing.Point(66, 36);
            this.GameSpeedLabel.Name = "GameSpeedLabel";
            this.GameSpeedLabel.Size = new System.Drawing.Size(82, 18);
            this.GameSpeedLabel.TabIndex = 1;
            this.GameSpeedLabel.Text = "Game Speed";
            // 
            // GameSpeedTrackBar
            // 
            this.GameSpeedTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameSpeedTrackBar.Location = new System.Drawing.Point(154, 36);
            this.GameSpeedTrackBar.Maximum = 100;
            this.GameSpeedTrackBar.Minimum = 15;
            this.GameSpeedTrackBar.Name = "GameSpeedTrackBar";
            this.GameSpeedTrackBar.Size = new System.Drawing.Size(100, 45);
            this.GameSpeedTrackBar.TabIndex = 0;
            this.GameSpeedTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GameSpeedTrackBar.Value = 75;
            // 
            // HotkeyTab
            // 
            this.HotkeyTab.Controls.Add(this.HotkeyEditorDataGrid);
            this.HotkeyTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.HotkeyTab.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotkeyTab.Location = new System.Drawing.Point(4, 35);
            this.HotkeyTab.Name = "HotkeyTab";
            this.HotkeyTab.Padding = new System.Windows.Forms.Padding(3);
            this.HotkeyTab.Size = new System.Drawing.Size(578, 277);
            this.HotkeyTab.TabIndex = 1;
            this.HotkeyTab.Text = "Hotkeys";
            this.HotkeyTab.UseVisualStyleBackColor = true;
            // 
            // HotkeyEditorDataGrid
            // 
            this.HotkeyEditorDataGrid.AllowUserToAddRows = false;
            this.HotkeyEditorDataGrid.AllowUserToDeleteRows = false;
            this.HotkeyEditorDataGrid.AllowUserToResizeRows = false;
            this.HotkeyEditorDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HotkeyEditorDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.HotkeyEditorDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HotkeyEditorDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.HotkeyEditorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotkeyEditorDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Function,
            this.AssignedKey});
            this.HotkeyEditorDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HotkeyEditorDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.HotkeyEditorDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.HotkeyEditorDataGrid.Location = new System.Drawing.Point(6, 6);
            this.HotkeyEditorDataGrid.MultiSelect = false;
            this.HotkeyEditorDataGrid.Name = "HotkeyEditorDataGrid";
            this.HotkeyEditorDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HotkeyEditorDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.HotkeyEditorDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HotkeyEditorDataGrid.Size = new System.Drawing.Size(566, 265);
            this.HotkeyEditorDataGrid.TabIndex = 1;
            this.HotkeyEditorDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HotkeyEditorDataGrid_CellContentClick);
            this.HotkeyEditorDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyEditorDataGrid_KeyDown);
            this.HotkeyEditorDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HotkeyEditorDataGrid_MouseClick);
            this.HotkeyEditorDataGrid.MouseEnter += new System.EventHandler(this.HotkeyEditorDataGrid_MouseEnter);
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
            // VideoTab
            // 
            this.VideoTab.Controls.Add(this.groupBox2);
            this.VideoTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.VideoTab.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoTab.Location = new System.Drawing.Point(4, 35);
            this.VideoTab.Name = "VideoTab";
            this.VideoTab.Padding = new System.Windows.Forms.Padding(3);
            this.VideoTab.Size = new System.Drawing.Size(578, 277);
            this.VideoTab.TabIndex = 2;
            this.VideoTab.Text = "Video Options";
            this.VideoTab.UseVisualStyleBackColor = true;
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
            this.groupBox2.Size = new System.Drawing.Size(566, 176);
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
            this.ResolutionLabel.Location = new System.Drawing.Point(57, 139);
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
            this.ResolutionComboBox.Location = new System.Drawing.Point(133, 136);
            this.ResolutionComboBox.Name = "ResolutionComboBox";
            this.ResolutionComboBox.Size = new System.Drawing.Size(112, 26);
            this.ResolutionComboBox.TabIndex = 19;
            // 
            // BitsPerPixelLabel
            // 
            this.BitsPerPixelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BitsPerPixelLabel.AutoSize = true;
            this.BitsPerPixelLabel.Location = new System.Drawing.Point(278, 139);
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
            this.BitsPerPixelComboBox.Location = new System.Drawing.Point(373, 136);
            this.BitsPerPixelComboBox.Name = "BitsPerPixelComboBox";
            this.BitsPerPixelComboBox.Size = new System.Drawing.Size(112, 26);
            this.BitsPerPixelComboBox.TabIndex = 17;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(22, 332);
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
            this.CancelButton.Location = new System.Drawing.Point(486, 332);
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
            this.ResetButton.Location = new System.Drawing.Point(351, 332);
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
            this.ApplyButton.Location = new System.Drawing.Point(157, 332);
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
            this.ClientSize = new System.Drawing.Size(610, 369);
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
            this.OptionsTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicVolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SFXVolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollRateTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameSpeedTrackBar)).EndInit();
            this.HotkeyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HotkeyEditorDataGrid)).EndInit();
            this.VideoTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OptionsTab;
        private System.Windows.Forms.TabPage HotkeyTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label GameSpeedLabel;
        private System.Windows.Forms.TrackBar GameSpeedTrackBar;
        private System.Windows.Forms.Label ScrollRateLabel;
        private System.Windows.Forms.TrackBar ScrollRateTrackBar;
        private System.Windows.Forms.Label MusicVolumeLabel;
        private System.Windows.Forms.TrackBar MusicVolumeTrackBar;
        private System.Windows.Forms.Label SFXVolumeLabel;
        private System.Windows.Forms.TrackBar SFXVolumeTrackBar;
        private System.Windows.Forms.CheckBox ForceNoCDCheckBox;
        private System.Windows.Forms.CheckBox SlowSidebarScrollingCheckBox;
        private System.Windows.Forms.CheckBox SoundsEnabledCheckBox;
        private System.Windows.Forms.CheckBox MoviesEnabledCheckBox;
        private System.Windows.Forms.DataGridView HotkeyEditorDataGrid;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Function;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedKey;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TabPage VideoTab;
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
    }
}

