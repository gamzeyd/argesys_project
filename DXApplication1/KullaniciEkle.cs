using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class KullaniciEkle : DevExpress.XtraEditors.XtraForm
    {
        private SqlCommand cmd;
        private SqlDataReader dr;

        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {

            if (EmailTxtEdit.Text == "")
            {
                MessageBox.Show("Email Adresi Giriniz!");
            }
            else

            {
                if (ParolaTxtEdit.Text == "")

                {
                    MessageBox.Show("Parola Giriniz!");
                }
                else
                {
                    SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=argesys;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    cn.Open();

                    try
                    {
                        cmd = new SqlCommand("select * from Users where username='" + EmailTxtEdit.Text + "'", cn);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("This account has been register!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            dr.Close();

                        }
                        else
                        {
                            dr.Close();
                            string kayit = "insert into Users(username,password) values (@username,@password)";
                            SqlCommand komut = new SqlCommand(kayit, cn);

                            komut.Parameters.AddWithValue("@username", EmailTxtEdit.Text);
                            komut.Parameters.AddWithValue("@password", ParolaTxtEdit.Text);

                            komut.ExecuteNonQuery();

                            MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
                        }


                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);

                    }
                    finally
                    {
                        cn.Close();
                    
                    }
                }

            }
        }
    }
}