﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anh_Coffee.View
{
    public partial class Table : UserControl
    {
        private string status = "Trống";
        public Table(int id, string text, string status, EventHandler table_Click)
        {
            InitializeComponent();
            this.btnTable.Tag = id;
            this.btnTable.Text = text;
            UpdateStatus(status);
            this.btnTable.Click += table_Click;
        }

        public void UpdateStatus(string status)
        {
            this.status = status;
            string s = "";
            switch (status)
            {
                case "Có người": s = "table"; break;
                case "Trống": s = "tableEmpty"; break;
                default: break;
            }

            this.btnTable.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "Resources/" + s + ".png");
        }

        public string GetStatus() { return status; }

    }
}
