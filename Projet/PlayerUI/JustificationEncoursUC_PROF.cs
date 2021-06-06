using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PlayerUI
{
    public partial class JustificationEncoursUC_PROF : UserControl
    {
        public JustificationEncoursUC_PROF(int idp)
        {
            InitializeComponent();
            idprof = idp;
            fill_module();
            layoutpanel.Visible = true;
            fill_demande_module();
            

        }
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        private int idprof { get; set; }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //afficher les demandes de justification par module 
            int module = (guna2ComboBox1.SelectedItem as dynamic).value;
            if (module == 0) { fill_alldemande(); return; }
            fill_demande_module(module);
        }
        void fill_alldemande()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                layoutpanel.Controls.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ABSENCE,MODULE,ETUDIANT,AFFECTATION WHERE ABSENCE.idEtudiant=ETUDIANT.idEtudiant and   ABSENCE.idModule=MODULE.idModule " +
                "   and AFFECTATION.module=MODULE.idModule and AFFECTATION.idProfesseur="+idprof+ "  AND etat='" + false + "'  AND (ABSENCE.certificat IS NOT NULL OR ABSENCE.justification IS NOT NULL)", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nomcomplet = reader.GetString(17).Trim() + " " + reader.GetString(16).Trim();
                    AbsenceUC uc = new AbsenceUC(nomcomplet, reader.GetString(12), reader.GetDateTime(10).ToString("yyyy-MM-dd"), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(0));
                    layoutpanel.Controls.Add(uc);
                }

            }
        }
        public void fill_module()
        {
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.Add(new { Text = "Tout", value = 0 });
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from MODULE,AFFECTATION where MODULE.idModule=AFFECTATION.module and AFFECTATION.idProfesseur="+this.idprof+"  ", con);
                SqlDataReader reader = cmd.ExecuteReader();
                guna2ComboBox1.DisplayMember = "Text";
                guna2ComboBox1.ValueMember = "value";
                while (reader.Read())
                {
                    guna2ComboBox1.Items.Add(new { Text = reader.GetString(1), value = reader.GetInt32(0) });
                }
            }
            guna2ComboBox1.SelectedIndex = 0;
        }
        public void fill_demande_module(int module = 0)
        {
            if (module == 0) { fill_alldemande(); return; }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                layoutpanel.Controls.Clear();
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from ABSENCE,MODULE,ETUDIANT WHERE ABSENCE.idEtudiant=ETUDIANT.idEtudiant and   ABSENCE.idModule=MODULE.idModule " +
                    "                 and ABSENCE.idProfesseur="+this.idprof+"   and ABSENCE.idModule=" + module + " AND etat='" + false + "'  AND (ABSENCE.certificat IS NOT NULL OR ABSENCE.justification IS NOT NULL)", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nomcomplet = reader.GetString(17).Trim() + " " + reader.GetString(16).Trim();
                    AbsenceUC uc = new AbsenceUC(nomcomplet, reader.GetString(12), reader.GetDateTime(10).ToString("yyyy-MM-dd"), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(0));
                    layoutpanel.Controls.Add(uc);
                }
            }
        }
        private void guna2RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            fill_alldemande();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            fill_alldemande();
            guna2ComboBox1.SelectedIndex = 0;
        }

        private void layoutpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
