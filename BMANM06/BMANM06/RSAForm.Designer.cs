
namespace BMANM06
{
    partial class RSAForm
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
            this.btnRSADecode = new System.Windows.Forms.Button();
            this.btnRSAEncode = new System.Windows.Forms.Button();
            this.richTBRSA3 = new System.Windows.Forms.RichTextBox();
            this.richTBRSA2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTBRSA1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRSADecode
            // 
            this.btnRSADecode.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRSADecode.Location = new System.Drawing.Point(118, 304);
            this.btnRSADecode.Name = "btnRSADecode";
            this.btnRSADecode.Size = new System.Drawing.Size(112, 34);
            this.btnRSADecode.TabIndex = 27;
            this.btnRSADecode.Text = "Giải mã";
            this.btnRSADecode.UseVisualStyleBackColor = true;
            this.btnRSADecode.Click += new System.EventHandler(this.btnRSADecode_Click);
            // 
            // btnRSAEncode
            // 
            this.btnRSAEncode.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRSAEncode.Location = new System.Drawing.Point(118, 169);
            this.btnRSAEncode.Name = "btnRSAEncode";
            this.btnRSAEncode.Size = new System.Drawing.Size(112, 34);
            this.btnRSAEncode.TabIndex = 26;
            this.btnRSAEncode.Text = "Mã hóa";
            this.btnRSAEncode.UseVisualStyleBackColor = true;
            this.btnRSAEncode.Click += new System.EventHandler(this.btnRSAEncode_Click);
            // 
            // richTBRSA3
            // 
            this.richTBRSA3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTBRSA3.Location = new System.Drawing.Point(25, 347);
            this.richTBRSA3.Name = "richTBRSA3";
            this.richTBRSA3.Size = new System.Drawing.Size(750, 77);
            this.richTBRSA3.TabIndex = 25;
            this.richTBRSA3.Text = "";
            // 
            // richTBRSA2
            // 
            this.richTBRSA2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTBRSA2.Location = new System.Drawing.Point(25, 213);
            this.richTBRSA2.Name = "richTBRSA2";
            this.richTBRSA2.Size = new System.Drawing.Size(750, 77);
            this.richTBRSA2.TabIndex = 24;
            this.richTBRSA2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Giải mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Bản mã";
            // 
            // richTBRSA1
            // 
            this.richTBRSA1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTBRSA1.Location = new System.Drawing.Point(25, 76);
            this.richTBRSA1.Name = "richTBRSA1";
            this.richTBRSA1.Size = new System.Drawing.Size(750, 77);
            this.richTBRSA1.TabIndex = 21;
            this.richTBRSA1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Bản rõ";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(663, 25);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(112, 34);
            this.btnReload.TabIndex = 28;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // RSAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnRSADecode);
            this.Controls.Add(this.btnRSAEncode);
            this.Controls.Add(this.richTBRSA3);
            this.Controls.Add(this.richTBRSA2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTBRSA1);
            this.Controls.Add(this.label1);
            this.Name = "RSAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSAForm";
            this.Load += new System.EventHandler(this.RSAForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRSADecode;
        private System.Windows.Forms.Button btnRSAEncode;
        private System.Windows.Forms.RichTextBox richTBRSA3;
        private System.Windows.Forms.RichTextBox richTBRSA2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTBRSA1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReload;
    }
}