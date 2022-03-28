using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMANM06
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MNceasar_Click(object sender, EventArgs e)
        {
            var form = new CeasarForm();
            form.Show();
        }

        private void MNhash_Click(object sender, EventArgs e)
        {
            var form = new HashForm();
            form.Show();
        }

        private void MNrsa_Click(object sender, EventArgs e)
        {
            var form = new RSAForm();
            form.Show();
        }

        private void MN3des_Click(object sender, EventArgs e)
        {
            var form = new DESForm();
            form.Show();
        }

        private void MNVigenere_Click(object sender, EventArgs e)
        {
            var form  = new VigenereForm();
            form.Show();
        }
    }
}
