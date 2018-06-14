namespace Server
{
    partial class Client
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
            this.LstMessage = new System.Windows.Forms.ListView();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstMessage
            // 
            this.LstMessage.Location = new System.Drawing.Point(12, 12);
            this.LstMessage.Name = "LstMessage";
            this.LstMessage.Size = new System.Drawing.Size(752, 311);
            this.LstMessage.TabIndex = 0;
            this.LstMessage.UseCompatibleStateImageBehavior = false;
            this.LstMessage.View = System.Windows.Forms.View.List;
            // 
            // TxtMessage
            // 
            this.TxtMessage.Location = new System.Drawing.Point(12, 341);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(596, 58);
            this.TxtMessage.TabIndex = 1;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(625, 357);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(126, 23);
            this.BtnSend.TabIndex = 2;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // Client
            // 
            this.AcceptButton = this.BtnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 411);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.LstMessage);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstMessage;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.Button BtnSend;
    }
}

