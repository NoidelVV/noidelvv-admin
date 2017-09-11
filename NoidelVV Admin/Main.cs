using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NoidelVV_Admin
{
    public partial class Main : Form
    {
        public MySqlConnection DB;
        public MySqlCommand cmd;
        public MySqlDataReader reader;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void vVFotoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VVFoto foto = new VVFoto();
            foto.MdiParent = this;
            foto.Show();
        }

        private void generatorePasswordClassiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassGen pswGen = new PassGen();
            pswGen.MdiParent = this;
            pswGen.Show();
        }

        private void vVAbbigliamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VVAbbigliamento vvabb = new VVAbbigliamento();
            vvabb.MdiParent = this;
            vvabb.Show();
        }

        private void generateDOCXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Password psw = new Password();
            psw.MdiParent = this;
            psw.Show();
        }

        private void certificatiCreditiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenCrediti cr = new GenCrediti();
            cr.MdiParent = this;
            cr.Show();
        }
    }
}
