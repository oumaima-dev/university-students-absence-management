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
    public partial class EtudiantJustifierUserControl : UserControl
    {
      
        String imageFileName = "";
        private void openDialog()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    guna2PictureBox1.Image = Image.FromFile(ofd.FileName);

                    imageFileName = ofd.FileName;
                }
            }
        }
        public EtudiantJustifierUserControl(string module, string date, int heureDebut, int heureFin,bool etat ,int id)
        {
            InitializeComponent();

            gunaLabel1.Text = module;
            gunaLabel2.Text = date;
            if (etat == true) {
               
                gunaLabel4.Text = "Justifié";
                    }
            else
            {
                gunaLabel4.ForeColor = Color.Red;
                gunaLabel4.Text = "Non Justifié";
            }
            gunaLabel3.Text = "" + heureDebut.ToString() + "H À " + heureFin.ToString() + "H";
            idlabel.Text = id.ToString();
            layoutpanel.Visible = false;
            panelhs.Visible = false;
            this.Size = new System.Drawing.Size(440, 42);


        }
        static bool change = false;

        void remplir_champs()
        {
            int id = Int32.Parse(idlabel.Text);
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString()))
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


        public EtudiantJustifierUserControl()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

            if (layoutpanel.Visible == false)
            {
                layoutpanel.Visible = true;
            }
            else
            {
                layoutpanel.Visible = false;
            }
            
        }
        ComponentResourceManager resources = new ComponentResourceManager(typeof(EtudiantJustifierUserControl));
        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            if (panelhs.Visible == false)
            {
                remplir_champs();//si on rempli les champs alors la variable CHANGE se change!
                if (gunaLabel4.Text == "Justifié")
                {
                    panelhs.Enabled = false;
                }
                else
                {
                    panelhs.Enabled = true;
                }
                panelhs.Visible = true;
                this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.InitialImage")));
                
                this.Size = new System.Drawing.Size(640, 220);

            }
            else
            {
                panelhs.Visible = false;
                this.Size = new System.Drawing.Size(640, 55);
                this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
             
             
             
                

            }
        }
            void update_absence(int idAbsence, String justification = "")
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString());

                try
                {

                    connection.Open();
                    SqlCommand command1 = connection.CreateCommand();
                    command1.CommandType = CommandType.Text;
                if (imageFileName != "")
                {
                    byte[] tabling = convertImage(imageFileName);
                    command1.CommandText = "update ABSENCE set justification='" + justification + "' , certificat=@certificat  where idAbsence=" + idAbsence + " ";
                    command1.Parameters.Clear();
                    command1.Parameters.Add(new SqlParameter("@certificat", tabling));
                }
                else
                {
                    command1.CommandText = "update ABSENCE set justification='" + justification + "' , certificat=NULL where idAbsence=" + idAbsence + " ";
                }
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Modification réussie");

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
            private byte[] convertImage(String chemin)
            {
                guna2PictureBox1.Image.Dispose();
                byte[] tabling = null;
                FileStream fs = new FileStream(chemin, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                tabling = br.ReadBytes((int)fs.Length);
                fs.Close();
                return tabling;
            }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            openDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Enregistrer les modification", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                update_absence(Int32.Parse(idlabel.Text), guna2TextBox1.Text);
                
            }
        }
    }
    }

