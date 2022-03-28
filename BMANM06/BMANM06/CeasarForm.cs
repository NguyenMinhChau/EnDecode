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
        string chuoi = "AĂÂBCDĐEÊGHIKLMNOÔƠPQRSTUƯVXY ?!ÁÀẢÚ";//bổ sung thêm
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        byte[] plaintText;
        byte[] cipherText;
        public CeasarForm()
        {
            InitializeComponent();
        }
        public int[] chuoi_mangchiso(string s)
        {
            int[] mang = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
                mang[i] = chuoi.IndexOf(s[i]);
            return mang;
        }
        //Thực hiện chuyển đổi mảng các chỉ số sang chuỗi tương ứng.
        public string chiso_chuoi(int[] a)
        {
            string s = "";
            for (int i = 0; i < a.Length; i++)
                s += chuoi[a[i]];
            return s;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            richTBCeasar1.Text = "";
            richTBCeasar2.Text = "";
            richTBCeasar3.Text = "";
        }

        private void btnCeasarEncode_Click(object sender, EventArgs e)
        {
            richTBCeasar1.Text = richTBCeasar1.Text.ToUpper();
            int[] pre_index = chuoi_mangchiso(richTBCeasar1.Text);
            int[] pos_index = new int[richTBCeasar1.Text.Length];
            //mã hóa
            for (int i = 0; i < richTBCeasar1.Text.Length; i++)
                pos_index[i] = (int)((pre_index[i] + NUDoDoi.Value) % chuoi.Length);

            richTBCeasar2.Text = chiso_chuoi(pos_index);
        }

        private void btnCeasarDecode_Click(object sender, EventArgs e)
        {
            int[] pre_index = chuoi_mangchiso(richTBCeasar2.Text);
            int[] pos_index = new int[richTBCeasar2.Text.Length];
            //mã hóa
            for (int i = 0; i < richTBCeasar2.Text.Length; i++)
                pos_index[i] = (int)((pre_index[i] + chuoi.Length - NUDoDoi.Value) % chuoi.Length);
            //đổi sang mảng
            richTBCeasar3.Text = chiso_chuoi(pos_index);
        }

        private void btnEncryptEG_Click(object sender, EventArgs e)
        {
            string result = "";
            richTBCeasar1.Text = richTBCeasar1.Text.ToUpper();
            for (int i = 0; i < richTBCeasar1.Text.Length; i++)
                result += (char)('A' +

                ((richTBCeasar1.Text[i] - 'A' + NUDoDoi.Value) % 26));
            richTBCeasar2.Text = result;
        }

        private void btnDecryptEG_Click(object sender, EventArgs e)
        {
            string kq = string.Empty;
            for (int i = 0; i < richTBCeasar2.Text.Length; i++)
                kq += (char)('A' + (richTBCeasar2.Text[i] - 'A' +

                (26 - NUDoDoi.Value)) % 26);

            richTBCeasar3.Text = kq;
        }
    }
}
