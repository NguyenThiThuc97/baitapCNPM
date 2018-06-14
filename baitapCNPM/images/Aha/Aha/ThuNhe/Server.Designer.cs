namespace ThuNhe
{
    partial class Server
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
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.LstMessage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(625, 357);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(126, 23);
            this.BtnSend.TabIndex = 5;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TxtMessage
            // 
            this.TxtMessage.Location = new System.Drawing.Point(12, 341);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(596, 58);
            this.TxtMessage.TabIndex = 4;
            // 
            // LstMessage
            // 
            this.LstMessage.Location = new System.Drawing.Point(12, 12);
            this.LstMessage.Name = "LstMessage";
            this.LstMessage.Size = new System.Drawing.Size(752, 311);
            this.LstMessage.TabIndex = 3;
            this.LstMessage.UseCompatibleStateImageBehavior = false;
            this.LstMessage.View = System.Windows.Forms.View.List;
            // 
            // Server
            // 
            this.AcceptButton = this.BtnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 413);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.LstMessage);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.ListView LstMessage;
    }
}