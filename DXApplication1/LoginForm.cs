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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private SqlCommand cmd;

        public SqlDataReader dr { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Giriniz!");


            }

            else 
            {
                if (textEdit2.Text == "")
                {
                    MessageBox.Show("Şifrenizi Giriniz!");
                }

                else 
                {
                    SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=argesys;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    
                    if (cn.State == ConnectionState.Open) 
                    {
                        cn.Close();
                    }
                    cn.Open();

                    try
                    {
                        cmd = new SqlCommand("select * from Users where username='" + textEdit1.Text + "' and password='" + textEdit2.Text + "'", cn);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            this.Hide();
                            Form1 home = new Form1();
                            home.ShowDialog();
                        }
                        else
                        {
                            dr.Close();
                            MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                  
                }

            }
                
        }
    }
}