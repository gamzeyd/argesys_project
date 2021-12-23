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

namespace Argesys.WinUI.Forms
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




            if (AdSoyadTxtEdit.Text == "")
            {
                MessageBox.Show("Ad ve soyad giriniz");
            }
            else

            {
                if (FirmaComboxEdit.Text == "")

                {
                    MessageBox.Show("Firma Giriniz!");
                }
                else
                {


                    if (MarkaComboxEdit.Text == "")
                    {
                        MessageBox.Show("Marka Giriniz!");
                    }
                    else

                    {
                        if (TelNoTxtEdit.Text == "")

                        {
                            MessageBox.Show("Telefon Numarası Giriniz!");
                        }
                        else
                        {
                            if (BilgiEmailTxtEdit1.Text == "")
                            {
                                MessageBox.Show("1. Bilgi Giriniz");
                            }
                            else

                            {
                                if (BilgiEmailTxtEdit2.Text == "")

                                {
                                    MessageBox.Show("2. Bilgi Giriniz!");
                                }
                                else
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
                                                cmd = new SqlCommand("select * from User where email='" + EmailTxtEdit.Text + "'", cn);
                                                dr = cmd.ExecuteReader();
                                                if (dr.Read())
                                                {
                                                    MessageBox.Show("This account has been register!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                                                    dr.Close();

                                                }
                                                else
                                                {
                                                    dr.Close();
                                                    string kayit = "insert into User(Name,Password,Email,Company,Brand,InformationMail1,InformationMail2,Phone,Picture) values (@Name,@Password,@Email,@Company,@Brand,@InformationMail1,@InformationMail2,@Phone,@Picture)";
                                                    SqlCommand komut = new SqlCommand(kayit, cn);

                                                    komut.Parameters.AddWithValue("@name", AdSoyadTxtEdit.Text);
                                                    komut.Parameters.AddWithValue("@password", ParolaTxtEdit.Text);
                                                    komut.Parameters.AddWithValue("@Email", EmailTxtEdit.Text);
                                                    komut.Parameters.AddWithValue("@Company", FirmaComboxEdit.Text);
                                                    komut.Parameters.AddWithValue("@Brand", MarkaComboxEdit.Text);
                                                    komut.Parameters.AddWithValue("@Information1", BilgiEmailTxtEdit1);
                                                    komut.Parameters.AddWithValue("@Information2", BilgiEmailTxtEdit2);
                                                    komut.Parameters.AddWithValue("@Phone", TelNoTxtEdit.Text);
                                                    komut.Parameters.AddWithValue("@Picture", ResimEdit1.Text);


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
                    }
                }
            }
        }
    }
}