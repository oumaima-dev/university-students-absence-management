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
using System.IO;
using System.Configuration;

namespace PlayerUI
{
    public partial class Etudiant : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString());

        int e_idCompte = 0;
        int e_idEtudiant = 0;
        int e_idFiliere = 0;
       
        String e_mot_de_passe = "";

      
        public Etudiant(int idEtudiant)
        {
            InitializeComponent();
            hideSubMenu();
            e_idEtudiant = idEtudiant;
            getInfos(e_idEtudiant);
            
        }
        String imageFilName = "";

        public void getInfos(int idEtudiant)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ETUDIANT,COMPTE  where ETUDIANT.idCompte=COMPTE.idCompte AND ETUDIANT.idEtudiant='"+idEtudiant+"' ", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                e_idCompte = reader.GetInt32(9);
                e_idEtudiant = reader.GetInt32(0);
                e_idFiliere = reader.GetInt32(10);
                e_mot_de_passe = reader.GetString(13);
                gunaLineTextBox1.Text = "Bonjour, "+ reader.GetString(4)+" "+ reader.GetString(3) +"";
              
                byte[] output;
                if (!reader.IsDBNull(8))
                {
                    output = (byte[])reader[8];
                    using (MemoryStream ms = new MemoryStream(output))
                    {

                        gunaPictureBox1.Image = new Bitmap(ms);

                    }
                }
                con.Close();
            }
            catch
            {

            }
        }

        private void hideSubMenu()
        {
          
            panelGérerAbs.Visible =false;
           


        }
        private UserControl activeForm = null;
        private void openChildForm(UserControl childForm)
        {
            if (activeForm != null) activeForm.Hide();
            activeForm = childForm;
            //  childForm.Location()= false;
            // childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Bottom;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void iconButtonAjoutAbs_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGérerAbs);
        }

        

            private void iconButtonModifAbs_Click(object sender, EventArgs e)
        {
            UserControl ConsulterAbsence= new EtudiantConsulterAbsenceUserControl(e_idFiliere,e_idEtudiant);
            openChildForm(ConsulterAbsence);
            hideSubMenu();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            UserControl gererCompte = new EtudiantGererCompteUserControl(e_idCompte,e_mot_de_passe );
            openChildForm(gererCompte);
      
            hideSubMenu();
            
        }

        private void iconButtonModifierAdmin_Click(object sender, EventArgs e)
        {
            UserControl gererCompte = new EtudiantGererCompteUserControl(e_idCompte, e_mot_de_passe);
            openChildForm(gererCompte);
            
        }

        private void iconButtonEtudiant_Click(object sender, EventArgs e)
        {

           
        }

        private void iconButtonDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            declarerAbsence declarer = new declarerAbsence(e_idEtudiant);
            declarer.ShowDialog();
            hideSubMenu();
            
        }

        private void iconButtonDeconnexion_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("vous êtes sur le point de changer votre photo de profil", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                openDialog();
                if (imageFilName != "")
                {
                    byte[] tabling = convertImage(imageFilName);
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString()))
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("update ETUDIANT set image=@img where idEtudiant=" + this.e_idEtudiant+ "", con);
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@img", tabling));
                        cmd.ExecuteNonQuery();
                        
                        gunaPictureBox1.Image = Image.FromFile(imageFilName);


                    }
                }
            }
        }
        private void openDialog()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg" })
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    gunaPictureBox1.Image = Image.FromFile(ofd.FileName);
                    imageFilName = ofd.FileName;
                }
            }
        }
        private byte[] convertImage(String chemin)
        {
            gunaPictureBox1.Image.Dispose();
            byte[] tabling = null;
            try
            {
                FileStream fs = new FileStream(chemin, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                tabling = br.ReadBytes((int)fs.Length);
                fs.Close();
                return tabling;
            }
            catch
            {
                MessageBox.Show("OUVERTURE DE FICHIER ECHOUÉE");
                return tabling;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            activeForm.Hide();
        }
    }
}
