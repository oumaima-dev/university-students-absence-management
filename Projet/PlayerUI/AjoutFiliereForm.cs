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
    public partial class AjoutFiliereForm : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);

        public AjoutFiliereForm()
        {
            InitializeComponent();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (gunaTextBoxNomFiliere.Text != " " && gunaTextBoxAbrevFili.Text != " ")
            {

                try
                {
                    connection.Open();
                    SqlCommand command1 = connection.CreateCommand();
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = "insert into FILIERE(libelle, abreviation) values ('" + gunaTextBoxNomFiliere.Text + "','" + gunaTextBoxAbrevFili.Text + "')";

                    command1.ExecuteNonQuery();
                    MessageBox.Show("La filière est ajoutée avec succes !");
                    connection.Close();

                }
                catch
                {
                    MessageBox.Show("Une erreur s'est produite ! Veuillez Réssayer ");
                }
                finally
                {
                    connection.Close();
                    this.Close();
                }
            }
            else
            {

                MessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gunaGradientButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
