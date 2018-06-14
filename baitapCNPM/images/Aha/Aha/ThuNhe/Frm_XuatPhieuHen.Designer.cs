namespace ThuNhe
{
    partial class Frm_XuatPhieuHen
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ChiTietPhieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoHanh_SChuaDataSet = new ThuNhe.BaoHanh_SChuaDataSet();
            this.PhieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PhieuTableAdapter = new ThuNhe.BaoHanh_SChuaDataSetTableAdapters.PhieuTableAdapter();
            this.ChiTietPhieuTableAdapter = new ThuNhe.BaoHanh_SChuaDataSetTableAdapters.ChiTietPhieuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietPhieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoHanh_SChuaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChiTietPhieuBindingSource
            // 
            this.ChiTietPhieuBindingSource.DataMember = "ChiTietPhieu";
            this.ChiTietPhieuBindingSource.DataSource = this.BaoHanh_SChuaDataSet;
            // 
            // BaoHanh_SChuaDataSet
            // 
            this.BaoHanh_SChuaDataSet.DataSetName = "BaoHanh_SChuaDataSet";
            this.BaoHanh_SChuaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhieuBindingSource
            // 
            this.PhieuBindingSource.DataMember = "Phieu";
            this.PhieuBindingSource.DataSource = this.BaoHanh_SChuaDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ChiTietPhieuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThuNhe.CTP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(792, 551);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PhieuBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ThuNhe.PhieuHen.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(792, 217);
            this.reportViewer2.TabIndex = 1;
            // 
            // PhieuTableAdapter
            // 
            this.PhieuTableAdapter.ClearBeforeFill = true;
            // 
            // ChiTietPhieuTableAdapter
            // 
            this.ChiTietPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_XuatPhieuHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 575);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_XuatPhieuHen";
            this.Text = "Frm_XuatPhieuHen";
            this.Load += new System.EventHandler(this.Frm_XuatPhieuHen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietPhieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoHanh_SChuaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PhieuBindingSource;
        private BaoHanh_SChuaDataSet BaoHanh_SChuaDataSet;
        private BaoHanh_SChuaDataSetTableAdapters.PhieuTableAdapter PhieuTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource ChiTietPhieuBindingSource;
        private BaoHanh_SChuaDataSetTableAdapters.ChiTietPhieuTableAdapter ChiTietPhieuTableAdapter;
    }
}