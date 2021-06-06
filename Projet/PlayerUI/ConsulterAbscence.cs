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
using System.Configuration;

namespace PlayerUI
{
    public partial class ConsulterAbscence : UserControl
    {

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);

        public ConsulterAbscence()
        {
            InitializeComponent();
            fill_filiere();

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
        public void fill_Module()
        {
            if (gunaComboBoxFil.SelectedItem != null)
            {
                gunaComboBoxModule.Items.Clear();

                connection.Open();
                int idF = (gunaComboBoxFil.SelectedItem as dynamic).value;
                SqlCommand cmd = new SqlCommand("select MODULE.idModule,MODULE.libelle from MODULE,MODULELISTE where MODULE.idModule = MODULELISTE.idModule and MODULELISTE.idFiliere = '" + idF + "' ", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                gunaComboBoxModule.DisplayMember = "Text";
                gunaComboBoxModule.ValueMember = "value";
                while (reader.Read())
                {

                    gunaComboBoxModule.Items.Add(new { Text = reader.GetString(1), value = reader.GetInt32(0) });

                }

                connection.Close();

            }
        }
        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            if(gunaComboBoxFil.SelectedItem !=null && gunaComboBoxModule.SelectedItem != null) { 
            int idf = (gunaComboBoxFil.SelectedItem as dynamic).value;
            int idm = (gunaComboBoxModule.SelectedItem as dynamic).value;
            ConsulterAbsForm c = new ConsulterAbsForm(idf,idm);
            c.ShowDialog();

            }
            else
            {
                MessageBox.Show("Veuillez choisir la filière ainsi que le module que vous voullez consulter ses absences !");
            }

        }

        private void gunaComboBoxFil_Leave(object sender, EventArgs e)
        {
            fill_Module();
        }
    }
}
