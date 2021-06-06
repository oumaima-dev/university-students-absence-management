using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class ModifierPass : Form
    {
        public ModifierPass(int ida,string login)
        {
            InitializeComponent();
            loginbox.Text = login;
            iduser = ida;
        }

        public int iduser { get; set; }
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonCréerAdmin_Click(object sender, EventArgs e)
        {
            string login = loginbox.Text;
            string pass = oldpass.Text;
            if (login.Length>0 && pass.Length>0 )
            {
                string password = detectuser(login, pass);
                if (password == null)
                {
                    MessageBox.Show("MOT DE PASSE SAISIE EST INCORRECT", "ATTENTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    oldpass.Focus();
                }
                else
                {
                    string newpass = nvpass.Text.Trim();
                    string confirm = confirmation.Text.Trim();
                    if (newpass.Equals(confirm) && newpass.Length>0)
                    {
                        int idcompte = getidcompte(iduser);
                        updateACC(idcompte,confirm);
                        MessageBox.Show("VOUS AVEZ MODIFIE VOTRE MOT DE PASSE ");
                    }
                    else
                    {
                        MessageBox.Show("RECONFIRMER VOTRE MOT DE PASSE", "ATTENTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        confirmation.Focus();
                    }
                }
            }
        }
        string detectuser(string login, string pass)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from COMPTE where login='" + login + "' and password='" + pass + "'", con);
                string cnt = cmd.ExecuteScalar().ToString();
                if (cnt == "1")
                {
                    cmd = new SqlCommand("select * from COMPTE where login='" + login + "' and password='" + pass + "'", con);
                    SqlDataReader rd = cmd.ExecuteReader(); rd.Read();
                    return rd.GetString(2);
                }
                else
                {
                    return null;
                }

            }
        }

        void updateACC(int id,string newpass)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update COMPTE set password='"+newpass+"' where idCompte="+id+" ", con);
                cmd.ExecuteNonQuery();
            }
        }
        public int getidcompte(int iduser)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                    SqlCommand cmd = new SqlCommand("select * from ADMIN where idAdmin="+iduser+"", con);
                    SqlDataReader rd = cmd.ExecuteReader(); rd.Read();
                    return rd.GetInt32(8);
            }
        }
    }
}
