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
using System.IO;
using System.Configuration;

namespace PlayerUI
{
    public partial class EtudiantConsulterAbsenceUserControl : UserControl
    {
        int e_idEtudiant = 0;
        int e_idFiliere = 0;
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString();
        public EtudiantConsulterAbsenceUserControl(int idFiliere,int idEtudiant)
        {
            InitializeComponent();
            e_idEtudiant = idEtudiant;
            e_idFiliere = idFiliere;
            fill_module();
            fill_allabsence();
           
        }
        public void fill_module()
        {
            guna2ComboBox1.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
               
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from MODULELISTE,MODULE where MODULE.idModule=MODULELISTE.idModule AND MODULELISTE.idFiliere='" + e_idFiliere + "'", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    guna2ComboBox1.DisplayMember = "Text";
                    guna2ComboBox1.ValueMember = "value";
                    while (reader.Read())
                    {

                        guna2ComboBox1.Items.Add(new { Text = reader.GetString(3), value = reader.GetInt32(2) });

                  
                }
            }
        }
        public void fill_absence(int idModule,Boolean etat = false)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                layoutpanel.Controls.Clear();
                con.Open();
               
                    SqlCommand cmd = new SqlCommand("select * from ABSENCE,MODULE WHERE ABSENCE.idModule=MODULE.idModule " +
                        "                       AND ABSENCE.idEtudiant='" + e_idEtudiant + "'AND ABSENCE.idModule='" + idModule + "' AND ABSENCE.etat='"+etat+ "'", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {


                        EtudiantJustifierUserControl uc = new EtudiantJustifierUserControl(reader.GetString(12), reader.GetDateTime(10).ToString("yyyy-MM-dd"), reader.GetInt32(2), reader.GetInt32(3),reader.GetBoolean(1) ,reader.GetInt32(0));

                        layoutpanel.Controls.Add(uc);


                    }
               

            }
        }
        public void fill_absence_etat(Boolean etat)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                layoutpanel.Controls.Clear();
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from ABSENCE,MODULE WHERE ABSENCE.idModule=MODULE.idModule " +
                    "                       AND ABSENCE.idEtudiant='" + e_idEtudiant + "'AND ABSENCE.etat='" + etat + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {


                    EtudiantJustifierUserControl uc = new EtudiantJustifierUserControl(reader.GetString(12), reader.GetDateTime(10).ToString("yyyy-MM-dd"), reader.GetInt32(2), reader.GetInt32(3), reader.GetBoolean(1), reader.GetInt32(0));

                    layoutpanel.Controls.Add(uc);


                }


            }
        }
        public void fill_absence_module(int idModule)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                layoutpanel.Controls.Clear();
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from ABSENCE,MODULE WHERE ABSENCE.idModule=MODULE.idModule " +
                    "                       AND ABSENCE.idEtudiant='" + e_idEtudiant + "'AND ABSENCE.idModule='" + idModule + "' ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {


                    EtudiantJustifierUserControl uc = new EtudiantJustifierUserControl(reader.GetString(12), reader.GetDateTime(10).ToString("yyyy-MM-dd"), reader.GetInt32(2), reader.GetInt32(3), reader.GetBoolean(1), reader.GetInt32(0));

                    layoutpanel.Controls.Add(uc);


                }


            }
        }
        public void fill_allabsence()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                layoutpanel.Controls.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ABSENCE,MODULE WHERE ABSENCE.idModule=MODULE.idModule " +
                    "                       AND ABSENCE.idEtudiant='" + e_idEtudiant + "' ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Console.WriteLine(reader.GetString(12));
                    Console.WriteLine(reader.GetDateTime(10).ToString());
                    Console.WriteLine(reader.GetInt32(2));
                    Console.WriteLine(reader.GetInt32(3));
                    Console.WriteLine(reader.GetInt32(0));

                    EtudiantJustifierUserControl uc = new EtudiantJustifierUserControl(reader.GetString(12), reader.GetDateTime(10).ToString("yyyy-MM-dd"), reader.GetInt32(2), reader.GetInt32(3), reader.GetBoolean(1),reader.GetInt32(0));

                    layoutpanel.Controls.Add(uc);


                }

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idm = (guna2ComboBox1.SelectedItem as dynamic).value;
            guna2RadioButton3.Checked = true;
            fill_absence_module(idm);
        }

        private void guna2RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
            
            if (guna2ComboBox1.SelectedItem != null)
            {
                int idm = (guna2ComboBox1.SelectedItem as dynamic).value;
                fill_absence_module(idm);
            }
            else
            {
                fill_allabsence();
            }
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (guna2ComboBox1.SelectedItem != null)
            {
                int idm = (guna2ComboBox1.SelectedItem as dynamic).value;
                fill_absence(idm);
            }
          
             else
            {
                fill_absence_etat(false);
            }
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (guna2ComboBox1.SelectedItem != null)
            {
                int idm = (guna2ComboBox1.SelectedItem as dynamic).value;
                fill_absence(idm,true);
            }
            else
            {
                fill_absence_etat(true);
            }
        }
    }
}
