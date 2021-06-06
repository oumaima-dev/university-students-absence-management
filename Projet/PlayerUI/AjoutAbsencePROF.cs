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
    public partial class AjoutAbsencePROF : UserControl
    {
        string connection = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        private string Email { get;set; }

        public AjoutAbsencePROF(string email)
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
        public void fill_Etudiant()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                if (gunaComboBoxFil.SelectedItem != null)
                {
                    gunaComboBoxCNE.Items.Clear();

                    con.Open();
                    int idF = (gunaComboBoxFil.SelectedItem as dynamic).value;
                    SqlCommand cmd = new SqlCommand("select * from ETUDIANT where idFiliere = '" + idF + "'", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    gunaComboBoxCNE.DisplayMember = "Text";
                    gunaComboBoxCNE.ValueMember = "value";
                    while (reader.Read())
                    {

                        gunaComboBoxCNE.Items.Add(new { Text = reader.GetString(4) + " " + reader.GetString(3), value = reader.GetInt32(0) });

                    }

                    con.Close();
                }
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

        private void gunaComboBoxFil_Leave(object sender, EventArgs e)
        {
            fill_Module();
            fill_Etudiant();
        }

        private void gunaComboBoxModule_Leave(object sender, EventArgs e)
        {

        }

        private void gunaComboBoxHeureFin_Leave(object sender, EventArgs e)
        {

        }



        private void iconButtonAjouterAbs_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                if (gunaComboBoxHeureFin.SelectedItem != null && gunaComboBoxHeureDebut.SelectedItem != null &&
                    gunaComboBoxFil.SelectedItem != null && gunaComboBoxModule.SelectedItem != null &&
                    gunaComboBoxCNE.SelectedItem != null && gunaDateTimePicker1.Text != null)

                {
                    try
                    {
                        con.Open();
                        int idModule = (gunaComboBoxModule.SelectedItem as dynamic).value;
                        int idFiliere = (gunaComboBoxFil.SelectedItem as dynamic).value;
                        int idProf = getIdProf();
                        int idEtudiant = (gunaComboBoxCNE.SelectedItem as dynamic).value;

                        DateTime date;
                        date = gunaDateTimePicker1.Value;
                        date.ToString("yyyy-MM-dd");

                        SqlCommand command1 = con.CreateCommand();
                        command1.CommandType = CommandType.Text;
                        command1.CommandText = "insert into ABSENCE(etat,heureDebut,HeureFin,idProfesseur,idModule,idEtudiant,idFiliere,dateAbsence) values ('" + false + "' ,'" + gunaComboBoxHeureDebut.Text + "','" + gunaComboBoxHeureFin.Text

                            + "','" + idProf + "','" + idModule + "','" + idEtudiant + "','" + idFiliere + "','" + date.ToString("yyyy-MM-dd") + "')";



                        command1.ExecuteNonQuery();
                        MessageBox.Show("l'absence est ajoutée avec succes !");

                        gunaComboBoxFil.SelectedItem = null;
                        gunaComboBoxModule.SelectedItem = null;
                        gunaComboBoxCNE.SelectedItem = null;
                        gunaComboBoxHeureDebut.SelectedItem = null;
                        gunaComboBoxHeureFin.SelectedItem = null;


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


                else
                {
                    MessageBox.Show("Veuillez remplir le(s) champs vide(s) !");
                }
            }
        }
    }
}
