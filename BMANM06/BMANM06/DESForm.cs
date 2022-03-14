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
    public partial class DESForm : Form
    {
        public DESForm()
        {
            InitializeComponent();
        }

        private void btnDESEncode_Click(object sender, EventArgs e)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(richTBDES1.Text);
            if (true)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(txtKey.Text));
                hashmd5.Clear();
            }
            else
            {
                keyArray = UTF8Encoding.UTF8.GetBytes(txtKey.Text);
            }
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray =
            cTransform.TransformFinalBlock(toEncryptArray, 0,
            toEncryptArray.Length);
            tdes.Clear();
            richTBDES2.Text =  Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        private void btnDESDecode_Click(object sender, EventArgs e)
        {
            byte[] keyArray;
            byte[] toEncryptArray =
            Convert.FromBase64String(richTBDES2.Text);
            if (true)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray =
                hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(txtKey.Text));
                hashmd5.Clear();
            }
            else
            {
                keyArray = UTF8Encoding.UTF8.GetBytes(txtKey.Text);
            }
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray =
            cTransform.TransformFinalBlock(toEncryptArray, 0,
            toEncryptArray.Length);
            tdes.Clear();
            richTBDES3.Text =  UTF8Encoding.UTF8.GetString(resultArray);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtKey.Text = "";
            richTBDES1.Text = "";
            richTBDES2.Text = "";
            richTBDES3.Text = "";
        }
    }
}
