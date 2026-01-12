using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SO.Domain.Entity
{
    public class ServiceOrderEntity
    {
        public ServiceOrderEntity(
            string description,
            string userEntityId
        )
        {
            Id = Guid.NewGuid().ToString();
            Description = description;
            UserEntityId = userEntityId;
            CreatedAt = DateTime.Now;
            CheckListResults = new List<CheckListResultEntity>();
            Images = new List<ImageEntity>();
        }

        public string Id { get; private set; } = null!;
        public string Description { get; set; } = null!;
        public string UserEntityId { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public ICollection<CheckListResultEntity> CheckListResults { get; private set; }

        public ICollection<ImageEntity> Images { get; private set; }

        [JsonIgnore]
        [ForeignKey(nameof(UserEntityId))]
        public UserEntity UserEntity { get; set; } = null!;
    }
}
