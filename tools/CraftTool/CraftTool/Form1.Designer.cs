﻿namespace CraftTool
{
	partial class Form1
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.TB_loadoutput = new System.Windows.Forms.TextBox();
			this.BTN_load_info = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.itemdesc_picture = new System.Windows.Forms.PictureBox();
			this.TB_itemdescinfo = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.itemdesc_datagrid = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.materials_picture = new System.Windows.Forms.PictureBox();
			this.materials_textbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.materials_tree_view = new System.Windows.Forms.TreeView();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.toolonmaterial_picture = new System.Windows.Forms.PictureBox();
			this.TB_toolonmaterial = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.toolonmaterial_treeview = new System.Windows.Forms.TreeView();
			this.menuStrip1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemdesc_picture)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemdesc_datagrid)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.materials_picture)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.toolonmaterial_picture)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 601);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1012, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.settingsToolStripMenuItem.Text = "&Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// TabControl1
			// 
			this.TabControl1.Controls.Add(this.tabPage1);
			this.TabControl1.Controls.Add(this.tabPage2);
			this.TabControl1.Controls.Add(this.tabPage3);
			this.TabControl1.Controls.Add(this.tabPage4);
			this.TabControl1.Controls.Add(this.tabPage5);
			this.TabControl1.Controls.Add(this.tabPage6);
			this.TabControl1.Controls.Add(this.tabPage7);
			this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl1.Location = new System.Drawing.Point(0, 24);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(1012, 577);
			this.TabControl1.TabIndex = 2;
			this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
			this.tabPage1.Controls.Add(this.TB_loadoutput);
			this.tabPage1.Controls.Add(this.BTN_load_info);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1004, 551);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Load Information";
			// 
			// TB_loadoutput
			// 
			this.TB_loadoutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
					  | System.Windows.Forms.AnchorStyles.Left)
					  | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_loadoutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
			this.TB_loadoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TB_loadoutput.Location = new System.Drawing.Point(9, 7);
			this.TB_loadoutput.Multiline = true;
			this.TB_loadoutput.Name = "TB_loadoutput";
			this.TB_loadoutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TB_loadoutput.Size = new System.Drawing.Size(987, 508);
			this.TB_loadoutput.TabIndex = 2;
			// 
			// BTN_load_info
			// 
			this.BTN_load_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BTN_load_info.Location = new System.Drawing.Point(9, 521);
			this.BTN_load_info.Name = "BTN_load_info";
			this.BTN_load_info.Size = new System.Drawing.Size(111, 23);
			this.BTN_load_info.TabIndex = 0;
			this.BTN_load_info.Text = "Load Information";
			this.BTN_load_info.UseVisualStyleBackColor = true;
			this.BTN_load_info.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1004, 551);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Itemdesc";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
					  | System.Windows.Forms.AnchorStyles.Left)
					  | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.itemdesc_picture);
			this.groupBox2.Controls.Add(this.TB_itemdescinfo);
			this.groupBox2.Location = new System.Drawing.Point(297, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(699, 539);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ItemDesc Info";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "label4";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(586, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tile Picture";
			// 
			// itemdesc_picture
			// 
			this.itemdesc_picture.BackColor = System.Drawing.Color.Black;
			this.itemdesc_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemdesc_picture.InitialImage = global::CraftTool.Properties.Resources.unused;
			this.itemdesc_picture.Location = new System.Drawing.Point(534, 48);
			this.itemdesc_picture.MaximumSize = new System.Drawing.Size(159, 151);
			this.itemdesc_picture.MinimumSize = new System.Drawing.Size(159, 151);
			this.itemdesc_picture.Name = "itemdesc_picture";
			this.itemdesc_picture.Size = new System.Drawing.Size(159, 151);
			this.itemdesc_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.itemdesc_picture.TabIndex = 1;
			this.itemdesc_picture.TabStop = false;
			// 
			// TB_itemdescinfo
			// 
			this.TB_itemdescinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
					  | System.Windows.Forms.AnchorStyles.Left)
					  | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_itemdescinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
			this.TB_itemdescinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TB_itemdescinfo.Location = new System.Drawing.Point(6, 48);
			this.TB_itemdescinfo.Multiline = true;
			this.TB_itemdescinfo.Name = "TB_itemdescinfo";
			this.TB_itemdescinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TB_itemdescinfo.Size = new System.Drawing.Size(525, 483);
			this.TB_itemdescinfo.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
					  | System.Windows.Forms.AnchorStyles.Left)
					  | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.itemdesc_datagrid);
			this.groupBox1.Location = new System.Drawing.Point(9, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(282, 539);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Itemdesc Entries";
			// 
			// itemdesc_datagrid
			// 
			this.itemdesc_datagrid.AllowUserToAddRows = false;
			this.itemdesc_datagrid.AllowUserToDeleteRows = false;
			this.itemdesc_datagrid.AllowUserToOrderColumns = true;
			this.itemdesc_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
					  | System.Windows.Forms.AnchorStyles.Left)
					  | System.Windows.Forms.AnchorStyles.Right)));
			this.itemdesc_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.itemdesc_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
			this.itemdesc_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.itemdesc_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.itemdesc_datagrid.DefaultCellStyle = dataGridViewCellStyle1;
			this.itemdesc_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.itemdesc_datagrid.Location = new System.Drawing.Point(6, 19);
			this.itemdesc_datagrid.MaximumSize = new System.Drawing.Size(270, 512);
			this.itemdesc_datagrid.MinimumSize = new System.Drawing.Size(270, 512);
			this.itemdesc_datagrid.MultiSelect = false;
			this.itemdesc_datagrid.Name = "itemdesc_datagrid";
			this.itemdesc_datagrid.ReadOnly = true;
			this.itemdesc_datagrid.RowHeadersVisible = false;
			this.itemdesc_datagrid.RowHeadersWidth = 25;
			this.itemdesc_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.itemdesc_datagrid.RowTemplate.Height = 20;
			this.itemdesc_datagrid.RowTemplate.ReadOnly = true;
			this.itemdesc_datagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.itemdesc_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.itemdesc_datagrid.Size = new System.Drawing.Size(270, 512);
			this.itemdesc_datagrid.TabIndex = 5;
			this.itemdesc_datagrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemdesc_datagrid_RowEnter);
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column1.HeaderText = "Picture";
			this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Column1.MinimumWidth = 55;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.Width = 55;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "ObjType";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Item Name";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
			this.tabPage3.Controls.Add(this.groupBox3);
			this.tabPage3.Controls.Add(this.label2);
			this.tabPage3.Controls.Add(this.materials_tree_view);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1004, 551);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Materials";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.materials_picture);
			this.groupBox3.Controls.Add(this.materials_textbox);
			this.groupBox3.Location = new System.Drawing.Point(336, 9);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(660, 539);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Materials Info";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(545, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tile Picture";
			// 
			// materials_picture
			// 
			this.materials_picture.BackColor = System.Drawing.Color.Black;
			this.materials_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.materials_picture.Location = new System.Drawing.Point(495, 37);
			this.materials_picture.Name = "materials_picture";
			this.materials_picture.Size = new System.Drawing.Size(159, 151);
			this.materials_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.materials_picture.TabIndex = 1;
			this.materials_picture.TabStop = false;
			// 
			// materials_textbox
			// 
			this.materials_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
			this.materials_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.materials_textbox.Location = new System.Drawing.Point(6, 37);
			this.materials_textbox.Multiline = true;
			this.materials_textbox.Name = "materials_textbox";
			this.materials_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.materials_textbox.Size = new System.Drawing.Size(483, 496);
			this.materials_textbox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Materials";
			// 
			// materials_tree_view
			// 
			this.materials_tree_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
			this.materials_tree_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.materials_tree_view.HotTracking = true;
			this.materials_tree_view.Location = new System.Drawing.Point(8, 25);
			this.materials_tree_view.Name = "materials_tree_view";
			this.materials_tree_view.Size = new System.Drawing.Size(322, 516);
			this.materials_tree_view.TabIndex = 0;
			this.materials_tree_view.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.materials_tree_view_AfterSelect);
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
			this.tabPage4.Controls.Add(this.groupBox4);
			this.tabPage4.Controls.Add(this.label8);
			this.tabPage4.Controls.Add(this.toolonmaterial_treeview);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(1004, 551);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "ToolOnMaterial";
			// 
			// tabPage5
			// 
			this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(1004, 551);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "CraftMenus";
			// 
			// tabPage6
			// 
			this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(1004, 551);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "CraftItems";
			// 
			// tabPage7
			// 
			this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Size = new System.Drawing.Size(1004, 551);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "Craft Tree";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "label5";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.toolonmaterial_picture);
			this.groupBox4.Controls.Add(this.TB_toolonmaterial);
			this.groupBox4.Location = new System.Drawing.Point(336, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(660, 539);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Materials Info";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(545, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Tool Picture";
			// 
			// toolonmaterial_picture
			// 
			this.toolonmaterial_picture.BackColor = System.Drawing.Color.Black;
			this.toolonmaterial_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolonmaterial_picture.Location = new System.Drawing.Point(495, 37);
			this.toolonmaterial_picture.Name = "toolonmaterial_picture";
			this.toolonmaterial_picture.Size = new System.Drawing.Size(159, 151);
			this.toolonmaterial_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.toolonmaterial_picture.TabIndex = 1;
			this.toolonmaterial_picture.TabStop = false;
			// 
			// TB_toolonmaterial
			// 
			this.TB_toolonmaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
			this.TB_toolonmaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TB_toolonmaterial.Location = new System.Drawing.Point(6, 37);
			this.TB_toolonmaterial.Multiline = true;
			this.TB_toolonmaterial.Name = "TB_toolonmaterial";
			this.TB_toolonmaterial.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TB_toolonmaterial.Size = new System.Drawing.Size(483, 496);
			this.TB_toolonmaterial.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 6);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Elem Names";
			// 
			// toolonmaterial_treeview
			// 
			this.toolonmaterial_treeview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
			this.toolonmaterial_treeview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolonmaterial_treeview.HotTracking = true;
			this.toolonmaterial_treeview.Location = new System.Drawing.Point(8, 22);
			this.toolonmaterial_treeview.Name = "toolonmaterial_treeview";
			this.toolonmaterial_treeview.Size = new System.Drawing.Size(322, 516);
			this.toolonmaterial_treeview.TabIndex = 3;
			this.toolonmaterial_treeview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.toolonmaterial_treeview_AfterSelect);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
			this.ClientSize = new System.Drawing.Size(1012, 623);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Craft Tool";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.TabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemdesc_picture)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.itemdesc_datagrid)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.materials_picture)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.toolonmaterial_picture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TabControl TabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.TextBox TB_loadoutput;
		private System.Windows.Forms.Button BTN_load_info;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox TB_itemdescinfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox itemdesc_picture;
		private System.Windows.Forms.TreeView materials_tree_view;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox materials_picture;
		private System.Windows.Forms.TextBox materials_textbox;
		private System.Windows.Forms.DataGridView itemdesc_datagrid;
		private System.Windows.Forms.DataGridViewImageColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox toolonmaterial_picture;
		private System.Windows.Forms.TextBox TB_toolonmaterial;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TreeView toolonmaterial_treeview;
	}
}
