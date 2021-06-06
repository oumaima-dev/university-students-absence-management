using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class declarerAbsence : Form
    {
        public declarerAbsence(int idetud)
        {
            InitializeComponent();
            imageFileName = null;
            idetudiant = idetud;
            fill_module(idetud);
        }

        public string imageFileName { get; set; }
        public int idetudiant { get; set; }
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        private void declarerAbsence_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openDialog();
        }

        void sendmail(string emetteur, string to, string body, string img = null)
        {
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {

                client.Credentials = new NetworkCredential("gestionabsenceapp@gmail.com", "absenceapp2020");
                client.EnableSsl = true;
                MailMessage msg = new MailMessage("noreply@gmail.com", to, "NOTICE D'ABSENCE DE L'ETUDIANT " + emetteur, body);
                msg.IsBodyHtml = false;
                if (img != null)
                {
                    var attachment = new Attachment(img, MediaTypeNames.Image.Jpeg);
                    msg.Attachments.Add(attachment);
                }
                client.Send(msg);
                MessageBox.Show("Vous avez declarer une absence avant le temps du module "+ComboBoxModule.Text, "",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void openDialog()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg" })
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    imageFileName = ofd.FileName;
                }
            }
        }
        void fill_module(int ide)
        {
            ComboBoxModule.Items.Clear();
            ComboBoxModule.Items.Add(new { Text = "Choisir un module...", value = 0 });
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Module,MODULELISTE,FILIERE,ETUDIANT where ETUDIANT.idEtudiant=" + ide + " AND ETUDIANT.idFiliere=FILIERE.idFiliere and FILIERE.idFiliere=MODULELISTE.idFiliere AND MODULE.idModule=MODULELISTE.idModule ", con);
                SqlDataReader reader = cmd.ExecuteReader();
                ComboBoxModule.DisplayMember = "Text";
                ComboBoxModule.ValueMember = "value";
                while (reader.Read())
                {

                    ComboBoxModule.Items.Add(new { Text = reader.GetString(1), value = reader.GetInt32(0) });

                }

            }
            ComboBoxModule.SelectedIndex = 0;
        }

        private void ComboBoxModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            string email = getEmail((ComboBoxModule.SelectedItem as dynamic).value);
            emailbox.Text = email;
        }
        string getEmail(int idmodule)
        {
            if (idmodule != 0)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from PROFESSEUR,AFFECTATION where PROFESSEUR.idProfesseur=AFFECTATION.idProfesseur and module=" + idmodule + "", con);
                    SqlDataReader reader = cmd.ExecuteReader(); reader.Read();
                    return reader.GetString(5);
                }
            }
            else return null;

        }
        string getnomcmplt(int iduser)
        {
            if (iduser != 0)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from ETUDIANT,FILIERE where ETUDIANT.idFiliere=FILIERE.idFiliere and  idEtudiant=" + iduser + " ", con);
                    SqlDataReader reader = cmd.ExecuteReader(); reader.Read();
                    return reader.GetString(4) + " " + reader.GetString(3)+"("+reader.GetString(13) +")";
                }
            }
            else return null;

        }
        private void emailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaGradientButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (imageFileName == null)
                sendmail(getnomcmplt(idetudiant), emailbox.Text.Trim(), msgbox.Text.Trim());
            else
                sendmail(getnomcmplt(idetudiant), emailbox.Text.Trim(), msgbox.Text.Trim(), imageFileName);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var savefileDialoge = new SaveFileDialog();
            savefileDialoge.FileName = "Certificat";
            savefileDialoge.DefaultExt = ".Jpeg";
            savefileDialoge.Filter = "JPEG|*.jpg";
            if (savefileDialoge.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(savefileDialoge.FileName, ImageFormat.Jpeg);

            }
        }
    }
}
