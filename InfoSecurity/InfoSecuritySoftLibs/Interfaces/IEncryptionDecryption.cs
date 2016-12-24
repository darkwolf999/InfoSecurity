using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InfoSecurity
{
    public interface IEncryptionDecryption
    {
        void Encrypt(Stream input, Stream output);
        void Decrypt(Stream input, Stream output);
    }
}