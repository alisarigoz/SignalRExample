namespace SignalRServerSide
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
            this.txtprosmsgs = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBoot = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtprosmsgs
            // 
            this.txtprosmsgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtprosmsgs.Location = new System.Drawing.Point(0, 0);
            this.txtprosmsgs.Multiline = true;
            this.txtprosmsgs.Name = "txtprosmsgs";
            this.txtprosmsgs.Size = new System.Drawing.Size(800, 194);
            this.txtprosmsgs.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtprosmsgs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 194);
            this.panel1.TabIndex = 1;
            // 
            // btnBoot
            // 
            this.btnBoot.Location = new System.Drawing.Point(63, 24);
            this.btnBoot.Name = "btnBoot";
            this.btnBoot.Size = new System.Drawing.Size(120, 39);
            this.btnBoot.TabIndex = 2;
            this.btnBoot.Text = "Send BOOT";
            this.btnBoot.UseVisualStyleBackColor = true;
            this.btnBoot.Click += new System.EventHandler(this.btnBoot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBoot);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtprosmsgs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBoot;
    }
}

