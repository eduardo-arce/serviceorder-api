using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.Service.Adapter.Cryptography
{
    public interface IToken
    {
        string Generate(string id);
        string? Decode(string? token);
    }
}
