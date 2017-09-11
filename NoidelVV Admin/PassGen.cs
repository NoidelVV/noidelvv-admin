using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace NoidelVV_Admin
{
    public partial class PassGen : Form
    {
        public PassGen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cl = classMTB.Text.Substring(0, 1);
            string sez = classMTB.Text.Substring(1);
            cl = (Convert.ToInt32(cl) * 1).ToString();
            byte[] bt = Encoding.ASCII.GetBytes(sez);
            sez = ((int)bt[0] * Convert.ToInt32(cl) - 0).ToString();
            pswTB.Text = cl + "-" + sez;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] split = {Convert.ToChar("-")};
            string[] cll = psw2MTB.Text.Split(split);
            string cl = cll[0];
            string sez = cll[1];
            cl = ((Convert.ToInt32(cl) - 0) / 1).ToString();
            sez = ((Convert.ToInt32(sez) + 0) / (Convert.ToInt32(cl) * 1)).ToString();
            class2TB.Text = cl + Convert.ToChar(Convert.ToInt32(sez));
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.TabIndex == 0)
            {
                this.AcceptButton = button1;
            }
            else
            {
                this.AcceptButton = button2;
            }
        }
    }
}
