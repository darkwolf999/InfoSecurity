using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InfoSecurity
{
    public interface ISign
    {
        void Sign(Stream input, Stream output);
        bool Verify(Stream input);
    }
}
