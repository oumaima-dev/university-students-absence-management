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
    public partial class Professeur : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        public Professeur(int idp)
        {
            InitializeComponent();
            hideSubMenu();
            idCompte = idp;
            initpanel(idCompte);
        }
        String imageFilName = "";

        int idCompte { get; set; }
        private void hideSubMenu()
        {
            panelGérerEtud.Visible = false;
            panelGérerAbs.Visible = false;
            gunaPanel1.Visible = false;
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

        private void iconButtonModifierAdmin_Click(object sender, EventArgs e)
        {
            UserControl modifierCompte = new ModifierComptePROF(gunaLineTextBox1.Text);
            openChildForm(modifierCompte);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButtonDeconnexion_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form1 form = new Form1();
            this.Close();
            form.ShowDialog();
           
        }


        private void iconButtonAjoutEtudi_Click(object sender, EventArgs e)
        {
            UserControl ajouterEtud = new AjouterEtudiantUserControl();
            openChildForm(ajouterEtud);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButtonAjoutFiliere_Click(object sender, EventArgs e)
        {
            UserControl expEtud = new ExporterListeEtudiantPROF(idCompte);//idcompte=idprof
            openChildForm(expEtud);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButtonConsulterEtud_Click(object sender, EventArgs e)
        {
            Form import = new ImportEtudiantByFiliere();
            import.ShowDialog();
            hideSubMenu();
            gunaPanel1.BringToFront();
        }


        private void iconButtonAdmin_Click_1(object sender, EventArgs e)
        {
            showSubMenu(gunaPanel1);
            gunaPanel1.BringToFront();
        }

        private void iconButtonConsuAbs_Click_1(object sender, EventArgs e)
        {
            UserControl consulterAbs = new ConsulterAbscencePROF(gunaLineTextBox1.Text);
            openChildForm(consulterAbs);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void iconButtonAjoutAbs_Click_1(object sender, EventArgs e)
        {
            UserControl ajouterAbs = new AjoutAbsencePROF(gunaLineTextBox1.Text);
            openChildForm(ajouterAbs);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        void initpanel(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from PROFESSEUR,COMPTE where PROFESSEUR.idCompte=COMPTE.idCompte and PROFESSEUR.idProfesseur=" + id + "", con);
                SqlDataReader rd = cmd.ExecuteReader(); rd.Read();
                gunaLineTextBox1.Text = rd.GetString(11);
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

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            JustificationEncoursUC_PROF uc= new JustificationEncoursUC_PROF(idCompte);
            openChildForm(uc);
            hideSubMenu();
            gunaPanel1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {
            openDialog();
            if (imageFilName != "")
            {
                byte[] tabling = convertImage(imageFilName);
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("update PROFESSEUR set image=@img where idProfesseur=" + this.idCompte + "", con);

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
