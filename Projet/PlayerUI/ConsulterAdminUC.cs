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
    public partial class ConsulterAdminUC : UserControl
    {
        public ConsulterAdminUC()
        {
            InitializeComponent();fill_admin();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        private void ConsulterAdminUC_Load(object sender, EventArgs e)
        {

        }
        void fill_admin()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                layoutpanel.Controls.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ADMIN ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Bitmap img = null;
                    if (!reader.IsDBNull(7))
                    {
                        byte[] output = (byte[])reader[7];
                        using (MemoryStream ms = new MemoryStream(output))
                        {
                            img = new Bitmap(ms);
                            
                        }
                    }
                    ProfilAUC uc = new ProfilAUC(reader.GetString(3).Trim() + " " + reader.GetString(2).Trim(), img, reader.GetInt32(0));
                    layoutpanel.Controls.Add(uc);

                }

            }
        }
    }
}
