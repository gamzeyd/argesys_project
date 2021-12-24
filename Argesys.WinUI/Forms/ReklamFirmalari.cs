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
    public partial class ReklamFirmalari : DevExpress.XtraEditors.XtraForm
    {
        private ICompanyService _companyService;

        public ReklamFirmalari()
        {
            InitializeComponent();
            _companyService = new CompanyManager(new EfCompanyDal());

        }

        private void ReklamFirmalari_Load(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            gridControl1.DataSource = _companyService.GetAll();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _companyService.Add(new Company
            {
                CompanyName = (FirmaTxtEdit1.Text)
            });

            LoadCompanies();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _companyService.Update(new Company
            {
                CompanyId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CompanyId")),
                CompanyName = (FirmaTxtEdit1.Text)
            });

            LoadCompanies();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _companyService.Delete(new Company
            {
                CompanyId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CompanyId")),

            });

            LoadCompanies();
        }
    }
}