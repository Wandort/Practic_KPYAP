﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.IsMdiContainer = true;
			spData.Text =
			Convert.ToString(System.DateTime.Today.ToLongDateString());
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			int openDocuments = 0;
			switch (e.ClickedItem.Tag.ToString())
			{
				case "NewDoc":
					ChildForm newChild = new ChildForm();
					newChild.MdiParent = this;
					newChild.Show();
					newChild.Text = newChild.Text + " " +
					++openDocuments;
					break;
				case "Cascade":
					this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
					break;
				case "Title":
					this.LayoutMdi
					(System.Windows.Forms.MdiLayout.TileHorizontal);
					break;
			}
		}

		private void spWin_Click(object sender, EventArgs e)
		{
			spWin.Text = "Windows is cascade";
		}

		private void spData_Click(object sender, EventArgs e)
		{
			spWin.Text = "Windows is horizontal";
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
