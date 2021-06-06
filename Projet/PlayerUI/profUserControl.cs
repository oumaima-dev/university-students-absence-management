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
    public partial class profUserControl : UserControl
    {
        public profUserControl()
        {
            InitializeComponent();
            fill_user();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

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
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (loginbox.Text == "" || passbox.Text == "" || (gunaComboBox2.SelectedItem as dynamic).value == null)
            {                MessageBox.Show("Remplissez tout les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            int idu = (gunaComboBox2.SelectedItem as dynamic).value;
            ajoutercompte(idu, loginbox.Text.Trim(), passbox.Text.Trim());
            int idcmpt = getidcompte(loginbox.Text.Trim(), passbox.Text.Trim());
            updateuser(idu, idcmpt);
            loginbox.Text = "";
            passbox.Text = "";
            fill_user();
        }
        void fill_user()
        {
            
                gunaComboBox2.Items.Clear();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from PROFESSEUR WHERE idCompte is null ", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    gunaComboBox2.DisplayMember = "Text";
                    gunaComboBox2.ValueMember = "value";
                    while (reader.Read())
                    {
                        gunaComboBox2.Items.Add(new { Text = reader.GetString(2).Trim() + " " + reader.GetString(3).Trim(), value = reader.GetInt32(0) });
                    }

                }
        }
        // Generate a random password of a given length (optional)  
        private static string RandomPassword(int length = 15)
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
        void ajoutercompte(int idu, string login, string pass)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into COMPTE values('" + login + "','" + pass + "','PROFESSEUR')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vous avez associé un compte au professur  " + gunaComboBox2.Text, "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("L'envoie des informations de compte .....");
                    try
                    {
                        sendmail(login, "Votre login pour se connecter est l'adresse email universitaire " + login + " et votre mot de pass est " + pass + " vous pouvez le changer dès votre premier accés");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "MAIL INVALID "); }

                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erreur:" + exe.Message, "Veuillez réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int getidcompte(string login, string pass)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from COMPTE where login='" + login + "'  and password='" + pass + "'", con);
                SqlDataReader rd = cmd.ExecuteReader(); rd.Read();
                return rd.GetInt32(0);
            }
        }
        void updateuser(int idu, int idcmpt)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" update PROFESSEUR set idCompte=" + idcmpt + " where idProfesseur=" + idu + " ", con);
                cmd.ExecuteNonQuery();

            }

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iduser = (gunaComboBox2.SelectedItem as dynamic).value;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from PROFESSEUR where idProfesseur=" + iduser + "", con);
                SqlDataReader reader = cmd.ExecuteReader(); reader.Read();
                loginbox.Text = reader.GetString(5);
                passbox.Text = RandomPassword(8);
            }
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
                MessageBox.Show("Mail envoyé à" + to, "");
            }
        }
        private void iconButtonCréerAdmin_Click(object sender, EventArgs e)
        {
            UserControl prof = new AjouterProfUserControl();
            openChildForm(prof);
        }
    }
}
