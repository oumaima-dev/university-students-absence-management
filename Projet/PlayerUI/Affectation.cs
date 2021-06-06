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
    

    public partial class Affectation : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);


        public Affectation()
        {
            InitializeComponent();
            fill_filiere();
            fill_PROF();
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

        public void fill_PROF()
        {
            gunaComboBoxProf.Items.Clear();

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from PROFESSEUR", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            gunaComboBoxProf.DisplayMember = "Text";
            gunaComboBoxProf.ValueMember = "value";
            while (reader.Read())
            {

                gunaComboBoxProf.Items.Add(new { Text = reader.GetString(2) + " "+ reader.GetString(3), value = reader.GetInt32(0) });

            }

            connection.Close();


        }

        public void fill_Module()
        {
            if (gunaComboBoxFil.SelectedItem != null) { 
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


        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradientButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaComboBoxFil_Leave(object sender, EventArgs e)
        {
            fill_Module();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (gunaComboBoxProf.SelectedItem !=null && gunaDateTimePicker1.Value != null && gunaComboBoxModule.SelectedItem != null) { 
            try
            {
                DateTime date;
                date = gunaDateTimePicker1.Value;
                date.ToString("yyyy-MM-dd");

                connection.Open();
                SqlCommand command1 = connection.CreateCommand();
                command1.CommandType = CommandType.Text;
                command1.CommandText = "insert into AFFECTATION values ('" + (gunaComboBoxProf.SelectedItem as dynamic).value + "','" + date.ToString("yyyy-MM-dd") + "','" + (gunaComboBoxModule.SelectedItem as dynamic).value + "' )";

                command1.ExecuteNonQuery();
                    MessageBox.Show("l'affectation est réussie !");

            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite ! Veuillez réessayer");
            }
            finally
            {
                connection.Close();
                    this.Close();
            }
            }
            else
            {
                MessageBox.Show("Veuillez remplir le(s) champs vide(s) !");
            }
        }
    }
}
