﻿using System;
using System.Windows.Forms;
using System.IO;

namespace CraftTool.Forms.SettingsForm
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			TB_pol_path.Text = Settings.Global.rootdir;
		}

		private void BTN_apply_Click(object sender, EventArgs e)
		{
			Settings.Global.rootdir = TB_pol_path.Text;
		}

		private void BTN_ok_Click(object sender, EventArgs e)
		{
			BTN_apply_Click(sender, e);
			this.Close();
		}

		private void BTN_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BTN_pol_path_browse_Click(object sender, EventArgs e)
		{
			string folder = FilePicker.FilePicker.SelectFolder();
			if (Directory.Exists(folder))
				this.TB_pol_path.Text = folder;
		}
	}
}
