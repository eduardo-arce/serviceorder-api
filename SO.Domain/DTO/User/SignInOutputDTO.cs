using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.Domain.DTO.User
{
    public class SignInOutputDTO
    {
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public bool IsAdmin { get; set; }
        public string AccessToken { get; set; } = null!;
    }
}
