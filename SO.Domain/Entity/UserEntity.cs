using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SO.Domain.Entity
{
    public class UserEntity
    {
        public UserEntity(
            string email,
            string userName,
            string password,
            bool isAdmin,
            bool isActive
        )
        {
            Id = Guid.NewGuid().ToString();
            Email = email;
            UserName = userName;
            Password = password;
            IsAdmin = isAdmin;
            IsActive = isActive;
            CreatedAt = DateTime.Now;
            UpdatedAt = null;
        }

        public string Id { get; private set; } = null!;
        public string Email { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

        public ICollection<ServiceOrderEntity> ServiceOrders { get; set; }

        public void Update()
        {
            UpdatedAt = DateTime.Now;
        }
    }
}
