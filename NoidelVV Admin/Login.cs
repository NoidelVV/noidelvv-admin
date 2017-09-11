using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace NoidelVV_Admin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            WebClient wbCl = new WebClient();
            string auth = wbCl.DownloadString("http://noidelvv.it/XXX.php?a=" + textBox1.Text);
            dynamic authJ = JsonConvert.DeserializeObject(auth);
            if (authJ.auth == true)
            {
                Main frmMain = new Main();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Errore! Password Errata!");
            }
            panel1.Visible = false;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

    public class WebLogin
    {
        public bool auth { get; set; }
        public string type { get; set; }
    }
}
