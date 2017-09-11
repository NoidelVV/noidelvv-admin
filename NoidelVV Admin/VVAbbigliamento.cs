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
    public partial class VVAbbigliamento : Form
    {
        public MySqlConnection DB;
        public MySqlCommand cmd;
        public MySqlDataReader reader;
        public VVAbbigliamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DBConnect(string db, string user, string psw)
        {
            string conn = "Server=OMISSIS;Database=" + db + ";Uid=" + user + ";Pwd=" + psw + ";";
            DB = new MySqlConnection(conn);
            cmd = DB.CreateCommand();
        }

        private void VVAbbigliamento_Load(object sender, EventArgs e)
        {
            vvabb_classes.Items.Clear();
            DBConnect("db", "utente", "password");
            cmd.CommandText = "SELECT * FROM classes ORDER BY class";
            DB.Open();
            reader = cmd.ExecuteReader();
            bool isFirst = true;
            while (reader.Read())
            {
                if (!isFirst)
                {
                    string payed = reader.GetValue(22).ToString() == "1" ? "(Pagato)" : "(Non Pagato)";
                    vvabb_classes.Items.Add(reader.GetValue(1)+" "+payed);
                }
                else
                {
                    isFirst = false;
                }
            }
            DB.Close();
        }

        private void vvabb_classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string cl = vvabb_classes.SelectedItem.ToString().Replace("(Pagato)", "").Replace("(Non Pagato)", "").Replace(" ", "");
                getClass(cl);
            }
            catch (Exception ex) { }
        }

        private void getClass(string cl)
        {
            int tot = 0;
            int glob_tot = 0;
            DBConnect("pzfdrieb_vvabbigliamento", "pzfdrieb_vvabb", "vvabb@noidelvv2014");
            cmd.CommandText = "SELECT * FROM classes WHERE class = '" + cl + "'";
            DB.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            //MessageBox.Show(cl);
            felpe_nere_xs.Text = reader.GetValue(4).ToString();
            l_felpe_nere_xs.Text = Convert.ToInt32(reader.GetValue(4)) * 15 + "€";
            tot += Convert.ToInt32(reader.GetValue(4)) * 15;
            felpe_nere_s.Text = reader.GetValue(8).ToString();
            l_felpe_nere_s.Text = Convert.ToInt32(reader.GetValue(8)) * 15 + "€";
            tot += Convert.ToInt32(reader.GetValue(8)) * 15;
            felpe_nere_m.Text = reader.GetValue(12).ToString();
            l_felpe_nere_m.Text = Convert.ToInt32(reader.GetValue(12)) * 15 + "€";
            tot += Convert.ToInt32(reader.GetValue(12)) * 15;
            felpe_nere_l.Text = reader.GetValue(16).ToString();
            l_felpe_nere_l.Text = Convert.ToInt32(reader.GetValue(16)) * 15 + "€";
            tot += Convert.ToInt32(reader.GetValue(16)) * 15;
            felpe_nere_xl.Text = reader.GetValue(20).ToString();
            l_felpe_nere_xl.Text = Convert.ToInt32(reader.GetValue(20)) * 15 + "€";
            tot += Convert.ToInt32(reader.GetValue(20)) * 15;
            felpe_nere_tot.Text = tot.ToString();
            glob_tot += tot;

            tot = 0;
            felpe_verdi_xs.Text = reader.GetValue(2).ToString();
            l_felpe_verdi_xs.Text = Convert.ToInt32(reader.GetValue(2)) * 15 + "€";
            tot += Convert.ToInt32(reader.GetValue(2)) * 15;
            felpe_verdi_s.Text = reader.GetValue(6).ToString();
            l_felpe_verdi_s.Text = Convert.ToInt32(reader.GetValue(6)) * 15 + "€";
            tot += Convert.ToInt32(reader.GetValue(6)) * 15;
            felpe_verdi_m.Text = reader.GetValue(10).ToString();
            l_felpe_verdi_m.Text = Convert.ToInt32(reader.GetValue(10)) * 15 + "€";
            tot += Convert.ToInt32(reader.GetValue(10)) * 15;
            felpe_verdi_l.Text = reader.GetValue(14).ToString();
            l_felpe_verdi_l.Text = Convert.ToInt32(reader.GetValue(14)) * 15 + "€";
            tot += Convert.ToInt32(reader.GetValue(14)) * 15;
            felpe_verdi_xl.Text = reader.GetValue(18).ToString();
            l_felpe_verdi_xl.Text = Convert.ToInt32(reader.GetValue(18)) * 15 + "€";
            tot += Convert.ToInt32(reader.GetValue(18)) * 15;
            felpe_verdi_tot.Text = tot.ToString();
            glob_tot += tot;

            tot = 0;
            maglie_nere_xs.Text = reader.GetValue(5).ToString();
            l_maglie_nere_xs.Text = Convert.ToInt32(reader.GetValue(5)) * 5 + "€";
            tot += Convert.ToInt32(reader.GetValue(5)) * 5;
            maglie_nere_s.Text = reader.GetValue(9).ToString();
            l_maglie_nere_s.Text = Convert.ToInt32(reader.GetValue(9)) * 5 + "€";
            tot += Convert.ToInt32(reader.GetValue(9)) * 5;
            maglie_nere_m.Text = reader.GetValue(13).ToString();
            l_maglie_nere_m.Text = Convert.ToInt32(reader.GetValue(13)) * 5 + "€";
            tot += Convert.ToInt32(reader.GetValue(13)) * 5;
            maglie_nere_l.Text = reader.GetValue(17).ToString();
            l_maglie_nere_l.Text = Convert.ToInt32(reader.GetValue(17)) * 5 + "€";
            tot += Convert.ToInt32(reader.GetValue(17)) * 5;
            maglie_nere_xl.Text = reader.GetValue(21).ToString();
            l_maglie_nere_xl.Text = Convert.ToInt32(reader.GetValue(21)) * 5 + "€";
            tot += Convert.ToInt32(reader.GetValue(21)) * 5;
            glob_tot += tot; maglie_nere_tot.Text = tot.ToString();

            tot = 0;
            maglie_verdi_xs.Text = reader.GetValue(3).ToString();
            l_maglie_verdi_xs.Text = Convert.ToInt32(reader.GetValue(3)) * 5 + "€";
            tot += Convert.ToInt32(reader.GetValue(3)) * 5;
            maglie_verdi_s.Text = reader.GetValue(7).ToString();
            l_maglie_verdi_s.Text = Convert.ToInt32(reader.GetValue(7)) * 5 + "€";
            tot += Convert.ToInt32(reader.GetValue(7)) * 5;
            maglie_verdi_m.Text = reader.GetValue(11).ToString();
            l_maglie_verdi_m.Text = Convert.ToInt32(reader.GetValue(11)) * 5 + "€";
            tot += Convert.ToInt32(reader.GetValue(11)) * 5;
            maglie_verdi_l.Text = reader.GetValue(15).ToString();
            l_maglie_verdi_l.Text = Convert.ToInt32(reader.GetValue(15)) * 5 + "€";
            tot += Convert.ToInt32(reader.GetValue(15)) * 5;
            maglie_verdi_xl.Text = reader.GetValue(19).ToString();
            l_maglie_verdi_xl.Text = Convert.ToInt32(reader.GetValue(19)) * 5 + "€";
            tot += Convert.ToInt32(reader.GetValue(19)) * 5;
            glob_tot += tot; maglie_verdi_tot.Text = tot.ToString();

            totale.Text = glob_tot.ToString() + "€";
            DB.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void felpe_nere_tot_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer5_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
