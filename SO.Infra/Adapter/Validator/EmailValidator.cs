using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using SO.Service.Adapter.Validator;

namespace SO.Infra.Adapter.Validator
{
    public class EmailValidator : IEmailValidator
    {
        public bool Validate(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(email);

            return match.Success;
        }
    }
}
