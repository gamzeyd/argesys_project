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
    public partial class ArizaTipleri : DevExpress.XtraEditors.XtraForm
    {
        private IFaultService _faultService;
        public ArizaTipleri()
        {
            InitializeComponent();
            _faultService = new FaultManager(new EfFaultDal());
        }

        private void ArizaTipleri_Load(object sender, EventArgs e)
        {
            LoadFaults();
        }

        private void LoadFaults()
        {
            gridControl1.DataSource = _faultService.GetAll();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _faultService.Update(new Fault
            {
                FaultId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("FaultId")),
                FaultName = (ArizaTxtEdit.Text)
            });

            LoadFaults();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _faultService.Add(new Fault
            {
                FaultName = (ArizaTxtEdit.Text)
            });

            LoadFaults();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _faultService.Delete(new Fault
            {
                FaultId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("FaultId")),

            });

            LoadFaults();
        }
    }
}