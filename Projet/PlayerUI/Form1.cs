using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Media;

namespace PlayerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///string connectionString =@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo 310\Desktop\Mode connecté\mydb.mdf;Integrated Security=True";
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region MediaSubMenu

        #endregion

        #region PlayListManagemetSubMenu

        #endregion
 
        #region ToolsSubMenu

        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void gunaLineTextBox1_Click(object sender, EventArgs e)
        {
            gunaLineTextBox1.Clear();
        }
        private void gunaLineTextBox4_TextChanged(object sender, EventArgs e)
        {
            gunaLineTextBox4.PasswordChar = '*';
        }
        private void gunaLineTextBox4_Click(object sender, EventArgs e)
        {
            gunaLineTextBox4.Clear();
            gunaLineTextBox4.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            string login=gunaLineTextBox1.Text.Trim();
            string pass=gunaLineTextBox4.Text.Trim();
            string profil = detectuser(login, pass);
            if (profil == null)
            {
                MessageBox.Show("Entrez des informations valide pour se connecter. \nou demandez à votre établissement le login et mot de passe de votre compte", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else{ MessageBox.Show(" Compte "+profil);
                panelSideMenu.Hide();int idu=0;
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

                //SoundPlayer p = new SoundPlayer(@"C:\Users\lenovo 310\Desktop\Tinder-notificacion-sound-effect.wav");
                SoundPlayer p = new SoundPlayer();
                p.Stream= resources.GetStream ("Tinder-notificacion-sound-effect");
                p.Play();
                switch (profil)
                {
                    case "ADMIN":
                         idu =getiduser(login,pass,"ADMIN");
                        openChildForm(new Administrateur(idu));break ;
                    case "ETUDIANT":
                         idu = getiduser(login, pass,"ETUDIANT");
                        openChildForm(new Etudiant(idu)); 
                        break;
                    case "PROFESSEUR":
                         idu = getiduser(login, pass,"PROFESSEUR");
                        openChildForm(new Professeur(idu)); 
                        break;
                }
                DateTime date=DateTime.Now;
                string format = "yyyy-MM-dd HH:mm:ss";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand command1 = con.CreateCommand();
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = "insert into historique values ('"+idu+"','"+date.ToString(format) + "')";



                    command1.ExecuteNonQuery();
                }
            }
            

        }
        int getiduser(string login,string pass,string profil)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from "+profil+",COMPTE where "+profil+".idCompte=COMPTE.idCompte and login='" + login + "' and password='" + pass + "'", con);
                SqlDataReader rd = cmd.ExecuteReader(); rd.Read();
                return rd.GetInt32(0);
            }
        }
        string detectuser(string login,string pass)
        {
            using(SqlConnection con=new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from COMPTE where login='"+login+"' and password='"+pass+"'", con);
                string cnt = cmd.ExecuteScalar().ToString();
                if (cnt=="1")
                {
                    cmd= new SqlCommand("select * from COMPTE where login='" + login + "' and password='" + pass + "'", con);
                    SqlDataReader rd= cmd.ExecuteReader();rd.Read();
                    return rd.GetString(3);
                }
                else
                {
                    return null;
                }
      
            }
        }


        private void opennewform(object obj)
        {
            Application.Run(new Administrateur(0));

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panelSideMenu.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //button de test
            declarerAbsence f = new declarerAbsence(15);
            f.ShowDialog();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
