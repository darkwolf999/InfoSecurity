using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Numerics;

namespace InfoSecurity
{
    public class RSA : IEncryptionDecryption
    {
        #region fields

        protected long p, q,
                       n,
                       d;

        protected string plaintext;

        #endregion

        public RSA(Stream p, Stream q)
        {
            StreamReader pReader = new StreamReader(p);
            this.p = Convert.ToInt64(pReader.ReadToEnd());

            StreamReader qReader = new StreamReader(q);
            this.q = Convert.ToInt64(qReader.ReadToEnd());
        }

        protected bool IsSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        protected long GetE(long m)
        {
            long e = 10;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }

        protected long GetD(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0))
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        protected List<string> RSAEncrypt(long e, string plaintext)
        {
            List<string> result = new List<string>();

            BigInteger bigInt;

            byte[] indexArr = Encoding.ASCII.GetBytes(plaintext);
            for (int i = 0; i < plaintext.Length; i++)
            {
                int index = indexArr[i];
                bigInt = new BigInteger(index);
                bigInt = BigInteger.Pow(bigInt, (int)e);

                BigInteger num = new BigInteger((int)n);

                bigInt = bigInt % num;

                result.Add(bigInt.ToString());
            }

            return result;
        }

        protected string RSADecrypt(List<string> input)
        {
            string result = "";

            BigInteger bigInt;

            foreach (string item in input)
            {
                bigInt = new BigInteger(Convert.ToDouble(item));
                bigInt = BigInteger.Pow(bigInt, (int)d);

                BigInteger num = new BigInteger((int)n);

                bigInt = bigInt % num;

                int index = Convert.ToInt32(bigInt.ToString());
                char c = (char)index;
                result += c.ToString();
            }

            return result;
        }

        public void Encrypt(Stream input, Stream output)
        {
            if (IsSimple(p) && IsSimple(q))
            {
                StreamReader reader = new StreamReader(input);
                plaintext = reader.ReadToEnd();

                n = p * q;
                long m = (p - 1) * (q - 1);
                d = GetD(m);
                long e = GetE(m);

                List<string> ciphertext = RSAEncrypt(e, plaintext);

                string ciphTmp = "";
                foreach (string element in ciphertext)
                {
                    ciphTmp += element + " ";
                }

                byte[] byteArr = Encoding.ASCII.GetBytes(ciphTmp.TrimEnd(' '));
                output.Write(byteArr, 0, byteArr.Length);
                output.Position = 0;
            }
            else
                throw new Exception("numbers is not simple");
        }

        public void Decrypt(Stream input, Stream output)
        {
            List<string> inputList = new List<string>();

            StreamReader sReader = new StreamReader(input);
            string strTmp = sReader.ReadLine();

            inputList = strTmp.Split(' ').ToList();

            string decrypted = RSADecrypt(inputList);

            byte[] byteArr = Encoding.ASCII.GetBytes(decrypted);
            output.Write(byteArr, 0, byteArr.Length);
            output.Position = 0;
        }
    }
}