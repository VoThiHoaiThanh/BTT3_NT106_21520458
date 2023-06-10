namespace client
{
    partial class Form1
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
            this.IP = new System.Windows.Forms.TextBox();
            this.Mess = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(133, 34);
            this.IP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IP.Multiline = true;
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(424, 29);
            this.IP.TabIndex = 0;
            // 
            // Mess
            // 
            this.Mess.Location = new System.Drawing.Point(133, 82);
            this.Mess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mess.Multiline = true;
            this.Mess.Name = "Mess";
            this.Mess.Size = new System.Drawing.Size(424, 29);
            this.Mess.TabIndex = 1;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(590, 46);
            this.btSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(101, 40);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.Mess);
            this.Controls.Add(this.IP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox Mess;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

