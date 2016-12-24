using InfoSecurity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Test
{
    [TestClass()]
    public class RSASignTest
    {
        [TestMethod()]
        public void TestRSASign()
        {
            string plaintext = "Sample text";
            string p = "73";
            string q = "13";

            byte[] inputByteArrayPlaintext = Encoding.ASCII.GetBytes(plaintext);
            MemoryStream inputStreamPlaintext = new MemoryStream(inputByteArrayPlaintext);
            byte[] pByteArray = Encoding.ASCII.GetBytes(p);
            MemoryStream pStream = new MemoryStream(pByteArray);
            byte[] qByteArray = Encoding.ASCII.GetBytes(q);
            MemoryStream qStream = new MemoryStream(qByteArray);

            Stream signStream = new MemoryStream();

            RSASign target = new RSASign(pStream, qStream);

            target.Sign(inputStreamPlaintext, signStream);

            bool valid = target.Verify(signStream);
            Assert.AreEqual(true, valid);
        }
    }
}
