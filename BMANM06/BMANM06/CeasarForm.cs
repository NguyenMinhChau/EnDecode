using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMANM06
{
    public partial class CeasarForm : Form
    {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        byte[] plaintText;
        byte[] cipherText;
        public CeasarForm()
        {
            InitializeComponent();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            richTBCeasar1.Text = "";
            richTBCeasar2.Text = "";
            richTBCeasar3.Text = "";
        }

        private void btnCeasarEncode_Click(object sender, EventArgs e)
        {
            plaintText = Encoding.UTF8.GetBytes(richTBCeasar1.Text);
            cipherText = RSAEncryption.MaHoa(plaintText,
            rsa.ExportParameters(false), false);
            //txtCipherText.Text =
            Encoding.UTF8.GetString(cipherText);
            StringBuilder sbHash = new StringBuilder();
            foreach (byte b in cipherText)
                sbHash.Append(String.Format("{0:x2}", b));
            richTBCeasar2.Text = sbHash.ToString();
        }

        private void btnCeasarDecode_Click(object sender, EventArgs e)
        {
            byte[] decryptText = RSAEncryption.GiaiMa(cipherText, rsa.ExportParameters(true), false);
            richTBCeasar3.Text = Encoding.UTF8.GetString(decryptText);
        }
    }
}
