using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SO.Domain.Entity
{
    public class ImageEntity
    {
        public ImageEntity(
            string name,
            string serviceOrderId
        )
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            HashName = $"{Guid.NewGuid()}";
            ServiceOrderId = serviceOrderId;
        }

        public string Id { get; private set; } = null!;
        public string Name { get; set; } = null!;
        public string HashName { get; private set; }
        public string ServiceOrderId { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(ServiceOrderId))]
        public ServiceOrderEntity ServiceOrderEntity { get; set; } = null!;
    }
}
