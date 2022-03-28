
namespace BMANM06
{
    partial class CeasarForm
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
            this.btnCeasarDecode = new System.Windows.Forms.Button();
            this.btnCeasarEncode = new System.Windows.Forms.Button();
            this.richTBCeasar3 = new System.Windows.Forms.RichTextBox();
            this.richTBCeasar2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTBCeasar1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDoDoi = new System.Windows.Forms.NumericUpDown();
            this.btnEncryptEG = new System.Windows.Forms.Button();
            this.btnDecryptEG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDoDoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCeasarDecode
            // 
            this.btnCeasarDecode.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCeasarDecode.Location = new System.Drawing.Point(116, 299);
            this.btnCeasarDecode.Name = "btnCeasarDecode";
            this.btnCeasarDecode.Size = new System.Drawing.Size(112, 34);
            this.btnCeasarDecode.TabIndex = 35;
            this.btnCeasarDecode.Text = "Giải mã TV";
            this.btnCeasarDecode.UseVisualStyleBackColor = true;
            this.btnCeasarDecode.Click += new System.EventHandler(this.btnCeasarDecode_Click);
            // 
            // btnCeasarEncode
            // 
            this.btnCeasarEncode.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCeasarEncode.Location = new System.Drawing.Point(116, 164);
            this.btnCeasarEncode.Name = "btnCeasarEncode";
            this.btnCeasarEncode.Size = new System.Drawing.Size(112, 34);
            this.btnCeasarEncode.TabIndex = 34;
            this.btnCeasarEncode.Text = "Mã hóa TV";
            this.btnCeasarEncode.UseVisualStyleBackColor = true;
            this.btnCeasarEncode.Click += new System.EventHandler(this.btnCeasarEncode_Click);
            // 
            // richTBCeasar3
            // 
            this.richTBCeasar3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTBCeasar3.Location = new System.Drawing.Point(23, 342);
            this.richTBCeasar3.Name = "richTBCeasar3";
            this.richTBCeasar3.Size = new System.Drawing.Size(750, 77);
            this.richTBCeasar3.TabIndex = 33;
            this.richTBCeasar3.Text = "";
            // 
            // richTBCeasar2
            // 
            this.richTBCeasar2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTBCeasar2.Location = new System.Drawing.Point(23, 208);
            this.richTBCeasar2.Name = "richTBCeasar2";
            this.richTBCeasar2.Size = new System.Drawing.Size(750, 77);
            this.richTBCeasar2.TabIndex = 32;
            this.richTBCeasar2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Giải mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Bản mã";
            // 
            // richTBCeasar1
            // 
            this.richTBCeasar1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTBCeasar1.Location = new System.Drawing.Point(23, 71);
            this.richTBCeasar1.Name = "richTBCeasar1";
            this.richTBCeasar1.Size = new System.Drawing.Size(750, 77);
            this.richTBCeasar1.TabIndex = 29;
            this.richTBCeasar1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bản rõ";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(661, 20);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(112, 34);
            this.btnReload.TabIndex = 36;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Độ dời k";
            // 
            // NUDoDoi
            // 
            this.NUDoDoi.Location = new System.Drawing.Point(474, 23);
            this.NUDoDoi.Name = "NUDoDoi";
            this.NUDoDoi.Size = new System.Drawing.Size(180, 31);
            this.NUDoDoi.TabIndex = 38;
            // 
            // btnEncryptEG
            // 
            this.btnEncryptEG.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncryptEG.Location = new System.Drawing.Point(234, 164);
            this.btnEncryptEG.Name = "btnEncryptEG";
            this.btnEncryptEG.Size = new System.Drawing.Size(112, 34);
            this.btnEncryptEG.TabIndex = 39;
            this.btnEncryptEG.Text = "Mã hóa EG";
            this.btnEncryptEG.UseVisualStyleBackColor = true;
            this.btnEncryptEG.Click += new System.EventHandler(this.btnEncryptEG_Click);
            // 
            // btnDecryptEG
            // 
            this.btnDecryptEG.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecryptEG.Location = new System.Drawing.Point(234, 302);
            this.btnDecryptEG.Name = "btnDecryptEG";
            this.btnDecryptEG.Size = new System.Drawing.Size(112, 34);
            this.btnDecryptEG.TabIndex = 40;
            this.btnDecryptEG.Text = "Giải mã EG";
            this.btnDecryptEG.UseVisualStyleBackColor = true;
            this.btnDecryptEG.Click += new System.EventHandler(this.btnDecryptEG_Click);
            // 
            // CeasarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 446);
            this.Controls.Add(this.btnDecryptEG);
            this.Controls.Add(this.btnEncryptEG);
            this.Controls.Add(this.NUDoDoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCeasarDecode);
            this.Controls.Add(this.btnCeasarEncode);
            this.Controls.Add(this.richTBCeasar3);
            this.Controls.Add(this.richTBCeasar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTBCeasar1);
            this.Controls.Add(this.label1);
            this.Name = "CeasarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CeasarForm";
            ((System.ComponentModel.ISupportInitialize)(this.NUDoDoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCeasarDecode;
        private System.Windows.Forms.Button btnCeasarEncode;
        private System.Windows.Forms.RichTextBox richTBCeasar3;
        private System.Windows.Forms.RichTextBox richTBCeasar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTBCeasar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDoDoi;
        private System.Windows.Forms.Button btnEncryptEG;
        private System.Windows.Forms.Button btnDecryptEG;
    }
}