using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace InfoSecuritySoft
{
    public partial class Main : Form
    {
        InfoSecurity.AES128 aes;
        InfoSecurity.RSA rsa;
        InfoSecurity.MD5 md5;
        InfoSecurity.RSASign rsaSign;

        public Main()
        {
            InitializeComponent();

            button_decrypt_AES.Enabled = false;
            button_decrypt_RSA.Enabled = false;
            button_verify_sign.Enabled = false;
        }

        private void button_encrypt_AES_Click(object sender, EventArgs e)
        {
            button_encrypt_AES.Enabled = false;
            button_decrypt_AES.Enabled = true;
            textBox_text_AES.Enabled = false;

            string plaintext = textBox_text_AES.Text;
            string key = textBox_key_AES.Text;

            byte[] inputByteArrPlaintext = Encoding.ASCII.GetBytes(plaintext);
            MemoryStream inputStreamPlaintext = new MemoryStream(inputByteArrPlaintext);

            byte[] inpByteArrKey = Encoding.ASCII.GetBytes(key);
            MemoryStream inputStreamKey = new MemoryStream(inpByteArrKey);

            Stream outputStreamCiphertext = new MemoryStream();

            aes = new InfoSecurity.AES128(inputStreamKey);
            aes.Encrypt(inputStreamPlaintext, outputStreamCiphertext);

            byte[] buf = new byte[outputStreamCiphertext.Length];
            outputStreamCiphertext.Read(buf, 0, (int)outputStreamCiphertext.Length);

            string encrypted = Encoding.Default.GetString(buf, 0, buf.Length);

            textBox_text_AES.Text = encrypted;
        }

        private void button_decrypt_AES_Click(object sender, EventArgs e)
        {
            button_encrypt_AES.Enabled = true;
            button_decrypt_AES.Enabled = false;
            textBox_text_AES.Enabled = true;

            string ciphertext = textBox_text_AES.Text;
            string key = textBox_key_AES.Text;

            byte[] inputByteArrCiphertext = Encoding.ASCII.GetBytes(ciphertext);
            MemoryStream inputStreamCiphertext = new MemoryStream(inputByteArrCiphertext);

            byte[] inputByteArrKey = Encoding.ASCII.GetBytes(key);
            MemoryStream inputStreamKey = new MemoryStream(inputByteArrKey);

            Stream outputStreamPlaintext = new MemoryStream();

            aes = new InfoSecurity.AES128(inputStreamKey);
            aes.Decrypt(inputStreamCiphertext, outputStreamPlaintext);

            byte[] buf = new byte[outputStreamPlaintext.Length];
            outputStreamPlaintext.Read(buf, 0, (int)outputStreamPlaintext.Length);

            string decrypted = Encoding.Default.GetString(buf, 0, buf.Length);

            textBox_text_AES.Text = decrypted;
        }

        private void button_encrypt_RSA_Click(object sender, EventArgs e)
        {
            button_encrypt_RSA.Enabled = false;
            button_decrypt_RSA.Enabled = true;
            textBox_text_RSA.Enabled = false;

            string plaintext = textBox_text_RSA.Text;
            string p = textBox_p_RSA.Text;
            string q = textBox_q_RSA.Text;

            byte[] inputByteArrPlaintext = Encoding.ASCII.GetBytes(plaintext);
            MemoryStream inputStreamPlaintext = new MemoryStream(inputByteArrPlaintext);
            byte[] pByteArr = Encoding.ASCII.GetBytes(p);
            MemoryStream pStream = new MemoryStream(pByteArr);
            byte[] qByteArr = Encoding.ASCII.GetBytes(q);
            MemoryStream qStream = new MemoryStream(qByteArr);

            Stream outputStream1 = new MemoryStream();

            rsa = new InfoSecurity.RSA(pStream, qStream);

            rsa.Encrypt(inputStreamPlaintext, outputStream1);

            byte[] buf = new byte[outputStream1.Length];
            outputStream1.Read(buf, 0, (int)outputStream1.Length);

            string encrypted = Encoding.Default.GetString(buf, 0, buf.Length);

            textBox_text_RSA.Text = encrypted;
        }

        private void button_decrypt_RSA_Click(object sender, EventArgs e)
        {
            button_encrypt_RSA.Enabled = true;
            button_decrypt_RSA.Enabled = false;
            textBox_text_RSA.Enabled = true;

            string ciphertext = textBox_text_RSA.Text;
            string p = textBox_p_RSA.Text;
            string q = textBox_q_RSA.Text;

            byte[] inputByteArrCiphertext = Encoding.ASCII.GetBytes(ciphertext);
            MemoryStream inputStreamCiphertext = new MemoryStream(inputByteArrCiphertext);
            byte[] pByteArr = Encoding.ASCII.GetBytes(p);
            MemoryStream pStream = new MemoryStream(pByteArr);
            byte[] qByteArr = Encoding.ASCII.GetBytes(q);
            MemoryStream qStream = new MemoryStream(qByteArr);

            Stream outputStream2 = new MemoryStream();

            rsa.Decrypt(inputStreamCiphertext, outputStream2);

            byte[] buf = new byte[outputStream2.Length];
            outputStream2.Read(buf, 0, (int)outputStream2.Length);

            string decrypted = Encoding.Default.GetString(buf, 0, buf.Length);

            textBox_text_RSA.Text = decrypted;
        }

        private void button_hash_Click(object sender, EventArgs e)
        {
            button_hash.Enabled = false;
            textBox_hash.Enabled = false;

            string plaintext = textBox_text_MD5.Text;
            
            byte[] inputByteArrayPlaintext = Encoding.ASCII.GetBytes(plaintext);
            MemoryStream inputStreamPlaintext = new MemoryStream(inputByteArrayPlaintext);
            Stream hashedStream = new MemoryStream();

            md5 = new InfoSecurity.MD5();
            md5.Hash(inputStreamPlaintext, hashedStream);

            byte[] buf = new byte[hashedStream.Length];
            hashedStream.Read(buf, 0, (int)hashedStream.Length);

            string hashSum = BitConverter.ToString(buf).Replace("-", "").ToLower();

            textBox_hash.Text = hashSum;
        }

        private void textBox_text_MD5_TextChanged(object sender, EventArgs e)
        {
            button_hash.Enabled = true;
            textBox_hash.Enabled = true;
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            button_sign.Enabled = false;
            button_verify_sign.Enabled = true;

            string plaintext = textBox_text_sign.Text;
            string p = textBox_p_sign_RSA.Text;
            string q = textBox_q_sign_RSA.Text;

            byte[] inputByteArrayPlaintext = Encoding.ASCII.GetBytes(plaintext);
            MemoryStream inputStreamPlaintext = new MemoryStream(inputByteArrayPlaintext);
            byte[] pByteArray = Encoding.ASCII.GetBytes(p);
            MemoryStream pStream = new MemoryStream(pByteArray);
            byte[] qByteArray = Encoding.ASCII.GetBytes(q);
            MemoryStream qStream = new MemoryStream(qByteArray);

            Stream signStream = new MemoryStream();

            rsaSign = new InfoSecurity.RSASign(pStream, qStream);

            rsaSign.Sign(inputStreamPlaintext, signStream);

            byte[] buf = new byte[signStream.Length];
            signStream.Read(buf, 0, (int)signStream.Length);

            string signature = Encoding.Default.GetString(buf, 0, buf.Length);

            textBox_text_sign.Text = signature;
        }

        private void button_verify_sign_Click(object sender, EventArgs e)
        {
            button_sign.Enabled = true;
            button_verify_sign.Enabled = false;

            string text = textBox_text_sign.Text;

            byte[] textByteArray = Encoding.ASCII.GetBytes(text);
            MemoryStream textStream = new MemoryStream(textByteArray);
            Stream output = new MemoryStream();

            bool valid = rsaSign.Verify(textStream);

            if (valid)
            {
                MessageBox.Show("TRUSTED", "RESULT OF CHECKING");
            }
            else
            {
                MessageBox.Show("NOT TRUSTED", "RESULT OF CHECKING");
            }

            textBox_text_sign.Text = "Sample text";
        } 

    }
}
