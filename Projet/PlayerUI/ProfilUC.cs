﻿using System;
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
    public partial class ProfilUC : UserControl
    {
        public ProfilUC(string nom,string filier,Bitmap img,int id)
        {
            InitializeComponent();
            gunaCirclePictureBox2.Image = img;
            gunaLabel1.Text = nom;
            gunaLabel2.Text = filier;
            idlabel.Text = id.ToString();
            layoutpanel.Visible = false;
            panelhs.Visible = false;
            this.Size = new System.Drawing.Size(440, 42);
            fill_filiere();

        }
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        //pour savoir si l'utilisateur a modifié un champs  
        static bool change = false;

        void remplir_champs()
        {
            int id =Int32.Parse(idlabel.Text);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ETUDIANT,FILIERE where ETUDIANT.idFILIERE=FILIERE.idFILIERE   and idEtudiant=" + id+"", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                nombox.Text = reader.GetString(3);
                prenombox.Text = reader.GetString(4);
                cinbox.Text = reader.GetString(1);
                cnebox.Text = reader.GetString(2);
                emailbox.Text = reader.GetString(6);
                telbox.Text = reader.GetString(7);
                gunaComboBox1.Text=reader.GetString(12);
                DateNaissanceEtudiant.Value = Convert.ToDateTime(reader.GetDateTime(5));
            }
        }
        public void fill_filiere()
        {
            gunaComboBox1.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from FILIERE", con);
                SqlDataReader reader = cmd.ExecuteReader();
                gunaComboBox1.DisplayMember = "Text";
                gunaComboBox1.ValueMember = "value";
                while (reader.Read())
                {

                    gunaComboBox1.Items.Add(new { Text = reader.GetString(1), value = reader.GetInt32(0) });

                }

            }
        }
        private void gunaShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            if(layoutpanel.Visible == false)
            {
                layoutpanel.Visible = true;
            }
            else
            {
                layoutpanel.Visible = false;
            }
        }

        private void gunaShadowPanel2_MouseHover(object sender, EventArgs e)
        {
            this.gunaShadowPanel2.BaseColor = System.Drawing.SystemColors.InactiveCaption;

        }

        private void gunaShadowPanel2_MouseLeave(object sender, EventArgs e)
        {
            this.gunaShadowPanel2.BaseColor = System.Drawing.SystemColors.Window;
            
        }
        void delete_user()
        {
            int id=Int32.Parse(idlabel.Text);
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ETUDIANT where idEtudiant="+id+"", con);
                    cmd.ExecuteNonQuery();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Vous voullez supprimer ", "confirmation", MessageBoxButtons.YesNo)) return;
            delete_user();
            this.Visible = false;
        }
        ComponentResourceManager resources = new ComponentResourceManager(typeof(ProfilUC));

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            if (panelhs.Visible == false)
            {
                remplir_champs();//si on rempli les champs alors la variable CHANGE se change!
                change = false;

                this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.InitialImage")));
                panelhs.Visible = true;
                this.Size = new System.Drawing.Size(640,220);

            }
            else
            {
                panelhs.Visible = false;
                this.Size = new System.Drawing.Size(640, 55);
                this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
                DateTime date;
                date = DateNaissanceEtudiant.Value;
                if (change)
                {
                    if (DialogResult.Yes == MessageBox.Show("Enregistrer les modification", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        update_user(Int32.Parse(idlabel.Text), (gunaComboBox1.SelectedItem as dynamic).value, nombox.Text, prenombox.Text, date.ToString("yyyy-MM-dd"), emailbox.Text, telbox.Text, cinbox.Text, cnebox.Text);
                        this.gunaLabel1.Text = prenombox.Text.Trim() + " " + nombox.Text.Trim();
                        this.gunaLabel2.Text = (gunaComboBox1.SelectedItem as dynamic).Text;
                        change = false;
                    }
                }
            }
        }
        void update_user(int id, int idFiliere, String nom = "", String prenom = "", String dateNaissance = "", String email = "", String telephone = "", String cin = "", String cne = "")
            {
            SqlConnection connection = new SqlConnection( ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            try
            {
                connection.Open();
                SqlCommand command1 = connection.CreateCommand();
                command1.CommandType = CommandType.Text;
                command1.CommandText = "update ETUDIANT set cin='"+cin+"' , cne='"+cne+"' , nom='"+nom+"' , prenom='"+prenom+"', dateNaissance='"+dateNaissance+"' , email='"+email+"' , telephone='"+telephone+"' , idFiliere="+idFiliere+" where idEtudiant="+id+" ";
                command1.ExecuteNonQuery();
                MessageBox.Show("Modification réussie");
                
                connection.Close();


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message , "Veuillez Ressayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void cinbox_TextChanged(object sender, EventArgs e)
        {
            change = true;
        }
    }
}
