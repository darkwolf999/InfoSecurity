using InfoSecurity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Test
{
    [TestClass]
    public class TestAES
    {
        string plaintext = "0x11112222aaaabbbbffff99995555aaaa";

        string key = "0x22222aaaa2222222bbbb222222aaaa22";

        string ciphertext = "0x4f3866bb5e273b9b787f91cd613b64b7";

        [TestMethod]
        public void TestEncodeBlock()
        {
            byte[] inputByteArrPlaintext = Encoding.ASCII.GetBytes(plaintext);
            MemoryStream inputStreamPlaintext = new MemoryStream(inputByteArrPlaintext);

            byte[] inpByteArrKey = Encoding.ASCII.GetBytes(key);
            MemoryStream inputStreamKey = new MemoryStream(inpByteArrKey);

            Stream outputStreamCiphertext = new MemoryStream();

            AES128 aes = new AES128(inputStreamKey);
            aes.Encrypt(inputStreamPlaintext, outputStreamCiphertext);

            byte[] buf = new byte[outputStreamCiphertext.Length];
            outputStreamCiphertext.Read(buf, 0, (int)outputStreamCiphertext.Length);

            string encrypted = Encoding.Default.GetString(buf, 0, buf.Length);
            Assert.AreEqual(ciphertext, encrypted);
        }

        [TestMethod]
        public void TestDecodeBlock()
        {
            byte[] inputByteArrCiphertext = Encoding.ASCII.GetBytes(ciphertext);
            MemoryStream inputStreamCiphertext = new MemoryStream(inputByteArrCiphertext);

            byte[] inputByteArrKey = Encoding.ASCII.GetBytes(key);
            MemoryStream inputStreamKey = new MemoryStream(inputByteArrKey);

            Stream outputStreamPlaintext = new MemoryStream();

            AES128 aes = new AES128(inputStreamKey);
            aes.Decrypt(inputStreamCiphertext, outputStreamPlaintext);

            byte[] buf = new byte[outputStreamPlaintext.Length];
            outputStreamPlaintext.Read(buf, 0, (int)outputStreamPlaintext.Length);

            string decrypted = Encoding.Default.GetString(buf, 0, buf.Length);
            Assert.AreEqual(plaintext, decrypted);
        }
    }
}
