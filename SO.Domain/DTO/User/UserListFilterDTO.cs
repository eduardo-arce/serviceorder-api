using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.Domain.DTO.User
{
    public class UserListFilterDTO
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsActive { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
