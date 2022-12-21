using System;
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
        public Table(string text, string status)
        {
            InitializeComponent();
            this.btnTable.Text = text;
            string s = "";
            switch (status)
            {
                case "Có người": s = "table"; break;
                case "Trống": s = "tableEmpty"; break;
                default: break;
            }

            this.btnTable.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "Resources/" + s + ".png");
        }
    }
}
