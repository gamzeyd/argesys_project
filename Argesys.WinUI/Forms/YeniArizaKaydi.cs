using Argesys.Business.Abstract;
using Argesys.Business.Concrete;
using Argesys.DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argesys.WinUI.Forms
{
    public partial class YeniArizaKaydi : DevExpress.XtraEditors.XtraForm
    {
        private ICompanyService _companyRecords;
        private IContactService _contactRecords;
        private IBrandService _brandRecords;
        public YeniArizaKaydi()
        {
            InitializeComponent();
            _companyRecords = new CompanyManager(new EfCompanyDal());
            _contactRecords = new Business.Concrete.ContactManager(new EfContactDal());
            _brandRecords = new BrandManager(new EfBrandDal());
        }

        private void YeniArizaKaydi_Load(object sender, EventArgs e)
        {
            companyLookUpEdit.Properties.DataSource = _companyRecords.GetAll();
            companyLookUpEdit.Properties.DisplayMember = "CompanyName";
            companyLookUpEdit.Properties.ValueMember = "CompanyId";

            contactLookUpEdit.Properties.DataSource = _contactRecords.GetAll();
            contactLookUpEdit.Properties.DisplayMember = "ContactName";
            contactLookUpEdit.Properties.ValueMember = "ContactId";

            brandLookUpEdit.Properties.DataSource = _brandRecords.GetAll();
            brandLookUpEdit.Properties.DisplayMember = "BrandName";
            brandLookUpEdit.Properties.ValueMember = "BrandId";
        }
    }
}