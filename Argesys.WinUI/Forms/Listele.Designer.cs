
namespace Argesys.WinUI.Forms
{
    partial class Listele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Firmasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Islemler = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(465, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ara";
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(507, 12);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(125, 22);
            this.searchControl1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(685, 355);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.KullaniciAdi,
            this.Firmasi,
            this.Tel,
            this.Email,
            this.Islemler});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "#";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.Caption = "Kullanıcı Adı";
            this.KullaniciAdi.MinWidth = 25;
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Visible = true;
            this.KullaniciAdi.VisibleIndex = 1;
            this.KullaniciAdi.Width = 94;
            // 
            // Firmasi
            // 
            this.Firmasi.Caption = "Firması";
            this.Firmasi.MinWidth = 25;
            this.Firmasi.Name = "Firmasi";
            this.Firmasi.Visible = true;
            this.Firmasi.VisibleIndex = 2;
            this.Firmasi.Width = 94;
            // 
            // Tel
            // 
            this.Tel.Caption = "Tel";
            this.Tel.MinWidth = 25;
            this.Tel.Name = "Tel";
            this.Tel.Visible = true;
            this.Tel.VisibleIndex = 3;
            this.Tel.Width = 94;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.MinWidth = 25;
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 4;
            this.Email.Width = 94;
            // 
            // Islemler
            // 
            this.Islemler.Caption = "İşlemler";
            this.Islemler.MinWidth = 25;
            this.Islemler.Name = "Islemler";
            this.Islemler.Visible = true;
            this.Islemler.VisibleIndex = 5;
            this.Islemler.Width = 94;
            // 
            // Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 440);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "Listele";
            this.Text = "Listele";
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn KullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Firmasi;
        private DevExpress.XtraGrid.Columns.GridColumn Tel;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Islemler;
    }
}