using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PlayerUI
{
    public partial class AjouterModule : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);

        public AjouterModule()
        {
            InitializeComponent();
            fill_filiere();
        }

        private void gunaGradientButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void fill_filiere()
        {
            gunaComboBoxFil.Items.Clear();
           
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from FILIERE", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                gunaComboBoxFil.DisplayMember = "Text";
                gunaComboBoxFil.ValueMember = "value";
                while (reader.Read())
                {

                    gunaComboBoxFil.Items.Add(new { Text = reader.GetString(1), value = reader.GetInt32(0) });

                }

            connection.Close();

            
        }


        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (gunaTextBoxNomModule.Text != " ")
            {

                try
                {
                    connection.Open();
                    SqlCommand command1 = connection.CreateCommand();
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = "insert into MODULE(libelle) values ('" + gunaTextBoxNomModule.Text + "')";

                    command1.ExecuteNonQuery();

                    SqlCommand command2 = connection.CreateCommand();
                    command2.CommandType = CommandType.Text;
                    command2.CommandText = "select idModule from MODULE where libelle =  '" + gunaTextBoxNomModule.Text + "' ";
                   
                    SqlDataReader reader = command2.ExecuteReader();
                    
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // remplir la table Module Liste

                    int idM = Convert.ToInt32(dt.Rows[0][0]);
                    int idF = (gunaComboBoxFil.SelectedItem as dynamic).value;
                    SqlCommand command3 = connection.CreateCommand();
                    command3.CommandType = CommandType.Text;
                    command3.CommandText = "insert into MODULELISTE values ('" + idF + "','" + idM + "')";

                    command3.ExecuteNonQuery();

                    MessageBox.Show("Le module est ajouté avec succés !");

                   

                    

                    
                    reader.Close();
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

                MessageBox.Show(this, "Veuillez remplir le champ vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


    }
}
