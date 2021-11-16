using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chilkat.Crypt2 decrypt = new Chilkat.Crypt2();
            decrypt.CryptAlgorithm = "aes";
            decrypt.CipherMode = "ctr";
            decrypt.KeyLength = 128;
            decrypt.EncodingMode = "base64";
            decrypt.SetEncodedKey(textBox1.Text, "ascii");
            decrypt.SetEncodedIV(textBox2.Text, "ascii");
            richTextBox2.Text = decrypt.DecryptStringENC(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chilkat.Crypt2 crypt = new Chilkat.Crypt2();
            crypt.CryptAlgorithm = "aes";
            crypt.CipherMode = "ctr";
            crypt.KeyLength = 128;
            crypt.EncodingMode = "base64";
            crypt.SetEncodedKey(textBox1.Text, "ascii");
            crypt.SetEncodedIV(textBox2.Text, "ascii");
            richTextBox2.Text = crypt.EncryptStringENC(richTextBox1.Text);
        }
    }
}
