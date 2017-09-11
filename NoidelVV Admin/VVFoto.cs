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
    public partial class VVFoto : Form
    {
        public MySqlConnection DB;
        public MySqlCommand cmd;
        public MySqlDataReader reader;
        public VVFoto()
        {
            InitializeComponent();
        }

        private void vvfoto_classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPHClass(vvfoto_classes.SelectedItem.ToString());
        }

        private void VVFoto_Load(object sender, EventArgs e)
        {
            vvfoto_classes.Items.Clear();
            DBConnect("pzfdrieb_foto", "pzfdrieb_foto", "foto@studenti2014");
            cmd.CommandText = "SELECT * FROM classes";
            DB.Open();
            reader = cmd.ExecuteReader();
            bool isFirst = true;
            while (reader.Read())
            {
                if (!isFirst)
                    vvfoto_classes.Items.Add(reader.GetValue(1)); isFirst = false;
            }
            DB.Close();
        }

        private void DBConnect(string db, string user, string psw)
        {
            string conn = "Server=46.252.150.79;Database=" + db + ";Uid=" + user + ";Pwd=" + psw + ";";
            DB = new MySqlConnection(conn);
            cmd = DB.CreateCommand();
        }

        private void GetPHClass(string cl)
        {
            DBConnect("pzfdrieb_foto", "pzfdrieb_foto", "foto@studenti2014");
            cmd.CommandText = "SELECT * FROM classes WHERE class = '" + cl + "'";
            DB.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            n_fotoBig.Text = reader.GetValue(2).ToString().Replace("\n", Environment.NewLine);
            n_fotoSmall.Text = reader.GetValue(3).ToString().Replace("\n", Environment.NewLine);
            n_annuari.Text = reader.GetValue(4).ToString();
            if (reader.GetValue(5).ToString() == "1")
            {
                payed.ForeColor = Color.Green;
                payed.Text = "Pagato";
            }
            else
            {
                payed.ForeColor = Color.Red;
                payed.Text = "Non Pagato";
            }
            DB.Close();
        }

        private void VVFoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DB != null) DB.Close();
        }

        private void vvfotoPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Classe " + vvfoto_classes.SelectedItem.ToString().ToUpper() + Environment.NewLine + Environment.NewLine +
               "Foto 15x22" + Environment.NewLine + n_fotoSmall.Text + Environment.NewLine +
               "Foto 20x30" + Environment.NewLine + n_fotoBig.Text + Environment.NewLine +
               "Annuari: " + n_annuari.Text + Environment.NewLine + Environment.NewLine +
               (payed.Text == "Pagato" ? "PAGATO" : "NON PAGATO"),
  new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 150, 125);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog prntDlg = new PrintDialog();
            prntDlg.ShowDialog();
            vvfotoPrint.PrinterSettings = prntDlg.PrinterSettings;
            vvfotoPrint.Print();
        }

        private void vvfoto_classes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                GetPHClass(vvfoto_classes.SelectedItem.ToString());
            }
            catch (Exception ex) { }
        }
    }
}
