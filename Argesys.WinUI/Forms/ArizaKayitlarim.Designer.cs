
namespace Argesys.WinUI.Forms
{
    partial class ArizaKayitlarim
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
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ReklamFirmasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ArizaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IstasyonIsmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.İletisimYetkilisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KurumsalMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Il = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ilce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklamasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Resim1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Resim2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Resim3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Durumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Islemler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Garanti = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(795, 74);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(125, 22);
            this.searchControl1.TabIndex = 62;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(764, 77);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(25, 16);
            this.labelControl19.TabIndex = 61;
            this.labelControl19.Text = "Ara:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 231);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(949, 424);
            this.gridControl1.TabIndex = 60;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ReklamFirmasi,
            this.ArizaTarihi,
            this.IstasyonIsmi,
            this.İletisimYetkilisi,
            this.KurumsalMarka,
            this.Il,
            this.Ilce,
            this.Adres,
            this.Aciklamasi,
            this.Resim1,
            this.Resim2,
            this.Resim3,
            this.Durumu,
            this.Islemler,
            this.Garanti});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // ReklamFirmasi
            // 
            this.ReklamFirmasi.Caption = "Reklam Firması";
            this.ReklamFirmasi.MinWidth = 25;
            this.ReklamFirmasi.Name = "ReklamFirmasi";
            this.ReklamFirmasi.Visible = true;
            this.ReklamFirmasi.VisibleIndex = 0;
            this.ReklamFirmasi.Width = 114;
            // 
            // ArizaTarihi
            // 
            this.ArizaTarihi.Caption = "Arıza Tarihi";
            this.ArizaTarihi.MinWidth = 25;
            this.ArizaTarihi.Name = "ArizaTarihi";
            this.ArizaTarihi.Visible = true;
            this.ArizaTarihi.VisibleIndex = 1;
            this.ArizaTarihi.Width = 79;
            // 
            // IstasyonIsmi
            // 
            this.IstasyonIsmi.Caption = "İstasyon İsmi ";
            this.IstasyonIsmi.MinWidth = 25;
            this.IstasyonIsmi.Name = "IstasyonIsmi";
            this.IstasyonIsmi.Visible = true;
            this.IstasyonIsmi.VisibleIndex = 2;
            this.IstasyonIsmi.Width = 93;
            // 
            // İletisimYetkilisi
            // 
            this.İletisimYetkilisi.Caption = "İletişim Yetkilisi";
            this.İletisimYetkilisi.MinWidth = 25;
            this.İletisimYetkilisi.Name = "İletisimYetkilisi";
            this.İletisimYetkilisi.Visible = true;
            this.İletisimYetkilisi.VisibleIndex = 3;
            this.İletisimYetkilisi.Width = 102;
            // 
            // KurumsalMarka
            // 
            this.KurumsalMarka.Caption = "Kurumsal Marka";
            this.KurumsalMarka.MinWidth = 25;
            this.KurumsalMarka.Name = "KurumsalMarka";
            this.KurumsalMarka.Visible = true;
            this.KurumsalMarka.VisibleIndex = 4;
            this.KurumsalMarka.Width = 107;
            // 
            // Il
            // 
            this.Il.Caption = "İl";
            this.Il.MinWidth = 25;
            this.Il.Name = "Il";
            this.Il.Visible = true;
            this.Il.VisibleIndex = 5;
            this.Il.Width = 37;
            // 
            // Ilce
            // 
            this.Ilce.Caption = "İlçe";
            this.Ilce.MinWidth = 25;
            this.Ilce.Name = "Ilce";
            this.Ilce.Visible = true;
            this.Ilce.VisibleIndex = 6;
            this.Ilce.Width = 48;
            // 
            // Adres
            // 
            this.Adres.Caption = "Adres";
            this.Adres.MinWidth = 25;
            this.Adres.Name = "Adres";
            this.Adres.Visible = true;
            this.Adres.VisibleIndex = 7;
            this.Adres.Width = 48;
            // 
            // Aciklamasi
            // 
            this.Aciklamasi.Caption = "Açıklaması";
            this.Aciklamasi.MinWidth = 25;
            this.Aciklamasi.Name = "Aciklamasi";
            this.Aciklamasi.Visible = true;
            this.Aciklamasi.VisibleIndex = 8;
            this.Aciklamasi.Width = 74;
            // 
            // Resim1
            // 
            this.Resim1.Caption = "Resim 1";
            this.Resim1.MinWidth = 25;
            this.Resim1.Name = "Resim1";
            this.Resim1.Visible = true;
            this.Resim1.VisibleIndex = 9;
            this.Resim1.Width = 63;
            // 
            // Resim2
            // 
            this.Resim2.Caption = "Resim 2";
            this.Resim2.MinWidth = 25;
            this.Resim2.Name = "Resim2";
            this.Resim2.Visible = true;
            this.Resim2.VisibleIndex = 10;
            this.Resim2.Width = 59;
            // 
            // Resim3
            // 
            this.Resim3.Caption = "Resim 3";
            this.Resim3.MinWidth = 25;
            this.Resim3.Name = "Resim3";
            this.Resim3.Visible = true;
            this.Resim3.VisibleIndex = 11;
            this.Resim3.Width = 57;
            // 
            // Durumu
            // 
            this.Durumu.Caption = "Durumu";
            this.Durumu.MinWidth = 25;
            this.Durumu.Name = "Durumu";
            this.Durumu.Visible = true;
            this.Durumu.VisibleIndex = 12;
            this.Durumu.Width = 61;
            // 
            // Islemler
            // 
            this.Islemler.Caption = "İşlemler";
            this.Islemler.MinWidth = 25;
            this.Islemler.Name = "Islemler";
            this.Islemler.Visible = true;
            this.Islemler.VisibleIndex = 13;
            this.Islemler.Width = 68;
            // 
            // textEdit9
            // 
            this.textEdit9.Location = new System.Drawing.Point(551, 123);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Size = new System.Drawing.Size(125, 22);
            this.textEdit9.TabIndex = 55;
            // 
            // textEdit8
            // 
            this.textEdit8.Location = new System.Drawing.Point(410, 123);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Size = new System.Drawing.Size(125, 22);
            this.textEdit8.TabIndex = 54;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(278, 123);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(125, 22);
            this.textEdit7.TabIndex = 53;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(147, 123);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(125, 22);
            this.textEdit6.TabIndex = 52;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(16, 123);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(125, 22);
            this.textEdit5.TabIndex = 51;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(588, 101);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(45, 16);
            this.labelControl14.TabIndex = 50;
            this.labelControl14.Text = "Durumu";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(441, 101);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(60, 16);
            this.labelControl13.TabIndex = 49;
            this.labelControl13.Text = "Açıklaması";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(328, 101);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(33, 16);
            this.labelControl12.TabIndex = 48;
            this.labelControl12.Text = "Adres";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(206, 101);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(20, 16);
            this.labelControl11.TabIndex = 47;
            this.labelControl11.Text = "İlçe";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(71, 101);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(7, 16);
            this.labelControl10.TabIndex = 46;
            this.labelControl10.Text = "İl";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(551, 48);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(125, 22);
            this.textEdit4.TabIndex = 45;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(565, 26);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(92, 16);
            this.labelControl9.TabIndex = 44;
            this.labelControl9.Text = "Kurumsal Marka";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(410, 48);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(125, 22);
            this.textEdit3.TabIndex = 43;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(424, 26);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(87, 16);
            this.labelControl8.TabIndex = 42;
            this.labelControl8.Text = "İletişim Yetkilisi";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(278, 48);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(125, 22);
            this.textEdit2.TabIndex = 41;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(302, 26);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 16);
            this.labelControl7.TabIndex = 40;
            this.labelControl7.Text = "İstasyon İsmi";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(147, 48);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(125, 22);
            this.dateEdit1.TabIndex = 39;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(179, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 16);
            this.labelControl6.TabIndex = 38;
            this.labelControl6.Text = "Arıza Tarihi";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(16, 48);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(125, 22);
            this.textEdit1.TabIndex = 37;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(28, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 16);
            this.labelControl5.TabIndex = 36;
            this.labelControl5.Text = "Reklam Firması";
            // 
            // Garanti
            // 
            this.Garanti.Caption = "Garanti";
            this.Garanti.MinWidth = 25;
            this.Garanti.Name = "Garanti";
            this.Garanti.Visible = true;
            this.Garanti.VisibleIndex = 14;
            this.Garanti.Width = 94;
            // 
            // ArizaKayitlarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 586);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.textEdit9);
            this.Controls.Add(this.textEdit8);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl5);
            this.Name = "ArizaKayitlarim";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ReklamFirmasi;
        private DevExpress.XtraGrid.Columns.GridColumn ArizaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn IstasyonIsmi;
        private DevExpress.XtraGrid.Columns.GridColumn İletisimYetkilisi;
        private DevExpress.XtraGrid.Columns.GridColumn KurumsalMarka;
        private DevExpress.XtraGrid.Columns.GridColumn Il;
        private DevExpress.XtraGrid.Columns.GridColumn Ilce;
        private DevExpress.XtraGrid.Columns.GridColumn Adres;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklamasi;
        private DevExpress.XtraGrid.Columns.GridColumn Resim1;
        private DevExpress.XtraGrid.Columns.GridColumn Resim2;
        private DevExpress.XtraGrid.Columns.GridColumn Resim3;
        private DevExpress.XtraGrid.Columns.GridColumn Durumu;
        private DevExpress.XtraGrid.Columns.GridColumn Islemler;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn Garanti;
    }
}