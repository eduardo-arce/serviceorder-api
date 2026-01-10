using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.Service.Adapter.Validator
{
    public interface IEmailValidator
    {
        bool Validate(string email);
    }
}
