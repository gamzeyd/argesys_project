﻿using Argesys.Business.Abstract;
using Argesys.Business.Concrete;
using Argesys.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Argesys.WinUI.Forms
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
           _productService  = new ProductManager(new EfProductDal());
        }
      private IProductService _productService;

        EfCategoryDal categoryDal = new EfCategoryDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = categoryDal.GetAll();

        }
    }
}
                                      