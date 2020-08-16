﻿namespace TimetableManagementSystem.Locations
{
    partial class Location
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.loc_tabcontrol = new MetroFramework.Controls.MetroTabControl();
            this.viewloc_tab = new System.Windows.Forms.TabPage();
            this.locationview_panel = new System.Windows.Forms.Panel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.sort_btn = new MetroFramework.Controls.MetroButton();
            this.loc_dgridv = new System.Windows.Forms.DataGridView();
            this.search_btn = new MetroFramework.Controls.MetroButton();
            this.addloc_tab = new System.Windows.Forms.TabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.clr_btn = new MetroFramework.Controls.MetroButton();
            this.addloc_btn = new MetroFramework.Controls.MetroButton();
            this.capacity_cmb = new System.Windows.Forms.NumericUpDown();
            this.roomtype_cmb = new MetroFramework.Controls.MetroComboBox();
            this.room_cmb = new MetroFramework.Controls.MetroComboBox();
            this.building_cmb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.editloc_tab = new System.Windows.Forms.TabPage();
            this.editloc_panel = new MetroFramework.Controls.MetroPanel();
            this.delete_btn = new MetroFramework.Controls.MetroButton();
            this.editloc_btn = new MetroFramework.Controls.MetroButton();
            this.editcap_cmb = new System.Windows.Forms.NumericUpDown();
            this.room_type_txt_box = new MetroFramework.Controls.MetroComboBox();
            this.editroom_cmb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.locations_lbl = new MetroFramework.Controls.MetroLabel();
            this.edit_building_txt_box = new MetroFramework.Controls.MetroTextBox();
            this.loc_tabcontrol.SuspendLayout();
            this.viewloc_tab.SuspendLayout();
            this.locationview_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loc_dgridv)).BeginInit();
            this.addloc_tab.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity_cmb)).BeginInit();
            this.editloc_tab.SuspendLayout();
            this.editloc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editcap_cmb)).BeginInit();
            this.SuspendLayout();
            // 
            // loc_tabcontrol
            // 
            this.loc_tabcontrol.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.loc_tabcontrol.Controls.Add(this.viewloc_tab);
            this.loc_tabcontrol.Controls.Add(this.addloc_tab);
            this.loc_tabcontrol.Controls.Add(this.editloc_tab);
            this.loc_tabcontrol.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.loc_tabcontrol.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.loc_tabcontrol.Location = new System.Drawing.Point(138, 120);
            this.loc_tabcontrol.Name = "loc_tabcontrol";
            this.loc_tabcontrol.SelectedIndex = 1;
            this.loc_tabcontrol.Size = new System.Drawing.Size(788, 461);
            this.loc_tabcontrol.Style = MetroFramework.MetroColorStyle.Blue;
            this.loc_tabcontrol.TabIndex = 0;
            this.loc_tabcontrol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loc_tabcontrol.UseCustomBackColor = true;
            this.loc_tabcontrol.UseCustomForeColor = true;
            this.loc_tabcontrol.UseSelectable = true;
            this.loc_tabcontrol.UseStyleColors = true;
            // 
            // viewloc_tab
            // 
            this.viewloc_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewloc_tab.Controls.Add(this.locationview_panel);
            this.viewloc_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewloc_tab.Location = new System.Drawing.Point(4, 37);
            this.viewloc_tab.Margin = new System.Windows.Forms.Padding(7);
            this.viewloc_tab.Name = "viewloc_tab";
            this.viewloc_tab.Padding = new System.Windows.Forms.Padding(3);
            this.viewloc_tab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewloc_tab.Size = new System.Drawing.Size(780, 420);
            this.viewloc_tab.TabIndex = 0;
            this.viewloc_tab.Text = "View Locations";
            this.viewloc_tab.UseVisualStyleBackColor = true;
            // 
            // locationview_panel
            // 
            this.locationview_panel.Controls.Add(this.metroTextBox1);
            this.locationview_panel.Controls.Add(this.metroComboBox1);
            this.locationview_panel.Controls.Add(this.sort_btn);
            this.locationview_panel.Controls.Add(this.loc_dgridv);
            this.locationview_panel.Controls.Add(this.search_btn);
            this.locationview_panel.Location = new System.Drawing.Point(-1, -1);
            this.locationview_panel.Name = "locationview_panel";
            this.locationview_panel.Size = new System.Drawing.Size(779, 419);
            this.locationview_panel.TabIndex = 0;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(35, 22);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(180, 30);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Building",
            "Capacity",
            "Room Type"});
            this.metroComboBox1.Location = new System.Drawing.Point(490, 22);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(138, 29);
            this.metroComboBox1.TabIndex = 16;
            this.metroComboBox1.UseSelectable = true;
            // 
            // sort_btn
            // 
            this.sort_btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.sort_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.sort_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.sort_btn.Location = new System.Drawing.Point(655, 21);
            this.sort_btn.Margin = new System.Windows.Forms.Padding(2);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(105, 30);
            this.sort_btn.TabIndex = 17;
            this.sort_btn.Text = "Sort";
            this.sort_btn.UseCustomBackColor = true;
            this.sort_btn.UseCustomForeColor = true;
            this.sort_btn.UseSelectable = true;
            // 
            // loc_dgridv
            // 
            this.loc_dgridv.AllowUserToAddRows = false;
            this.loc_dgridv.AllowUserToResizeColumns = false;
            this.loc_dgridv.AllowUserToResizeRows = false;
            this.loc_dgridv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loc_dgridv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loc_dgridv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.loc_dgridv.ColumnHeadersHeight = 29;
            this.loc_dgridv.Location = new System.Drawing.Point(22, 80);
            this.loc_dgridv.MultiSelect = false;
            this.loc_dgridv.Name = "loc_dgridv";
            this.loc_dgridv.ReadOnly = true;
            this.loc_dgridv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loc_dgridv.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.loc_dgridv.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.loc_dgridv.RowTemplate.Height = 24;
            this.loc_dgridv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loc_dgridv.Size = new System.Drawing.Size(738, 316);
            this.loc_dgridv.TabIndex = 18;
            this.loc_dgridv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loc_dgridv_CellClick);
            this.loc_dgridv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loc_dgridv_CellDoubleClick);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.search_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.search_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.search_btn.Location = new System.Drawing.Point(232, 22);
            this.search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(105, 30);
            this.search_btn.TabIndex = 15;
            this.search_btn.Text = "Search";
            this.search_btn.UseCustomBackColor = true;
            this.search_btn.UseCustomForeColor = true;
            this.search_btn.UseSelectable = true;
            // 
            // addloc_tab
            // 
            this.addloc_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addloc_tab.Controls.Add(this.metroPanel2);
            this.addloc_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addloc_tab.Location = new System.Drawing.Point(4, 37);
            this.addloc_tab.Name = "addloc_tab";
            this.addloc_tab.Size = new System.Drawing.Size(780, 420);
            this.addloc_tab.TabIndex = 1;
            this.addloc_tab.Text = "Add Locations";
            this.addloc_tab.UseVisualStyleBackColor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel2.Controls.Add(this.clr_btn);
            this.metroPanel2.Controls.Add(this.addloc_btn);
            this.metroPanel2.Controls.Add(this.capacity_cmb);
            this.metroPanel2.Controls.Add(this.roomtype_cmb);
            this.metroPanel2.Controls.Add(this.room_cmb);
            this.metroPanel2.Controls.Add(this.building_cmb);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(2, -1);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(776, 419);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // clr_btn
            // 
            this.clr_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.clr_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clr_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.clr_btn.Location = new System.Drawing.Point(404, 328);
            this.clr_btn.Margin = new System.Windows.Forms.Padding(2);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(150, 40);
            this.clr_btn.TabIndex = 38;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseCustomBackColor = true;
            this.clr_btn.UseCustomForeColor = true;
            this.clr_btn.UseSelectable = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // addloc_btn
            // 
            this.addloc_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addloc_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addloc_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.addloc_btn.Location = new System.Drawing.Point(237, 328);
            this.addloc_btn.Margin = new System.Windows.Forms.Padding(2);
            this.addloc_btn.Name = "addloc_btn";
            this.addloc_btn.Size = new System.Drawing.Size(150, 40);
            this.addloc_btn.TabIndex = 37;
            this.addloc_btn.Text = "Add Location";
            this.addloc_btn.UseCustomBackColor = true;
            this.addloc_btn.UseCustomForeColor = true;
            this.addloc_btn.UseSelectable = true;
            this.addloc_btn.Click += new System.EventHandler(this.addloc_btn_Click);
            // 
            // capacity_cmb
            // 
            this.capacity_cmb.AutoSize = true;
            this.capacity_cmb.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.capacity_cmb.Location = new System.Drawing.Point(389, 190);
            this.capacity_cmb.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.capacity_cmb.Name = "capacity_cmb";
            this.capacity_cmb.Size = new System.Drawing.Size(100, 22);
            this.capacity_cmb.TabIndex = 36;
            // 
            // roomtype_cmb
            // 
            this.roomtype_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomtype_cmb.FormattingEnabled = true;
            this.roomtype_cmb.ItemHeight = 23;
            this.roomtype_cmb.Items.AddRange(new object[] {
            "Lecture Hall",
            "PC Lab",
            "Engineering Lab"});
            this.roomtype_cmb.Location = new System.Drawing.Point(389, 251);
            this.roomtype_cmb.Name = "roomtype_cmb";
            this.roomtype_cmb.PromptText = "Select Room Type";
            this.roomtype_cmb.Size = new System.Drawing.Size(200, 29);
            this.roomtype_cmb.TabIndex = 35;
            this.roomtype_cmb.UseSelectable = true;
            // 
            // room_cmb
            // 
            this.room_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.room_cmb.FormattingEnabled = true;
            this.room_cmb.ItemHeight = 23;
            this.room_cmb.Location = new System.Drawing.Point(389, 129);
            this.room_cmb.Name = "room_cmb";
            this.room_cmb.PromptText = "Select Room";
            this.room_cmb.Size = new System.Drawing.Size(200, 29);
            this.room_cmb.TabIndex = 34;
            this.room_cmb.UseSelectable = true;
            this.room_cmb.DropDown += new System.EventHandler(this.room_cmb_DropDown);
            // 
            // building_cmb
            // 
            this.building_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.building_cmb.FormattingEnabled = true;
            this.building_cmb.ItemHeight = 23;
            this.building_cmb.Location = new System.Drawing.Point(389, 72);
            this.building_cmb.Name = "building_cmb";
            this.building_cmb.PromptText = "Select Building";
            this.building_cmb.Size = new System.Drawing.Size(200, 29);
            this.building_cmb.TabIndex = 33;
            this.building_cmb.UseSelectable = true;
            this.building_cmb.DropDown += new System.EventHandler(this.building_cmb_DropDown);
            this.building_cmb.SelectedIndexChanged += new System.EventHandler(this.building_cmb_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(168, 251);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(180, 30);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "Room Type";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(168, 190);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(180, 30);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Capacity";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(168, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(180, 30);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Room";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(303, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 25);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Add Locations";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(168, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(180, 30);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Building";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editloc_tab
            // 
            this.editloc_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editloc_tab.Controls.Add(this.editloc_panel);
            this.editloc_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editloc_tab.Location = new System.Drawing.Point(4, 37);
            this.editloc_tab.Name = "editloc_tab";
            this.editloc_tab.Size = new System.Drawing.Size(780, 420);
            this.editloc_tab.TabIndex = 2;
            this.editloc_tab.Text = "Edit/Delete Locations";
            this.editloc_tab.UseVisualStyleBackColor = true;
            // 
            // editloc_panel
            // 
            this.editloc_panel.BackColor = System.Drawing.Color.Transparent;
            this.editloc_panel.Controls.Add(this.edit_building_txt_box);
            this.editloc_panel.Controls.Add(this.delete_btn);
            this.editloc_panel.Controls.Add(this.editloc_btn);
            this.editloc_panel.Controls.Add(this.editcap_cmb);
            this.editloc_panel.Controls.Add(this.room_type_txt_box);
            this.editloc_panel.Controls.Add(this.editroom_cmb);
            this.editloc_panel.Controls.Add(this.metroLabel6);
            this.editloc_panel.Controls.Add(this.metroLabel7);
            this.editloc_panel.Controls.Add(this.metroLabel8);
            this.editloc_panel.Controls.Add(this.metroLabel9);
            this.editloc_panel.Controls.Add(this.metroLabel10);
            this.editloc_panel.HorizontalScrollbarBarColor = true;
            this.editloc_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.editloc_panel.HorizontalScrollbarSize = 10;
            this.editloc_panel.Location = new System.Drawing.Point(1, 0);
            this.editloc_panel.Name = "editloc_panel";
            this.editloc_panel.Size = new System.Drawing.Size(776, 419);
            this.editloc_panel.TabIndex = 1;
            this.editloc_panel.UseCustomBackColor = true;
            this.editloc_panel.VerticalScrollbarBarColor = true;
            this.editloc_panel.VerticalScrollbarHighlightOnWheel = false;
            this.editloc_panel.VerticalScrollbarSize = 10;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.delete_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.delete_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_btn.Location = new System.Drawing.Point(404, 328);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(150, 40);
            this.delete_btn.TabIndex = 38;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseCustomBackColor = true;
            this.delete_btn.UseCustomForeColor = true;
            this.delete_btn.UseSelectable = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // editloc_btn
            // 
            this.editloc_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.editloc_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.editloc_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.editloc_btn.Location = new System.Drawing.Point(237, 328);
            this.editloc_btn.Margin = new System.Windows.Forms.Padding(2);
            this.editloc_btn.Name = "editloc_btn";
            this.editloc_btn.Size = new System.Drawing.Size(150, 40);
            this.editloc_btn.TabIndex = 37;
            this.editloc_btn.Text = "Update Location";
            this.editloc_btn.UseCustomBackColor = true;
            this.editloc_btn.UseCustomForeColor = true;
            this.editloc_btn.UseSelectable = true;
            this.editloc_btn.Click += new System.EventHandler(this.editloc_btn_Click);
            // 
            // editcap_cmb
            // 
            this.editcap_cmb.AutoSize = true;
            this.editcap_cmb.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.editcap_cmb.Location = new System.Drawing.Point(389, 190);
            this.editcap_cmb.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.editcap_cmb.Name = "editcap_cmb";
            this.editcap_cmb.Size = new System.Drawing.Size(100, 22);
            this.editcap_cmb.TabIndex = 36;
            // 
            // room_type_txt_box
            // 
            this.room_type_txt_box.AllowDrop = true;
            this.room_type_txt_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.room_type_txt_box.FormattingEnabled = true;
            this.room_type_txt_box.ItemHeight = 23;
            this.room_type_txt_box.Items.AddRange(new object[] {
            "Lecture Hall",
            "PC Lab",
            "Engineering Lab"});
            this.room_type_txt_box.Location = new System.Drawing.Point(389, 251);
            this.room_type_txt_box.Name = "room_type_txt_box";
            this.room_type_txt_box.Size = new System.Drawing.Size(234, 29);
            this.room_type_txt_box.TabIndex = 35;
            this.room_type_txt_box.UseSelectable = true;
            // 
            // editroom_cmb
            // 
            this.editroom_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editroom_cmb.FormattingEnabled = true;
            this.editroom_cmb.ItemHeight = 23;
            this.editroom_cmb.Location = new System.Drawing.Point(389, 73);
            this.editroom_cmb.Name = "editroom_cmb";
            this.editroom_cmb.PromptText = "Select Room";
            this.editroom_cmb.Size = new System.Drawing.Size(234, 29);
            this.editroom_cmb.TabIndex = 34;
            this.editroom_cmb.UseSelectable = true;
            this.editroom_cmb.DropDown += new System.EventHandler(this.editroom_cmb_DropDown);
            this.editroom_cmb.SelectedIndexChanged += new System.EventHandler(this.editroom_cmb_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(168, 251);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(180, 30);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Room Type";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel7
            // 
            this.metroLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(168, 190);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(180, 30);
            this.metroLabel7.TabIndex = 31;
            this.metroLabel7.Text = "Capacity";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel8
            // 
            this.metroLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(168, 72);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(180, 30);
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "Room";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(303, 19);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(123, 25);
            this.metroLabel9.TabIndex = 29;
            this.metroLabel9.Text = "Edit Location";
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(168, 129);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(180, 30);
            this.metroLabel10.TabIndex = 16;
            this.metroLabel10.Text = "Building";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locations_lbl
            // 
            this.locations_lbl.AutoSize = true;
            this.locations_lbl.BackColor = System.Drawing.Color.Transparent;
            this.locations_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.locations_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.locations_lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.locations_lbl.Location = new System.Drawing.Point(468, 75);
            this.locations_lbl.Name = "locations_lbl";
            this.locations_lbl.Size = new System.Drawing.Size(93, 25);
            this.locations_lbl.TabIndex = 28;
            this.locations_lbl.Text = "Locations";
            this.locations_lbl.UseCustomBackColor = true;
            // 
            // edit_building_txt_box
            // 
            // 
            // 
            // 
            this.edit_building_txt_box.CustomButton.Image = null;
            this.edit_building_txt_box.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.edit_building_txt_box.CustomButton.Name = "";
            this.edit_building_txt_box.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.edit_building_txt_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.edit_building_txt_box.CustomButton.TabIndex = 1;
            this.edit_building_txt_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.edit_building_txt_box.CustomButton.UseSelectable = true;
            this.edit_building_txt_box.CustomButton.Visible = false;
            this.edit_building_txt_box.Lines = new string[0];
            this.edit_building_txt_box.Location = new System.Drawing.Point(389, 129);
            this.edit_building_txt_box.MaxLength = 32767;
            this.edit_building_txt_box.Name = "edit_building_txt_box";
            this.edit_building_txt_box.PasswordChar = '\0';
            this.edit_building_txt_box.ReadOnly = true;
            this.edit_building_txt_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.edit_building_txt_box.SelectedText = "";
            this.edit_building_txt_box.SelectionLength = 0;
            this.edit_building_txt_box.SelectionStart = 0;
            this.edit_building_txt_box.ShortcutsEnabled = true;
            this.edit_building_txt_box.Size = new System.Drawing.Size(234, 25);
            this.edit_building_txt_box.TabIndex = 40;
            this.edit_building_txt_box.UseSelectable = true;
            this.edit_building_txt_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.edit_building_txt_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Location
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::TimetableManagementSystem.Properties.Resources.Background;
            this.BackMaxSize = 960;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.locations_lbl);
            this.Controls.Add(this.loc_tabcontrol);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Location";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "Location";
            this.Load += new System.EventHandler(this.Location_Load);
            this.loc_tabcontrol.ResumeLayout(false);
            this.viewloc_tab.ResumeLayout(false);
            this.locationview_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loc_dgridv)).EndInit();
            this.addloc_tab.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity_cmb)).EndInit();
            this.editloc_tab.ResumeLayout(false);
            this.editloc_panel.ResumeLayout(false);
            this.editloc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editcap_cmb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl loc_tabcontrol;
        private System.Windows.Forms.TabPage viewloc_tab;
        private System.Windows.Forms.TabPage addloc_tab;
        private System.Windows.Forms.TabPage editloc_tab;
        private MetroFramework.Controls.MetroLabel locations_lbl;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton clr_btn;
        private MetroFramework.Controls.MetroButton addloc_btn;
        private MetroFramework.Controls.MetroPanel editloc_panel;
        private MetroFramework.Controls.MetroButton delete_btn;
        private MetroFramework.Controls.MetroButton editloc_btn;
        private System.Windows.Forms.NumericUpDown editcap_cmb;
        private MetroFramework.Controls.MetroComboBox room_type_txt_box;
        private MetroFramework.Controls.MetroComboBox editroom_cmb;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        public System.Windows.Forms.NumericUpDown capacity_cmb;
        public MetroFramework.Controls.MetroComboBox roomtype_cmb;
        public MetroFramework.Controls.MetroComboBox room_cmb;
        public MetroFramework.Controls.MetroComboBox building_cmb;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.DataGridView loc_dgridv;
        private MetroFramework.Controls.MetroButton sort_btn;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton search_btn;
        private System.Windows.Forms.Panel locationview_panel;
        private MetroFramework.Controls.MetroTextBox edit_building_txt_box;
    }
}