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
    public partial class AjoutAbsence : UserControl
    {

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);

        public AjoutAbsence()
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
        public void fill_Etudiant()
        {
            if (gunaComboBoxFil.SelectedItem != null)
            {
                gunaComboBoxCNE.Items.Clear();

            connection.Open();
            int idF = (gunaComboBoxFil.SelectedItem as dynamic).value;
            SqlCommand cmd = new SqlCommand("select * from ETUDIANT where idFiliere = '" + idF + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            gunaComboBoxCNE.DisplayMember = "Text";
            gunaComboBoxCNE.ValueMember = "value";
            while (reader.Read())
            {

                gunaComboBoxCNE.Items.Add(new { Text = reader.GetString(4) + " " + reader.GetString(3), value = reader.GetInt32(0) });

            }

            connection.Close();

            }
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

        private void gunaComboBoxFil_Leave(object sender, EventArgs e)
        {
            fill_Module();
            fill_Etudiant();
        }

        public void fill_PROF()
        {
            if (gunaComboBoxModule.SelectedItem != null)
            {
                gunaComboBoxProf.Items.Clear();

            connection.Open();
            SqlCommand cmd = new SqlCommand("select PROFESSEUR.idProfesseur,PROFESSEUR.nom,PROFESSEUR.prenom from PROFESSEUR,AFFECTATION where PROFESSEUR.idProfesseur = AFFECTATION.idProfesseur and AFFECTATION.module = '" + (gunaComboBoxModule.SelectedItem as dynamic).value + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            gunaComboBoxProf.DisplayMember = "Text";
            gunaComboBoxProf.ValueMember = "value";
            while (reader.Read())
            {

                gunaComboBoxProf.Items.Add(new { Text = reader.GetString(2) + " " + reader.GetString(1), value = reader.GetInt32(0) });

            }

            connection.Close();


            }
            else
            {
                gunaComboBoxProf.Items.Clear();
            }
        }
        public void viderChamps()
        {
            gunaComboBoxCNE.Items.Clear();
            gunaComboBoxFil.Items.Clear();
            gunaComboBoxHeureDebut.Items.Clear();
            gunaComboBoxHeureFin.Items.Clear();
            gunaComboBoxModule.Items.Clear();
            gunaComboBoxProf.Items.Clear();
            
        }

        private void gunaComboBoxModule_Leave(object sender, EventArgs e)
        {
            fill_PROF();
        }
        private bool checkHour()
        { 
            int debut = Int16.Parse(gunaComboBoxHeureDebut.SelectedItem.ToString());
            int fin = Int16.Parse(gunaComboBoxHeureFin.SelectedItem.ToString());
            if (debut >= fin)
            {
               MessageBox.Show("Veuillez choisir une heure correcte de la fin de la séance !");
                return false;
            }return true;
        }

        private void checkHour2()
        {
            if (gunaComboBoxHeureDebut.SelectedItem.Equals("8") && (gunaComboBoxHeureFin.SelectedItem.Equals("16") || gunaComboBoxHeureFin.SelectedItem.Equals("18")) ||
                gunaComboBoxHeureDebut.SelectedItem.Equals("10") && (gunaComboBoxHeureFin.SelectedItem.Equals("10") || gunaComboBoxHeureFin.SelectedItem.Equals("16") || gunaComboBoxHeureFin.SelectedItem.Equals("18")) ||
                gunaComboBoxHeureDebut.SelectedItem.Equals("14") && (gunaComboBoxHeureFin.SelectedItem.Equals("10") || gunaComboBoxHeureFin.SelectedItem.Equals("12")) ||
                gunaComboBoxHeureDebut.SelectedItem.Equals("16") && (gunaComboBoxHeureFin.SelectedItem.Equals("10") || gunaComboBoxHeureFin.SelectedItem.Equals("12") || gunaComboBoxHeureFin.SelectedItem.Equals("16")))
            {
                MessageBox.Show("Veuillez choisir une heure correcte de la fin de la séance !");
               
                gunaComboBoxHeureFin.Focus();
            }
            else
            {
                //
            }
        }

        private void gunaComboBoxHeureFin_Leave(object sender, EventArgs e)
        {
            //checkHour();
        }

        private void iconButtonAjouterAbs_Click(object sender, EventArgs e)
        {
            if (gunaComboBoxHeureFin.SelectedItem != null && gunaComboBoxHeureDebut.SelectedItem != null &&
                gunaComboBoxFil.SelectedItem != null && gunaComboBoxModule.SelectedItem != null &&
                gunaComboBoxProf.SelectedItem != null && gunaComboBoxCNE.SelectedItem != null && gunaDateTimePicker1.Text != null)
            
            {
                try
                {
                    if (checkHour())
                    {
                        connection.Open();
                        int idModule = (gunaComboBoxModule.SelectedItem as dynamic).value;
                        int idFiliere = (gunaComboBoxFil.SelectedItem as dynamic).value;
                        int idProf = (gunaComboBoxProf.SelectedItem as dynamic).value;
                        int idEtudiant = (gunaComboBoxCNE.SelectedItem as dynamic).value;

                        DateTime date;
                        date = gunaDateTimePicker1.Value;
                        date.ToString("yyyy-MM-dd");

                        SqlCommand command1 = connection.CreateCommand();
                        command1.CommandType = CommandType.Text;
                        command1.CommandText = "insert into ABSENCE(etat,heureDebut,HeureFin,idProfesseur,idModule,idEtudiant,idFiliere,dateAbsence) values ('" + false + "' ,'" + gunaComboBoxHeureDebut.Text + "','" + gunaComboBoxHeureFin.Text

                            + "','" + idProf + "','" + idModule + "','" + idEtudiant + "','" + idFiliere + "','" + date.ToString("yyyy-MM-dd") + "')";
                        command1.ExecuteNonQuery();
                        MessageBox.Show("l'absence est ajoutée avec succes !");
                        viderChamps();
                    }

                    connection.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Veuillez Ressayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

            }
            else
            {
                MessageBox.Show("Veuillez remplir le(s) champs vide(s) !");
            }
        }

        private void AjoutAbsence_Load(object sender, EventArgs e)
        {
            
        }
    }
}
