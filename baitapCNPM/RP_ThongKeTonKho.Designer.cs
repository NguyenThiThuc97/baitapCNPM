namespace baitapCNPM
{
    partial class RP_ThongKeTonKho
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP_ThongKeTonKho));
            this.TKTonKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TonKho = new baitapCNPM.TonKho();
            this.rp_TKTonKho = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtNam = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TKTonKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TKTonKhoBindingSource
            // 
            this.TKTonKhoBindingSource.DataMember = "TKTonKho";
            this.TKTonKhoBindingSource.DataSource = this.TonKho;
            // 
            // TonKho
            // 
            this.TonKho.DataSetName = "TonKho";
            this.TonKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rp_TKTonKho
            // 
            reportDataSource2.Name = "dsTonKho";
            reportDataSource2.Value = this.TKTonKhoBindingSource;
            this.rp_TKTonKho.LocalReport.DataSources.Add(reportDataSource2);
            this.rp_TKTonKho.LocalReport.ReportEmbeddedResource = "baitapCNPM.ThongKeTonKho.rdlc";
            this.rp_TKTonKho.Location = new System.Drawing.Point(30, 112);
            this.rp_TKTonKho.Name = "rp_TKTonKho";
            this.rp_TKTonKho.Size = new System.Drawing.Size(1215, 494);
            this.rp_TKTonKho.TabIndex = 0;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(358, 44);
            this.txtNam.Name = "txtNam";
            this.txtNam.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNam.Properties.Appearance.Options.UseFont = true;
            this.txtNam.Size = new System.Drawing.Size(170, 26);
            this.txtNam.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(226, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Năm";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(615, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(134, 43);
            this.simpleButton1.TabIndex = 25;
            this.simpleButton1.Text = "Tìm Kiếm";
            this.simpleButton1.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // RP_ThongKeTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 618);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rp_TKTonKho);
            this.Name = "RP_ThongKeTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê tồn kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RP_ThongKeTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TKTonKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_TKTonKho;
        private DevExpress.XtraEditors.TextEdit txtNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource TKTonKhoBindingSource;
        private TonKho TonKho;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}