using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InfoSecurity
{
    public interface IHash
    {
        void Hash(Stream input, Stream output);
    }
}
