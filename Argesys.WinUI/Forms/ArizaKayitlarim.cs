using Argesys.Business.Abstract;
using Argesys.Business.Concrete;
using Argesys.DataAccess.Concrete.EntityFramework;
using Argesys.Entities.Concrete;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public ArizaKayitlarim()
        {
            InitializeComponent();
            _faultRecordService = new FaultRecordManager(new EfFaultRecordDal());
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void ArizaKayitlarim_Load(object sender, EventArgs e)
        {
            LoadFaultRecords();
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

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = _faultRecordService.GetRecordsByCompany(companyTxtEdit.Text);
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = _faultRecordService.GetRecordsByStationName(stationTxtEdit.Text);
        }
    }
}