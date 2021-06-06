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
using System.Globalization;
using System.Configuration;

namespace PlayerUI
{
    public partial class EtudiantGererCompteUserControl : UserControl
    {
       
        int e_idCompte = 0;
     
        String e_password = "";

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString());




        public EtudiantGererCompteUserControl(int idCompte,String password)
        {
            InitializeComponent();
            fill_details(idCompte,password);
          
        }
        public void fill_details(int idCompte, String password)
        {

            e_idCompte = idCompte;
            e_password = password;


        }

        private void vidermotdepasse()
        {
            gunaLineTextBox5.Text = "";
            gunaLineTextBox8.Text = "";
            gunaLineTextBox9.Text = "";
        }
        private Boolean checkInfos()
        {
            Boolean flag = false;


            if (flag == false && gunaLineTextBox8.Text != e_password)
            {
                MessageBox.Show("Mot de passe incorrect");
                flag = true;
                vidermotdepasse();
            }
            if (flag == false && gunaLineTextBox5.Text != gunaLineTextBox9.Text)
            {
                MessageBox.Show("Les deux mot de passe sont différent , Veuillez confirmer avec le même nouveau mot de passe");
                flag = true;
                vidermotdepasse();
            }
            if (flag == false && gunaLineTextBox5.Text == "" || gunaLineTextBox9.Text == "")
            {
                MessageBox.Show("Veuillez remplir les champs");
                flag = true;
                vidermotdepasse();
            }


            return flag;
        }

        public void updateEtudiantCompte()
        {

            if (checkInfos() == false)
            {

                try
                {

                    con.Open();
                    SqlCommand command1 = con.CreateCommand();
                    command1.CommandType = CommandType.Text;

                    command1.CommandText = "update COMPTE set password='" + gunaLineTextBox9.Text + "'   where idCompte=" + e_idCompte + " ";

                    command1.ExecuteNonQuery();

                    MessageBox.Show("Modification réussie");

                    con.Close();
                    vidermotdepasse();

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Veuillez Ressayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }


        }
        private void EtudiantGererCompteUserControl_Load(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox8_TextChanged(object sender, EventArgs e)
        {
            if (gunaLineTextBox8.Text != "")
            {
                gunaLineTextBox5.Enabled = true;
                gunaLineTextBox9.Enabled = true;
            }
            else
            {
                gunaLineTextBox5.Enabled = false;
                gunaLineTextBox9.Enabled = false;
            }

        }

        private void iconButtonCréerAdmin_Click(object sender, EventArgs e)
        {
            updateEtudiantCompte();
        }
    }
}
