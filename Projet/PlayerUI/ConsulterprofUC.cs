using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace PlayerUI
{
    public partial class ConsulterprofUC : UserControl
    {
        public ConsulterprofUC()
        {
            InitializeComponent();
            fill_filiere();
            fill_allprofil();

        }

        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        public void fill_filiere()
        {
            gunaComboBox1.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from FILIERE", con);
                SqlDataReader reader = cmd.ExecuteReader();
                gunaComboBox1.DisplayMember = "Text";
                gunaComboBox1.ValueMember = "value";
                while (reader.Read())
                {

                    gunaComboBox1.Items.Add(new { Text = reader.GetString(1), value = reader.GetInt32(0) });

                }

            }
        }

        public void fill_profil_filiere(int idfiliere, string cin = "")
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                layoutpanel.Controls.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT distinct PROFESSEUR.idProfesseur,PROFESSEUR.image,PROFESSEUR.nom,PROFESSEUR.prenom " +
                    "                           from PROFESSEUR,AFFECTATION,MODULE,MODULELISTE " +
                    "                           WHERE PROFESSEUR.idProfesseur=AFFECTATION.idProfesseur " +
                    "                           AND AFFECTATION.module=MODULE.idModule" +
                    "                           AND MODULE.idModule=MODULELISTE.idModule " +
                    "                           AND MODULELISTE.idFiliere=" + idfiliere + " AND cin LIKE '%" + cin + "%'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    byte[] output = (byte[])reader[1];///8
                    using (MemoryStream ms = new MemoryStream(output))
                    {
                        Bitmap img = new Bitmap(ms);//4 3 0
                        ProfilPUC uc = new ProfilPUC(reader.GetString(3).Trim() + " " + reader.GetString(2).Trim(), "Professeur", img, reader.GetInt32(0));

                        layoutpanel.Controls.Add(uc);
                    }

                }

            }

        }
        public void fill_profil(string cin = "")
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                layoutpanel.Controls.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from PROFESSEUR WHERE  cin LIKE '%" + cin + "%' ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    byte[] output = (byte[])reader[7];
                    using (MemoryStream ms = new MemoryStream(output))
                    {
                        Bitmap img = new Bitmap(ms);
                        ProfilPUC uc = new ProfilPUC(reader.GetString(3).Trim() + " " + reader.GetString(2).Trim(), "Professeur", img, reader.GetInt32(0));

                        layoutpanel.Controls.Add(uc);
                    }

                }

            }
        }


        public void fill_allprofil()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                layoutpanel.Controls.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from PROFESSEUR", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    byte[] output = (byte[])reader[7];
                    using (MemoryStream ms = new MemoryStream(output))
                    {
                        Bitmap img = new Bitmap(ms);
                        ProfilPUC uc = new ProfilPUC(reader.GetString(3).Trim() + " " + reader.GetString(2).Trim(), "Professeur", img, reader.GetInt32(0));
                        uc.Size = new System.Drawing.Size(640, 38);
                        layoutpanel.Controls.Add(uc);
                    }

                }

            }
        }
        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConsulterprofUC_Load(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (gunaComboBox1.Text.Equals(""))
                MessageBox.Show("Avant de rechercher veuillez selectionner une filiere");
            if (gunaLineTextBox1.Text.Trim() != "CNE")
                fill_profil(gunaLineTextBox1.Text);
            else MessageBox.Show("Entrer un code CNE ...");
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idf = (gunaComboBox1.SelectedItem as dynamic).value;
            fill_profil_filiere(idf);
        }
    }
}
