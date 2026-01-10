using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using SO.Service.Adapter.Cryptography;
using Bcrypt = BCrypt.Net.BCrypt;

namespace SO.Infra.Adapter.Cryptography
{
    public class BcryptAdapter : ICryptography
    {
        public bool Compare(string plaintext, string hash)
        {
            bool isEqual = Bcrypt.Verify(plaintext, hash);

            return isEqual;
        }

        public string Hash(string plaintext)
        {
            string hash = Bcrypt.HashPassword(plaintext);

            return hash;
        }
    }
}
