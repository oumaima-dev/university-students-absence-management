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
using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace PlayerUI
{
    public partial class etudiantUserControl : UserControl
    {
        public etudiantUserControl()
        {
            InitializeComponent();
            fill_filiere();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        private void iconButtonConsulter_Click(object sender, EventArgs e)
        {
        }

        private UserControl activeForm = null;
        private void openChildForm(UserControl childForm)
        {
            if (activeForm != null) activeForm.Hide();
            activeForm = childForm;
            //  childForm.Location()= false;
            // childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Bottom;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void iconButtonCréerEtudiant_Click(object sender, EventArgs e)
        {
            // openChildForm();
            //UserControl admin = new AjouterEtudiantUserControl();
            //openChildForm(admin);
            ///////////////////////////////
            
            if(loginbox.Text=="" || passbox.Text == "" || (gunaComboBox2.SelectedItem as dynamic).value==null)
                MessageBox.Show("Remplissez tout les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            int idu = (gunaComboBox2.SelectedItem as dynamic).value;
            ajoutercompte(idu, loginbox.Text.Trim(), passbox.Text.Trim());
            int idcmpt = getidcompte(loginbox.Text.Trim(), passbox.Text.Trim());
            updateuser(idu,idcmpt);
            loginbox.Text = "";
            passbox.Text = "";
            fill_filiere();
            
        }

        private void TextBoxEtudiantnom_TextChanged(object sender, EventArgs e)
        {

        }
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
        void fill_user(int idfil)
        {
            gunaComboBox2.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ETUDIANT where idFiliere="+idfil+" " +
                    "and idCompte is null", con);
                SqlDataReader reader = cmd.ExecuteReader();
                gunaComboBox2.DisplayMember = "Text";
                gunaComboBox2.ValueMember = "value";
                while (reader.Read())
                {
                    gunaComboBox2.Items.Add(new { Text = reader.GetString(3).Trim()+" "+ reader.GetString(4).Trim(), value = reader.GetInt32(0) });
                }

            }
        }

        // Generate a random password of a given length (optional)  
        private static string RandomPassword(int length = 8)
        {
            // Create a string of characters, numbers, special characters that allowed in the password  
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@";
            Random random = new Random();

            // Select one random character at a time from the string  
            // and create an array of chars  
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
        int getidcompte(string login ,string pass)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from COMPTE where login='"+login+"'  and password='"+pass+"'", con);
                SqlDataReader rd = cmd.ExecuteReader();rd.Read();
                return rd.GetInt32(0);
            }
        }
        void updateuser(int idu,int idcmpt)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" update ETUDIANT set idCompte=" + idcmpt + " where idEtudiant=" + idu + " ", con);
                cmd.ExecuteNonQuery();
                
            }

        }
        void ajoutercompte(int idu,string login,string pass)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into COMPTE values('" + login + "','" + pass + "','ETUDIANT')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vous avez associé un compte à l'etudiant "+gunaComboBox2.Text, "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("L'envoie des informations de compte .....");
                    sendmail(login, "Votre login pour se connecter est l'adresse email universitaire " + login + " et votre mot de pass est " + pass + " vous pouvez le changer dès votre premier accés");
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show("Erreur:"+ exe.Message, "Veuillez réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


         }
        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iduser=(gunaComboBox2.SelectedItem as dynamic).value;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ETUDIANT where idEtudiant=" +iduser  + "", con);
                SqlDataReader reader = cmd.ExecuteReader();reader.Read();
                loginbox.Text = reader.GetString(6);
                passbox.Text=RandomPassword(8);
            }
        }

        private void gunaComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loginbox.Text = "";
            passbox.Text = "";
            fill_user( (gunaComboBox1.SelectedItem as dynamic).value);

        }

        private void iconButtonCréerAdmin_Click(object sender, EventArgs e)
        {
            // openChildForm();
            UserControl etd = new AjouterEtudiantUserControl();
            openChildForm(etd);
            
        }
        void sendmail(string to, string body)
        {
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {

                client.Credentials = new NetworkCredential("gestionabsenceapp@gmail.com", "absenceapp2020");
                client.EnableSsl = true;
                MailMessage msg = new MailMessage("noreply@gmail.com", to, "LES INFORMATIONS DE VOTRE COMPTE ", body);
                msg.IsBodyHtml = false;
                client.Send(msg);
                MessageBox.Show("Mail envoyé ","à"+to);
            }
        }
    }
}
