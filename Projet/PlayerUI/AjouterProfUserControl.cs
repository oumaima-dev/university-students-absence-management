using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace PlayerUI
{
    public partial class AjouterProfUserControl : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);

        String imageFileName = "";
        private void openDialog()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    CirclePictureBoxProf.Image = Image.FromFile(ofd.FileName);
                    
                    imageFileName = ofd.FileName;
                }
            }
        }
        public AjouterProfUserControl()
        {
            InitializeComponent();
        }

        private void gunaLineTextBox15_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxProfNom.Text != "")
            {
                TextBoxProfEmail.Text = TextBoxProfPrenom.Text.Replace(" ","").ToLower() + "." + TextBoxProfNom.Text.Replace(" ","").ToLower()+ "@uit.ac.ma";
            }
        }

        private void gunaLineTextBox16_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxProfPrenom.Text != "")
            {
                TextBoxProfEmail.Text = TextBoxProfPrenom.Text.Replace(" ", "").ToLower() + "." + TextBoxProfNom.Text.Replace(" ", "").ToLower() + "@uit.ac.ma";
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openDialog();
        }

        private void iconButtonCréerAdmin_Click(object sender, EventArgs e)
        {
            if (imageFileName != "")
            {
                DateTime daten,datea;
                daten =DateNaissanceProf .Value;
                datea=DateEmbaucheProf.Value;
                ajouterProf( TextBoxProfNom.Text, TextBoxProfPrenom.Text, daten.ToString("yyyy-MM-dd"), TextBoxProfEmail.Text, TextBoxProfTelephone.Text,TextBoxProfCin.Text, datea.ToString("yyyy-MM-dd"));
            }
            else
            {
                MessageBox.Show("VEUILLEZ CHOISIR UNE IMAGE");
            }
        }
        private bool checkInput(String Telephone, String email)
        {
            bool flag = false;
            
            if ( !int.TryParse(Telephone, out int z))
            {
                MessageBox.Show("Telephone doit etre en chiffres");
                flag = true;
            }
            if (flag == false && !RegexUtilities.IsValidEmail(email))
            {
                MessageBox.Show("EMAIL NON VALIDE , Ex : abcd@xyz.mn");
                flag = true;
            }

            return flag;
        }
        private Boolean checkExistence(String cin,String email, String telephone)
        {
            Boolean flag = false;
            SqlCommand cmd = new SqlCommand("select * from ETUDIANT", connection);
            SqlCommand cmd1 = new SqlCommand("select * from PROFESSEUR", connection);
            SqlCommand cmd2 = new SqlCommand("select * from ADMIN", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
           
           
            while (reader.Read())
            {
                if (cin == reader.GetString(1))
                {
                    MessageBox.Show("CIN EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    flag = true;
                    break;
                }
               
                if (flag == false && email == reader.GetString(6))
                {
                    MessageBox.Show("EMAIL EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                    break;
                }
                if (flag == false && telephone == reader.GetString(7))
                {
                    MessageBox.Show("TELEPHONE EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                    break;
                }
            }
            reader.Close();
            SqlDataReader reader1 = cmd1.ExecuteReader();

           
            while (reader1.Read())
            {
                if (cin == reader1.GetString(1))
                {
                    MessageBox.Show("CIN EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    flag = true;
                    break;
                }

                if (flag == false && email == reader1.GetString(5))
                {
                    MessageBox.Show("EMAIL EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                    break;
                }
                if (flag == false && telephone == reader1.GetString(6))
                {
                    MessageBox.Show("TELEPHONE EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                    break;
                }
            }
            reader1.Close();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                if (cin == reader2.GetString(1))
                {
                    MessageBox.Show("CIN EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    flag = true;
                    break;
                }

                if (flag == false && email == reader2.GetString(5))
                {
                    MessageBox.Show("EMAIL EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                    break;
                }
                if (flag == false && telephone == reader2.GetString(6))
                {
                    MessageBox.Show("TELEPHONE EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                    break;
                }
            }
            reader2.Close();
            connection.Close();
            return flag;
        }

        public void ajouterProf(String nom = "", String prenom = "", String dateNaissance = "", String email = "", String telephone = "", String cin = "", String dateEmbauche = "")
        {
            if (checkInput(telephone, email) == false && checkExistence(cin, email, telephone) == false && convertImage(imageFileName) != null)
            {
                byte[] tabling = convertImage(imageFileName);

                // try
                //{
                connection.Open();
                SqlCommand command1 = connection.CreateCommand();
                command1.CommandType = CommandType.Text;
                command1.CommandText = "insert into PROFESSEUR values ('" + cin + "','" + nom

                    + "','" + prenom + "','" + dateNaissance + "','" + email + "','" + telephone + "',@image ,'" + dateEmbauche + "',null)";

                command1.Parameters.Clear();
                command1.Parameters.Add(new SqlParameter("@image", tabling));

                command1.ExecuteNonQuery();
                MessageBox.Show("Vous avez ajouté avec succes");
                connection.Close();


                /*}
                catch
                {
                    MessageBox.Show("Veuillez Ressayer");
                }
                finally
                {
                    connection.Close();
                }*/


            }
        }
        private byte[] convertImage(String chemin)
        {
            CirclePictureBoxProf.Image.Dispose();
            byte[] tabling = null;
            FileStream fs = new FileStream(chemin, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            tabling = br.ReadBytes((int)fs.Length);
            fs.Close();
            return tabling;
        }
    }
}
