using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Administrateur : Form
    {
        public Administrateur(int idu)
        {
            InitializeComponent();
            hideSubMenu();
            initpanel(idu);
            idcompte = idu;
        }
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        public int idcompte { get; set; }
        private void hideSubMenu()
        {
            panelGérerEtud.Visible = false;
            panelGérerAbs.Visible = false;
            panelGérerCompte.Visible = false;
            panelGererprof.Visible = false;
            gunaPanel1.Visible = false;
            iconButton11.Visible = false;
            iconButton10.Visible = false;
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

        #region MediaSubMenu


        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion


        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        private void panelGérerAbs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGérerAbs);
            gunaPanel1.BringToFront();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGérerEtud);
            gunaPanel1.BringToFront();
        }


        private void iconButton9_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGérerCompte);
            gunaPanel1.BringToFront();
        }


        private void iconButtonAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(gunaPanel1);
            gunaPanel1.BringToFront();
        }

        private void iconButtonModifierAdmin_Click(object sender, EventArgs e)
        {
            ModifierPass a = new ModifierPass(this.idcompte, gunaLineTextBox1.Text.Trim());//idcompte,login
            a.ShowDialog();
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButtonDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            
            form.ShowDialog();
            //gunaPanel1.BringToFront();
        }

        private void iconButtonConsuAbs_Click(object sender, EventArgs e)
        {
            UserControl ab = new ConsulterAbscence();
            openChildForm(ab);
            hideSubMenu();
            gunaPanel1.BringToFront();

        }

        private void iconButtonAjoutAbs_Click(object sender, EventArgs e)
        {
            UserControl a = new AjoutAbsence();
            openChildForm(a);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButtonAjoutEtudi_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            gunaPanel1.BringToFront();
            UserControl etd = new AjouterEtudiantUserControl();
            openChildForm(etd);
        }

        private void iconButtonAjoutFiliere_Click(object sender, EventArgs e)
        {
            AjoutFiliereForm f = new AjoutFiliereForm();
            f.ShowDialog();
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButtonConsulterEtud_Click(object sender, EventArgs e)
        {
            UserControl ConsulterEtudiant = new ConsulterEtudiantUserControl();
            openChildForm(ConsulterEtudiant);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButtonAjoutCompteAdmin_Click(object sender, EventArgs e)
        {
            UserControl admin=new adminUserControl();
            openChildForm(admin);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButtonAjoutCompteProf_Click(object sender, EventArgs e)
        {
            // openChildForm(new GérerCompteProf());
            UserControl prof = new profUserControl();
            openChildForm(prof);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButtonAjoutCompteEtudiant_Click(object sender, EventArgs e)
        {
            // openChildForm(new GérerCompteEtudiant());
            UserControl etudiant = new etudiantUserControl();
            openChildForm(etudiant);
            hideSubMenu();
            gunaPanel1.BringToFront();

        }

        private void iconButtonAdmin_Click_1(object sender, EventArgs e)
        {
            showSubMenu(gunaPanel1);
            gunaPanel1.BringToFront();
        }

        private void Administrateur_Load(object sender, EventArgs e)
        {

        }
        void initpanel(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ADMIN,COMPTE where ADMIN.idCompte=COMPTE.idCompte and idAdmin=" + id + "", con);
                SqlDataReader rd = cmd.ExecuteReader(); rd.Read();
                gunaLineTextBox1.Text = rd.GetString(10);
                iconButtonAdmin.Text = rd.GetString(2) + " " + rd.GetString(3);
                if (!rd.IsDBNull(7))
                {
                    byte[] output = (byte[])rd[7];
                    using (MemoryStream ms = new MemoryStream(output))
                    {
                        Bitmap img = new Bitmap(ms);
                        gunaPictureBox1.Image = img;
                    }
                }

            }
        }

        // Ajouter un Module
        private void iconButton4_Click(object sender, EventArgs e)
        {
            AjouterModule a = new AjouterModule();
            a.ShowDialog();
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        // Ajouter un Professeur
        private void iconButton3_Click(object sender, EventArgs e)
        {
            UserControl prof = new AjouterProfUserControl();
            openChildForm(prof);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        // Affectation d'un prof a un module
        private void iconButton2_Click(object sender, EventArgs e)
        {
            Affectation af = new Affectation();
            af.ShowDialog();
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        // consulter Professeur
        private void iconButton6_Click(object sender, EventArgs e)
        {
            UserControl ConsulterProf = new ConsulterprofUC();
            openChildForm(ConsulterProf);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGererprof);
            gunaPanel1.BringToFront();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            UserControl admin = new AjouterAdminUserControl();
            openChildForm(admin);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            if (iconButton10.Visible == false)
            {
                iconButton11.Visible = true;
                iconButton10.Visible = true;
            }
            else
            {
                hideSubMenu();
            }
            gunaPanel1.BringToFront();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            UserControl admin = new ConsulterAdminUC();
            openChildForm(admin);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            JustificationEncoursUC uc = new JustificationEncoursUC();
            openChildForm(uc);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }
        String imageFilName = "";

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {
            openDialog();
            if (imageFilName != "") 
            {
                byte[] tabling = convertImage(imageFilName);
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("update ADMIN set image=@img where idAdmin=" + this.idcompte + "", con);
                        
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@img", tabling));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mise à jour photo de profil...");
                    gunaPictureBox1.Image = Image.FromFile(imageFilName);


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
