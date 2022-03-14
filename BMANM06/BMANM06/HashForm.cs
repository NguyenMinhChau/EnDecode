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
    public partial class HashForm : Form
    {
        public HashForm()
        {
            InitializeComponent();
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //chuyển từ chuỗi sang mảng byte
            byte[] input = Encoding.UTF8.GetBytes(txtHash.Text);
            byte[] result = md5.ComputeHash(input);
            StringBuilder sbHash = new StringBuilder();
            foreach (byte b in result)
                sbHash.Append(String.Format("{0:x2}", b));
            richTBHash.Text = sbHash.ToString();
        }

        private void btnSHA2_Click(object sender, EventArgs e)
        {
            SHA512Managed sha512 = new SHA512Managed();
            //chuyển từ chuỗi sang mảng byte
            byte[] input = Encoding.UTF8.GetBytes(txtHash.Text);
            byte[] result = sha512.ComputeHash(input);
            StringBuilder sbHash = new StringBuilder();
            foreach (byte b in result)
                sbHash.Append(String.Format("{0:x2}", b));
            richTBHash.Text = sbHash.ToString();
        }

        private void btnSHA1_Click(object sender, EventArgs e)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(txtHash.Text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            richTBHash.Text = hashSb.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtHash.Text = "";
            richTBHash.Text = "";
        }
    }
}
