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
    public partial class AjouterEtudiantUserControl : UserControl
    {

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
        public AjouterEtudiantUserControl()
        {
            InitializeComponent();
            fill_filiere();
        }
        private bool checkInput(String Telephone,String email ,int idFiliere = -1)
        {
            bool flag = false;
            if (idFiliere == -1)
            {
                MessageBox.Show("VEUILLEZ CHOISIR UNE FILIIERE");
                flag = true;
            }
            if (flag == false && !int.TryParse(Telephone, out int z))
            {
                MessageBox.Show("Telephone doit etre en chiffres");
                flag = true;
            }
            if(flag == false && !RegexUtilities.IsValidEmail(email))
            {
                MessageBox.Show("EMAIL NON VALIDE , Ex : abcd@xyz.mn" );
                flag = true;
            }

            return flag;
        }
        public void ajouterEtudiant(int idFiliere, String nom = "", String prenom = "", String dateNaissance = "", String email = "", String telephone = "", String cin = "", String cne = "")
        {
            if (checkInput(telephone,email,idFiliere) == false && checkExistence(cin,cne,email,telephone)==false &&checkExistenceProfAdmin(cin,email,telephone)==false && convertImage(imageFileName) != null ) 
            {

                byte[] tabling = convertImage(imageFileName);
                try
                {
                connection.Open();
                    SqlCommand command1 = connection.CreateCommand();
                    command1.CommandType = CommandType.Text;
                command1.CommandText = "insert into ETUDIANT values ('" + cin + "','" + cne + "','" + nom

                    + "','" + prenom + "','" + dateNaissance + "','" + email + "','" + telephone + "', @image ,NULL,'" + idFiliere + "')";


                    command1.Parameters.Clear();
                    command1.Parameters.Add(new SqlParameter("@image", tabling));
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Vous avez ajouté un étudiant avec succes");
                    
                    viderChamps();
                    connection.Close();
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message,"Veuillez Ressayer",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
                }
                finally
                {
                    connection.Close();
                }
            }

        }
        public void viderChamps()
        {
            TextBoxEtudiantCin.Text = "";
            TextBoxEtudiantCne.Text = "";
            TextBoxEtudiantnom.Text = "";
            TextBoxEtudiantprenom.Text = "";
            TextBoxEtudiantEmail.Text = "";
            TextBoxEtudiantTelephone.Text = "";
            
            ComboBoxFiliere.Items.Clear();
            CirclePictureBoxEtudiant.Image.Dispose();

        }
        private void gunaLineTextBox14_TextChanged(object sender, EventArgs e)
        {

        }
        public void fill_filiere()
        {
            ComboBoxFiliere.Items.Clear();
           
            
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from FILIERE", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                ComboBoxFiliere.DisplayMember = "Text";
                ComboBoxFiliere.ValueMember = "value";
                while (reader.Read())
                {

                    ComboBoxFiliere.Items.Add(new { Text = reader.GetString(1), value = reader.GetInt32(0) });

                }
            connection.Close();

            
        }
        private Boolean checkExistence(String cin, String cne, String email, String telephone)
        {
            Boolean flag = false;
            SqlCommand cmd = new SqlCommand("select * from ETUDIANT", connection);
            
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
                if (flag==false && cne == reader.GetString(2))
                {
                    MessageBox.Show("CNE EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                    break;
                }
                if (flag==false && email == reader.GetString(6))
                {
                    MessageBox.Show("EMAIL EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                    break;
                }
                if (flag==false && telephone == reader.GetString(7))
                {
                    MessageBox.Show("TELEPHONE EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                    break;
                }
            }
            connection.Close();
            return flag;
        }
        private Boolean checkExistenceProfAdmin(String cin,String email, String telephone)
        {
            Boolean flag = false;
            SqlCommand cmd = new SqlCommand("select * from PROFESSEUR", connection);
            
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
               
                if (flag == false && email == reader.GetString(5))
                {
                    MessageBox.Show("EMAIL EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                    break;
                }
                if (flag == false && telephone == reader.GetString(6))
                {
                    MessageBox.Show("TELEPHONE EXISTANT", "Erreur lors de l'insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                    break;
                }
            }
            reader.Close();
            SqlCommand cmd1 = new SqlCommand("select * from ADMIN", connection);
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
            connection.Close();
            return flag;
        }
        private void gunaLineTextBox15_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxEtudiantnom.Text != "")
            {
                TextBoxEtudiantEmail.Text = TextBoxEtudiantprenom.Text.Replace(" ","").ToLower() + "." + TextBoxEtudiantnom.Text.Replace(" ","").ToLower() + "@uit.ac.ma";
            }
        }

        private void gunaLineTextBox16_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxEtudiantprenom.Text != "")
            {
                TextBoxEtudiantEmail.Text = TextBoxEtudiantprenom.Text.Replace(" ", "").ToLower() + "." + TextBoxEtudiantnom.Text.Replace(" ", "").ToLower() + "@uit.ac.ma";
            }
        }
        String imageFileName = "";
        private void openDialog()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg" })
            {
               
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                      CirclePictureBoxEtudiant.Image = Image.FromFile(ofd.FileName);
                       imageFileName = ofd.FileName;          
                }
            }
        }
      
        private void iconButton1_Click(object sender, EventArgs e)
        {
            openDialog();
        }

        private void iconButtonCréerAdmin_Click(object sender, EventArgs e)
        {
            if (imageFileName != "") {
                DateTime date;
                date = DateNaissanceEtudiant.Value;
                date.ToString("yyyy-MM-dd");
                ajouterEtudiant((ComboBoxFiliere.SelectedItem as dynamic).value, TextBoxEtudiantnom.Text, TextBoxEtudiantprenom.Text, date.ToString("yyyy-MM-dd"), TextBoxEtudiantEmail.Text, TextBoxEtudiantTelephone.Text, TextBoxEtudiantCin.Text, TextBoxEtudiantCne.Text);

            }
            else
            {
                MessageBox.Show("VEUILLEZ CHOISIR UNE IMAGE");
            }
        }
        private byte[] convertImage(String chemin)
        {
            CirclePictureBoxEtudiant.Image.Dispose();
            byte[] tabling = null;
            try
            {
                
                FileStream fs = new FileStream(chemin, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                tabling = br.ReadBytes((int)fs.Length);
                fs.Close();
                return tabling;
            }
            catch
            {
                MessageBox.Show("OUVERTURE DE FICHIER ECHOUÉE");
                return tabling;
            }
            
        }

        private void AjouterEtudiantUserControl_Load(object sender, EventArgs e)
        {

        }
    }
   
}
