
namespace BMANM06
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MNceasar = new System.Windows.Forms.ToolStripMenuItem();
            this.MNhash = new System.Windows.Forms.ToolStripMenuItem();
            this.MNrsa = new System.Windows.Forms.ToolStripMenuItem();
            this.MN3des = new System.Windows.Forms.ToolStripMenuItem();
            this.vigenereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MNVigenere = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNceasar,
            this.MNhash,
            this.MNrsa,
            this.MN3des,
            this.vigenereToolStripMenuItem,
            this.MNVigenere});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MNceasar
            // 
            this.MNceasar.Name = "MNceasar";
            this.MNceasar.Size = new System.Drawing.Size(80, 29);
            this.MNceasar.Text = "Ceasar";
            this.MNceasar.Click += new System.EventHandler(this.MNceasar_Click);
            // 
            // MNhash
            // 
            this.MNhash.Name = "MNhash";
            this.MNhash.Size = new System.Drawing.Size(68, 29);
            this.MNhash.Text = "Hash";
            this.MNhash.Click += new System.EventHandler(this.MNhash_Click);
            // 
            // MNrsa
            // 
            this.MNrsa.Name = "MNrsa";
            this.MNrsa.Size = new System.Drawing.Size(61, 29);
            this.MNrsa.Text = "RSA";
            this.MNrsa.Click += new System.EventHandler(this.MNrsa_Click);
            // 
            // MN3des
            // 
            this.MN3des.Name = "MN3des";
            this.MN3des.Size = new System.Drawing.Size(70, 29);
            this.MN3des.Text = "3DES";
            this.MN3des.Click += new System.EventHandler(this.MN3des_Click);
            // 
            // vigenereToolStripMenuItem
            // 
            this.vigenereToolStripMenuItem.Name = "vigenereToolStripMenuItem";
            this.vigenereToolStripMenuItem.Size = new System.Drawing.Size(16, 29);
            // 
            // MNVigenere
            // 
            this.MNVigenere.Name = "MNVigenere";
            this.MNVigenere.Size = new System.Drawing.Size(97, 29);
            this.MNVigenere.Text = "Vigenere";
            this.MNVigenere.Click += new System.EventHandler(this.MNVigenere_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo thuật toán mã hóa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MNceasar;
        private System.Windows.Forms.ToolStripMenuItem MNhash;
        private System.Windows.Forms.ToolStripMenuItem MNrsa;
        private System.Windows.Forms.ToolStripMenuItem MN3des;
        private System.Windows.Forms.ToolStripMenuItem vigenereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MNVigenere;
    }
}

