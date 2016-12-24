using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InfoSecurity
{
    public class RSASign : RSA, ISign
    {
        private string hash;
        private string sign;

        public RSASign(Stream p, Stream q) : base(p, q) { }

        public void Sign(Stream inp, Stream outp)
        {
            if (IsSimple(p) && IsSimple(q))
            {
                StreamReader reader = new StreamReader(inp);
                plaintext = reader.ReadToEnd();

                n = p * q;
                long m = (p - 1) * (q - 1);
                d = GetD(m);
                long e = GetE(m);

                MD5 md5 = new MD5();

                byte[] dataArray = Encoding.ASCII.GetBytes(plaintext);
                Stream dataStream = new MemoryStream(dataArray);
                Stream hashStream = new MemoryStream();

                md5.Hash(dataStream, hashStream);

                byte[] buf = new byte[hashStream.Length];
                hashStream.Read(buf, 0, (int)hashStream.Length);

                hash = System.Text.Encoding.ASCII.GetString(buf);

                List<string> signRes = RSAEncrypt(e, hash);

                sign = "";
                foreach (string item in signRes)
                {
                    sign += item + " ";
                }
                sign = sign.TrimEnd(' ');

                byte[] byteArray = Encoding.ASCII.GetBytes(sign);
                outp.Write(byteArray, 0, byteArray.Length);
                outp.Position = 0;

            }
            else
                throw new Exception("numbers is not simple");

        }

        public bool Verify(Stream signStream)
        {
            StreamReader reader = new StreamReader(signStream);
            string recieveSign = reader.ReadToEnd();

            long m = (p - 1) * (q - 1);
            long e = GetE(m);

            List<string> signList = recieveSign.Split(' ').ToList();
            string signHash = RSADecrypt(signList);

            MD5 md5 = new MD5();

            byte[] dataArray = Encoding.ASCII.GetBytes(plaintext);
            Stream dataStream = new MemoryStream(dataArray);
            Stream hashStream = new MemoryStream();

            md5.Hash(dataStream, hashStream);

            byte[] buf = new byte[hashStream.Length];
            hashStream.Read(buf, 0, (int)hashStream.Length);

            string recieveDataHash = System.Text.Encoding.ASCII.GetString(buf);

            if (signHash.CompareTo(recieveDataHash) == 0)
            {
                return true;
            }

            return false;
        }
    }
}
