using InfoSecurity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Test
{
    [TestClass()]
    public class RSATest
    {
        [TestMethod()]
        public void TestRSA()
        {
            string plaintext = "Sample text";
            string p = "73";
            string q = "13";

            byte[] inputByteArrPlaintext = Encoding.ASCII.GetBytes(plaintext);
            MemoryStream inputStreamPlaintext = new MemoryStream(inputByteArrPlaintext);
            byte[] pByteArr = Encoding.ASCII.GetBytes(p);
            MemoryStream pStream = new MemoryStream(pByteArr);
            byte[] qByteArr = Encoding.ASCII.GetBytes(q);
            MemoryStream qStream = new MemoryStream(qByteArr);

            Stream outputStream1 = new MemoryStream();
            Stream outputStream2 = new MemoryStream();

            RSA rsa = new RSA(pStream, qStream);

            rsa.Encrypt(inputStreamPlaintext, outputStream1);
            rsa.Decrypt(outputStream1, outputStream2);

            byte[] buf = new byte[outputStream2.Length];
            outputStream2.Read(buf, 0, (int)outputStream2.Length);

            string decrypted = Encoding.Default.GetString(buf, 0, buf.Length);
            Assert.AreEqual(plaintext, decrypted);
        }
    }
}
