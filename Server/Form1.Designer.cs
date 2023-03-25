namespace Server
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
            this.lb_Server = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_Server
            // 
            this.lb_Server.FormattingEnabled = true;
            this.lb_Server.ItemHeight = 20;
            this.lb_Server.Location = new System.Drawing.Point(0, 0);
            this.lb_Server.Name = "lb_Server";
            this.lb_Server.Size = new System.Drawing.Size(788, 444);
            this.lb_Server.TabIndex = 0;
            this.lb_Server.SelectedIndexChanged += new System.EventHandler(this.lb_Server_SelectedIndexChanged);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Server);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Server;
    }
}

