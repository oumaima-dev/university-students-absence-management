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
    public partial class ProfilAUC : UserControl
    {
        public ProfilAUC(string email, Bitmap img, int id)
        {
            InitializeComponent();
            gunaCirclePictureBox2.Image = img;
            emailbox.Text = email;
            
            idlabel.Text = id.ToString();
            
        }
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProfilAUC_Load(object sender, EventArgs e)
        {

        }

        private void iconButtonModifierAdmin_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Vous voullez supprimer ce compte ", "confirmation", MessageBoxButtons.YesNo)) return;
            delete_user();
            this.Visible = false;
        }
        void delete_user()
        {
            int id = Int32.Parse(idlabel.Text);
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ADMIN where idAdmin=" + id + "", con);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
