
namespace BMANM06
{
    partial class DESForm
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDESDecode = new System.Windows.Forms.Button();
            this.btnDESEncode = new System.Windows.Forms.Button();
            this.richTBDES3 = new System.Windows.Forms.RichTextBox();
            this.richTBDES2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTBDES1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKey.Location = new System.Drawing.Point(523, 25);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(252, 30);
            this.txtKey.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(449, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Khóa";
            // 
            // btnDESDecode
            // 
            this.btnDESDecode.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDESDecode.Location = new System.Drawing.Point(128, 304);
            this.btnDESDecode.Name = "btnDESDecode";
            this.btnDESDecode.Size = new System.Drawing.Size(112, 34);
            this.btnDESDecode.TabIndex = 17;
            this.btnDESDecode.Text = "Giải mã";
            this.btnDESDecode.UseVisualStyleBackColor = true;
            this.btnDESDecode.Click += new System.EventHandler(this.btnDESDecode_Click);
            // 
            // btnDESEncode
            // 
            this.btnDESEncode.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDESEncode.Location = new System.Drawing.Point(128, 169);
            this.btnDESEncode.Name = "btnDESEncode";
            this.btnDESEncode.Size = new System.Drawing.Size(112, 34);
            this.btnDESEncode.TabIndex = 16;
            this.btnDESEncode.Text = "Mã hóa";
            this.btnDESEncode.UseVisualStyleBackColor = true;
            this.btnDESEncode.Click += new System.EventHandler(this.btnDESEncode_Click);
            // 
            // richTBDES3
            // 
            this.richTBDES3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTBDES3.Location = new System.Drawing.Point(25, 347);
            this.richTBDES3.Name = "richTBDES3";
            this.richTBDES3.Size = new System.Drawing.Size(750, 77);
            this.richTBDES3.TabIndex = 15;
            this.richTBDES3.Text = "";
            // 
            // richTBDES2
            // 
            this.richTBDES2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTBDES2.Location = new System.Drawing.Point(25, 213);
            this.richTBDES2.Name = "richTBDES2";
            this.richTBDES2.Size = new System.Drawing.Size(750, 77);
            this.richTBDES2.TabIndex = 14;
            this.richTBDES2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Giải mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bản mã";
            // 
            // richTBDES1
            // 
            this.richTBDES1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTBDES1.Location = new System.Drawing.Point(25, 76);
            this.richTBDES1.Name = "richTBDES1";
            this.richTBDES1.Size = new System.Drawing.Size(750, 77);
            this.richTBDES1.TabIndex = 11;
            this.richTBDES1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bản rõ";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(318, 25);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(112, 34);
            this.btnReload.TabIndex = 20;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // DESForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDESDecode);
            this.Controls.Add(this.btnDESEncode);
            this.Controls.Add(this.richTBDES3);
            this.Controls.Add(this.richTBDES2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTBDES1);
            this.Controls.Add(this.label1);
            this.Name = "DESForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_3DESForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDESDecode;
        private System.Windows.Forms.Button btnDESEncode;
        private System.Windows.Forms.RichTextBox richTBDES3;
        private System.Windows.Forms.RichTextBox richTBDES2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTBDES1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReload;
    }
}