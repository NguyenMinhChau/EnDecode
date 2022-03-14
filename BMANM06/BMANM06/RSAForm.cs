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
    public partial class RSAForm : Form
    {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        byte[] plaintText;
        byte[] cipherText;
        public RSAForm()
        {
            InitializeComponent();
        }

        private void RSAForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRSAEncode_Click(object sender, EventArgs e)
        {
            plaintText = Encoding.UTF8.GetBytes(richTBRSA1.Text);
            cipherText = RSAEncryption.MaHoa(plaintText,
            rsa.ExportParameters(false), false);
            //txtCipherText.Text =
            Encoding.UTF8.GetString(cipherText);
            StringBuilder sbHash = new StringBuilder();
            foreach (byte b in cipherText)
                sbHash.Append(String.Format("{0:x2}", b));
            richTBRSA2.Text = sbHash.ToString();
        }

        private void btnRSADecode_Click(object sender, EventArgs e)
        {
            byte[] decryptText = RSAEncryption.GiaiMa(cipherText, rsa.ExportParameters(true), false);
            richTBRSA3.Text = Encoding.UTF8.GetString(decryptText);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            richTBRSA1.Text = "";
            richTBRSA2.Text = "";
            richTBRSA3.Text = "";
        }
    }
}
