using InfoSecurity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Test
{
    [TestClass()]
    public class TestMD5
    {
        [TestMethod()]
        public void HashTest()
        {
            string plaintext = "Sample text";
            string hashSum = "1ba249ca5931f3c85fe44d354c2f274d";

            byte[] inputByteArrayPlaintext = Encoding.ASCII.GetBytes(plaintext);
            MemoryStream inputStreamPlaintext = new MemoryStream(inputByteArrayPlaintext);
            Stream hashedStream = new MemoryStream();

            MD5 md5 = new MD5();
            md5.Hash(inputStreamPlaintext, hashedStream);

            byte[] buf = new byte[hashedStream.Length];
            hashedStream.Read(buf, 0, (int)hashedStream.Length);

            Assert.AreEqual(hashSum, buf.ConvertToString());
        }
    }
}
