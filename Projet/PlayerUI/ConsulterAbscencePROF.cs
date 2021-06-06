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
    public partial class ConsulterAbscencePROF : UserControl
    {
        string connection = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        private string Email { get; set; }
        public ConsulterAbscencePROF(string email)
        {
            InitializeComponent();
            Email = email;
            fill_filiere(getIdProf());

        }
        private int getIdProf()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select idProfesseur from PROFESSEUR where email ='" + Email + "'", con);
                SqlDataReader rd = cmd.ExecuteReader(); rd.Read();
                int id = rd.GetInt32(0);
                return id;
            }
        }

        public void fill_filiere(int idp)
        {
            gunaComboBoxFil.Items.Clear();
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * FROM FILIERE,MODULELISTE,MODULE,AFFECTATION where FILIERE.idFiliere=MODULELISTE.idFiliere and MODULELISTE.idModule=MODULE.idModule and MODULE.idModule=AFFECTATION.module and AFFECTATION.idProfesseur="+idp+"", con);

                SqlDataReader reader = cmd.ExecuteReader();
                gunaComboBoxFil.DisplayMember = "Text";
                gunaComboBoxFil.ValueMember = "value";
                while (reader.Read())
                {

                    gunaComboBoxFil.Items.Add(new { Text = reader.GetString(1), value = reader.GetInt32(0) });

                }

                con.Close();
            }


        }
        public void fill_Module()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                if (gunaComboBoxFil.SelectedItem != null)
                {
                    gunaComboBoxModule.Items.Clear();

                    con.Open();
                    int idF = (gunaComboBoxFil.SelectedItem as dynamic).value;
                    int IdProf = getIdProf();
                    SqlCommand cmd = new SqlCommand("select MODULE.idModule,MODULE.libelle from MODULE JOIN MODULELISTE on MODULE.idModule = MODULELISTE.idModule and MODULELISTE.idFiliere = '" + idF + "' JOIN AFFECTATION on MODULE.idModule = AFFECTATION.module and AFFECTATION.idProfesseur = '" + IdProf + "'", con);


                    SqlDataReader reader = cmd.ExecuteReader();
                    gunaComboBoxModule.DisplayMember = "Text";
                    gunaComboBoxModule.ValueMember = "value";
                    while (reader.Read())
                    {

                        gunaComboBoxModule.Items.Add(new { Text = reader.GetString(1), value = reader.GetInt32(0) });

                    }

                    con.Close();
                }
            }
        }
        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            if(gunaComboBoxFil.SelectedItem !=null && gunaComboBoxModule.SelectedItem != null) { 
            int idf = (gunaComboBoxFil.SelectedItem as dynamic).value;
            int idm = (gunaComboBoxModule.SelectedItem as dynamic).value;
            ConsulterAbsFormPROF c = new ConsulterAbsFormPROF(idf,idm,getIdProf());
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
