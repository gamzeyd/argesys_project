using Argesys.Business.Abstract;
using Argesys.Business.Concrete;
using Argesys.DataAccess.Concrete.EntityFramework;
using Argesys.Entities.Concrete;
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
    public partial class Markalar : DevExpress.XtraEditors.XtraForm
    {

        private IBrandService _brandService;
        public Markalar()
        {
            InitializeComponent();
            _brandService = new BrandManager(new EfBrandDal());
        }

       

        private void Markalar_Load(object sender, EventArgs e)
        {
            LoadBrands();
        }

        private void LoadBrands()
        {
            gridControl1.DataSource = _brandService.GetAll();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _brandService.Add(new Brand
            {
                BrandName = (MarkaTxtEdit.Text)
            });

            LoadBrands();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _brandService.Update(new Brand
            {
                BrandId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("BrandId")),
                BrandName = (MarkaTxtEdit.Text)
            }) ;

            LoadBrands();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
                 _brandService.Delete(new Brand
                 {
                     BrandId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("BrandId")),
                    
                 });

            LoadBrands();
        }
    }
}
