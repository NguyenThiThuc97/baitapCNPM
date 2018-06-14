namespace ThuNhe
{
    partial class FrmMain
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
            this.BtnKH = new System.Windows.Forms.Button();
            this.BtnHD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKH
            // 
            this.BtnKH.Location = new System.Drawing.Point(108, 40);
            this.BtnKH.Name = "BtnKH";
            this.BtnKH.Size = new System.Drawing.Size(75, 92);
            this.BtnKH.TabIndex = 0;
            this.BtnKH.Text = "Quản lí thông tin khách hàng";
            this.BtnKH.UseVisualStyleBackColor = true;
            this.BtnKH.Click += new System.EventHandler(this.BtnKH_Click);
            // 
            // BtnHD
            // 
            this.BtnHD.Location = new System.Drawing.Point(220, 40);
            this.BtnHD.Name = "BtnHD";
            this.BtnHD.Size = new System.Drawing.Size(75, 92);
            this.BtnHD.TabIndex = 1;
            this.BtnHD.Text = "Quản lí hóa đơn";
            this.BtnHD.UseVisualStyleBackColor = true;
            this.BtnHD.Click += new System.EventHandler(this.BtnHD_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "xử lí danh sách khách hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 92);
            this.button2.TabIndex = 3;
            this.button2.Text = "xử lí danh sách Thiết bị";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 92);
            this.button3.TabIndex = 4;
            this.button3.Text = "xử lí danh sách phiếu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(626, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 92);
            this.button4.TabIndex = 5;
            this.button4.Text = "xử lí danh Hóa đơn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(978, 462);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnHD);
            this.Controls.Add(this.BtnKH);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKH;
        private System.Windows.Forms.Button BtnHD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}