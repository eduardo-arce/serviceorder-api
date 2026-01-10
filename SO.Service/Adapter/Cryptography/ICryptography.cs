using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.Service.Adapter.Cryptography
{
    public interface ICryptography
    {
        string Hash(string plaintext);
        bool Compare(string plaintext, string hash);
    }
}
