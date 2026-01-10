using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SO.Domain.Entity
{
    public class CheckListResultEntity
    {
        public CheckListResultEntity(
            string checkListId,
            string serviceOrderId,
            bool isOk
        )
        {
            Id = Guid.NewGuid().ToString();
            CheckListId = checkListId;
            ServiceOrderId = serviceOrderId;
            IsOk = isOk;
        }

        public string Id { get; private set; } = null!;
        public string CheckListId { get; set; }
        public string ServiceOrderId { get; set; }
        public bool IsOk { get; set; }

        [ForeignKey(nameof(CheckListId))]
        public CheckListEntity CheckListEntity { get; set; } = null!;

        [ForeignKey(nameof(ServiceOrderId))]
        public ServiceOrderEntity ServiceOrderEntity { get; set; } = null!;
    }
}
