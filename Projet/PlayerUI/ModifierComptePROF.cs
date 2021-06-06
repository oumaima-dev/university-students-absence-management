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
using System.Text.RegularExpressions;
using System.Configuration;

namespace PlayerUI
{
    public partial class ModifierComptePROF : UserControl
    {
         string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        public ModifierComptePROF(string login)
        {
            InitializeComponent();
            gunaLineTextBoxLogin.Text = login;
        }

        private void UserControlModifierCompte_Load(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBoxMdp_Leave(object sender, EventArgs e)
        {
            if (getOldPassword(gunaLineTextBoxLogin.Text) != gunaLineTextBoxMdp.Text)
            {
                MessageBox.Show("Mot de Passe incorrect! Veuillez réessayez");
                gunaLineTextBoxMdp.Clear();
                gunaLineTextBoxMdp.Focus();
            }
        }

        private string getOldPassword(string login)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string pass = "";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select password from COMPTE where login = '" + gunaLineTextBoxLogin.Text + "'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                pass = dt.Rows[0][0].ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                
            }
            return pass;
        }
        }

        private void gunaLineTextNvxMdp_Leave(object sender, EventArgs e)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var lenght = new Regex(@".{6,14}");
            
            var validPassword = hasNumber.IsMatch(gunaLineTextNvxMdp.Text) && hasUpperChar.IsMatch(gunaLineTextNvxMdp.Text) && lenght.IsMatch(gunaLineTextNvxMdp.Text);

            if (!validPassword)
            {
                MessageBox.Show("Votre Mot de Passe doit contenir au moins 6 caractères avec des nombres et des lettres majiscules ! ");
                gunaLineTextNvxMdp.Clear();
                gunaLineTextNvxMdp.Focus();
            }
        }

        private void iconButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void iconButtonModifier_Click(object sender, EventArgs e)
        {
            if (gunaLineTextBoxconfirmMdp.Text.Equals(gunaLineTextNvxMdp.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                string nouveauPass = gunaLineTextBoxconfirmMdp.Text;

                SqlCommand command1 = connection.CreateCommand();
                command1.CommandType = CommandType.Text;
                command1.CommandText = "update COMPTE set password =  '" + nouveauPass + "'  where login = '" + gunaLineTextBoxLogin.Text + "' ";
                command1.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Votre Mot de Passe est modifié avec succés !");
                this.Parent.Controls.Remove(this);
                }
            }
            else
            {
                MessageBox.Show("Veuillez Confirmer votre nouveau Mot de Passe !");
                gunaLineTextBoxconfirmMdp.Clear();
                gunaLineTextBoxconfirmMdp.Focus();
            }
            
            
        }


    }
}
