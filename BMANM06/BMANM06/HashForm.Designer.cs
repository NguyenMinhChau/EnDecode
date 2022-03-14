
namespace BMANM06
{
    partial class HashForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.btnSHA1 = new System.Windows.Forms.Button();
            this.btnSHA2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTBHash = new System.Windows.Forms.RichTextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuỗi cần mã hóa";
            // 
            // txtHash
            // 
            this.txtHash.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHash.Location = new System.Drawing.Point(202, 41);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(390, 30);
            this.txtHash.TabIndex = 1;
            // 
            // btnMD5
            // 
            this.btnMD5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMD5.Location = new System.Drawing.Point(23, 100);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(112, 34);
            this.btnMD5.TabIndex = 2;
            this.btnMD5.Text = "MD5";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // btnSHA1
            // 
            this.btnSHA1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSHA1.Location = new System.Drawing.Point(160, 100);
            this.btnSHA1.Name = "btnSHA1";
            this.btnSHA1.Size = new System.Drawing.Size(112, 34);
            this.btnSHA1.TabIndex = 3;
            this.btnSHA1.Text = "SHA-1";
            this.btnSHA1.UseVisualStyleBackColor = true;
            this.btnSHA1.Click += new System.EventHandler(this.btnSHA1_Click);
            // 
            // btnSHA2
            // 
            this.btnSHA2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSHA2.Location = new System.Drawing.Point(294, 100);
            this.btnSHA2.Name = "btnSHA2";
            this.btnSHA2.Size = new System.Drawing.Size(112, 34);
            this.btnSHA2.TabIndex = 4;
            this.btnSHA2.Text = "SHA2-512";
            this.btnSHA2.UseVisualStyleBackColor = true;
            this.btnSHA2.Click += new System.EventHandler(this.btnSHA2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thông tin mã hóa";
            // 
            // richTBHash
            // 
            this.richTBHash.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTBHash.Location = new System.Drawing.Point(23, 204);
            this.richTBHash.Name = "richTBHash";
            this.richTBHash.Size = new System.Drawing.Size(663, 127);
            this.richTBHash.TabIndex = 6;
            this.richTBHash.Text = "";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReload.Location = new System.Drawing.Point(426, 100);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(112, 34);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // HashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 360);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.richTBHash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSHA2);
            this.Controls.Add(this.btnSHA1);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.label1);
            this.Name = "HashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Button btnSHA1;
        private System.Windows.Forms.Button btnSHA2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTBHash;
        private System.Windows.Forms.Button btnReload;
    }
}