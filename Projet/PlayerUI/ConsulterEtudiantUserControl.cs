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
    public partial class ConsulterEtudiantUserControl : UserControl
    {
        public ConsulterEtudiantUserControl()
        {
            InitializeComponent();
            fill_filiere();
            fill_allprofil();

        }



        private void toolStripMenuItemSupp_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ConsulterEtudiantUserControl_Load(object sender, EventArgs e)
        {

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
        public void fill_profil(int idfiliere ,string cne = "")
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                layoutpanel.Controls.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ETUDIANT,FILIERE WHERE ETUDIANT.idFiliere=FILIERE.idFiliere " +
                    "                       AND ETUDIANT.idFiliere="+idfiliere+" AND cne LIKE '%"+cne+"%'", con);
                SqlDataReader reader = cmd.ExecuteReader();
               
                while (reader.Read())
                {
                    byte[] output = (byte[])reader[8];
                    using(MemoryStream ms=new MemoryStream(output))
                    {
                        Bitmap img = new Bitmap(ms); 
                        ProfilUC uc = new ProfilUC(reader.GetString(4).Trim() + " " + reader.GetString(3).Trim(), reader.GetString(12),img,reader.GetInt32(0) );

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
                SqlCommand cmd = new SqlCommand("select * from ETUDIANT,FILIERE WHERE ETUDIANT.idFiliere=FILIERE.idFiliere", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Bitmap img = null;
                    if (!reader.IsDBNull(8))
                    {
                      
                        byte[] output = (byte[])reader[8];
                        using (MemoryStream ms = new MemoryStream(output))
                        {
                            img = new Bitmap(ms);
                            
                        }
                    }
                    ProfilUC uc = new ProfilUC(reader.GetString(4).Trim() + " " + reader.GetString(3).Trim(), reader.GetString(12), img, reader.GetInt32(0));
                    uc.Size = new System.Drawing.Size(640, 38);
                    layoutpanel.Controls.Add(uc);

                }

            }
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {if (gunaComboBox1.SelectedItem == null)
                MessageBox.Show("Avant de rechercher veuillez selectionner une filiere");
            else
            {
                if (gunaLineTextBox1.Text.Trim() != "CNE")
                {
                    fill_profil((gunaComboBox1.SelectedItem as dynamic).value, gunaLineTextBox1.Text);
                }
                else { MessageBox.Show("Entrer un code CNE ..."); }
            }
        }
        void fill_profil_filiere(int idf)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                layoutpanel.Controls.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ETUDIANT,FILIERE WHERE ETUDIANT.idFiliere=FILIERE.idFiliere " +
                    "                       AND ETUDIANT.idFiliere=" + idf + " ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Bitmap img = null;
                    if (!reader.IsDBNull(8))
                    {
                        byte[] output = (byte[])reader[8];

                        using (MemoryStream ms = new MemoryStream(output))
                        {
                             img = new Bitmap(ms);
                           
                        }
                    }
                    ProfilUC uc = new ProfilUC(reader.GetString(4).Trim() + " " + reader.GetString(3).Trim(), reader.GetString(12), img, reader.GetInt32(0));
                    uc.Size = new System.Drawing.Size(640, 55);
                    layoutpanel.Controls.Add(uc);

                }

            }
        }
        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           int idf= (gunaComboBox1.SelectedItem as dynamic).value;
            fill_profil_filiere(idf);
        }

        private void iconButtonCréerAdmin_Click(object sender, EventArgs e)
        {
            ImportEtudiantByFiliere import = new ImportEtudiantByFiliere();
            import.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            ExporterEtudiantForm export= new ExporterEtudiantForm();
            export.ShowDialog();
        }
    }
}
