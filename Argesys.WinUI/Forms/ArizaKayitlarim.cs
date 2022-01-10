using Argesys.Business.Abstract;
using Argesys.Business.Concrete;
using Argesys.DataAccess.Concrete.EntityFramework;
using Argesys.Entities.Concrete;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argesys.WinUI.Forms
{
    public partial class ArizaKayitlarim : DevExpress.XtraEditors.XtraForm
    {
        private IFaultRecordService _faultRecordService;
        private ICompanyService _companyRecords;

        public ArizaKayitlarim()
        {
            InitializeComponent();
            _faultRecordService = new FaultRecordManager(new EfFaultRecordDal());
            _companyRecords = new CompanyManager(new EfCompanyDal());
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void ArizaKayitlarim_Load(object sender, EventArgs e)
        {
           // LoadFaultRecords();
            LoadFirmalar();
            GetFault();
        }

        private void LoadFaultRecords()
        {
            gridControl1.DataSource = _faultRecordService.GetAll();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //_faultRecordService.Update(new FaultRecord
            //{
            //   // FaultRecordId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("FaultRecordId")),
            //    //BrandName = (MarkaTxtEdit.Text)
            //});

            //LoadFaultRecords();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _faultRecordService.Delete(new FaultRecord
            {
                FaultRecordId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("FaultRecordId")),

            });

            LoadFaultRecords();
        }

        private void LoadFirmalar()
        {


            companyLookUpEdit.Properties.DataSource = _companyRecords.GetAll();
            companyLookUpEdit.Properties.DisplayMember = "CompanyName";
            companyLookUpEdit.Properties.ValueMember = "CompanyId";
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //gridControl1.DataSource = _faultRecordService.GetRecordsByCompany(companyTxtEdit.Text);
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (stationTxtEdit.Text == "")
            {
                LoadFaultRecords();

            }
            else
            {
                gridControl1.DataSource = _faultRecordService.GetRecordsByStationName(stationTxtEdit.Text);
            }
        }

        private void contactTxtEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (contactTxtEdit.Text == "")
            {
                LoadFaultRecords();

            }
            else
            {
                gridControl1.DataSource = _faultRecordService.GetRecordsByStationName(contactTxtEdit.Text);
            }
        }


        public void GetFault () 
        {
            List<JoinFaultCompany> jc = new List<JoinFaultCompany>();
            string mainconn = ConfigurationManager.ConnectionStrings["ArgesysContext"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            // string sqlquery = "Select f.AdvertisingFirmId,c.CompanyName FROM FaultRecords f inner join Companies c on f.AdvertisingFirmId = c.CompanyId";
            string sqlquery = "Select AdvertisingFirmId, CompanyName, FaultDate, BrandName, ContactName, Address,Province, ";
            sqlquery += "District,FaultDescription, StationNames from";
            sqlquery += " (Select AdvertisingFirmId, CompanyName, FaultDate, BrandId, t1.ContactId, co.ContactName, Address,";
            sqlquery += " District,Province, FaultDescription, StationNames from (Select f.AdvertisingFirmId, c.CompanyName, f.FaultDate, f.BrandId, f.ContactId, f.Address,";
            sqlquery += " f.District,f.Province, f.FaultDescription, f.StationNames FROM FaultRecords f";
            sqlquery += " inner join Companies c on f.AdvertisingFirmId = c.CompanyId) t1";
            sqlquery += " inner join Contacts co on t1.ContactId = co.ContactId) t2";
            sqlquery += " inner join Brands br on t2.BrandId = br.BrandId"; 
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                JoinFaultCompany jcobj = new JoinFaultCompany();
                
                jcobj.FaultId = dr["AdvertisingFirmId"].ToString();
                jcobj.CompanyName = dr["CompanyName"].ToString();
                jcobj.FaultDate = dr["FaultDate"].ToString();
                jcobj.BrandName = dr["BrandName"].ToString();
                jcobj.ContactName = dr["ContactName"].ToString();
                jcobj.Address = dr["Address"].ToString();
                jcobj.Province = dr["Province"].ToString();
                jcobj.District = dr["District"].ToString();
                jcobj.FaultDescription = dr["FaultDescription"].ToString();
                jcobj.StationNames = dr["StationNames"].ToString();





                jc.Add(jcobj);



            }
            gridControl1.DataSource = jc;
            

        }

       
    }
}