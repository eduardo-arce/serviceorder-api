using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SO.Domain.Entity
{
    public class CheckListEntity
    {
        public CheckListEntity(
            string question,
            bool isActive
        )
        {
            Id = Guid.NewGuid().ToString();
            Question = question;
            IsActive = isActive;
        }

        public string Id { get; private set; } = null!;
        public string Question { get; set; } = null!;
        public bool IsActive { get; set; }

        [JsonIgnore]
        public ICollection<CheckListResultEntity> CheckListResults { get; set; }
    }
}
