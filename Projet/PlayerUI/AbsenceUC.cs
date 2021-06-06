using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
namespace PlayerUI
{
    public partial class AbsenceUC : UserControl
    {
        public AbsenceUC(string nomcomplet,string module, string date, int heureDebut, int heureFin, int id)
        {
            InitializeComponent();
            gunaLabel1.Text = module;
            gunaLabel2.Text = date;
            nomlabel.Text = nomcomplet;
            gunaLabel3.Text = "" + heureDebut.ToString() + "H À " + heureFin.ToString() + "H";
            idlabel.Text = id.ToString().Trim() ;
            panelhs.Visible = false;
            this.Size = new System.Drawing.Size(470, 42);
            remplir_champs();

        }
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {//refuser la demande de justification => rendre les 2champs certificat et justification null;
            
            //this.Visible = false;
            if (DialogResult.Yes == MessageBox.Show("Voulez-vous vraiment refuser cette justification ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                RefuserAbsence(Int32.Parse(idlabel.Text));
                gunaLabel4.Text = "Refusé";
                gunaLabel4.ForeColor = Color.Red;
            }
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            //si l'admin accepte la justification alors l'état = true
            if (DialogResult.Yes == MessageBox.Show("Voulez-vous vraiment accepter cette justification ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                AccepterAbsence(Int32.Parse(idlabel.Text));
                gunaLabel4.Text = "Accepté";
                gunaLabel4.ForeColor = Color.Green;
            }

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            //telecharger la certificat medical 
            if(DialogResult.Yes==MessageBox.Show("Voulez vous télécharger cette image ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var savefileDialoge = new SaveFileDialog();
                savefileDialoge.FileName = "Certificat";
                savefileDialoge.DefaultExt = ".Jpeg";
                savefileDialoge.Filter = "JPEG|*.jpg";
                if (savefileDialoge.ShowDialog() == DialogResult.OK)
                {
                    guna2PictureBox1.Image.Save(savefileDialoge.FileName, ImageFormat.Jpeg);
                }
            }
           
        }
        void remplir_champs()
        {
            int id = Int32.Parse(idlabel.Text);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ABSENCE where idAbsence=" + id + "", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                idlabel.Text = reader.GetInt32(0).ToString();
                if (!reader.IsDBNull(4))
                {
                    guna2TextBox1.Text = reader.GetString(4);
                }
                if (!reader.IsDBNull(5))
                {
                    byte[] output = (byte[])reader[5];
                    using (MemoryStream ms = new MemoryStream(output))
                    {
                        Bitmap img = new Bitmap(ms);
                        guna2PictureBox1.Image = img;
                    }
                }
            }
        }
        void AccepterAbsence(int id)
        {
            using(SqlConnection con=new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ABSENCE SET etat='" + true + "'  where idAbsence=" + id+"",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vous avez accepté une demande de justification d'absence");
            }
        }
        void RefuserAbsence(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ABSENCE SET etat='" + false + "'  , certificat=null,justification=null  where idAbsence=" + id + "", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vous avez refusé une demande de justification d'absence");

            }
        }

        private void gunaShadowPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void gunaShadowPanel2_Click(object sender, EventArgs e)
        {
            if(panelhs.Visible == false)
            {
                panelhs.Visible = true;
                this.Size = new System.Drawing.Size(640, 220);
            }
            else
            {
                panelhs.Visible = false;
                this.Size = new System.Drawing.Size(640, 55);
            }
        }

        private void panelhs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbsenceUC_Load(object sender, EventArgs e)
        {

        }
    }
}
