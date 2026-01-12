using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SO.Domain.DTO.CheckList;

namespace SO.Domain.DTO.ServiceOrder
{
    public class ServiceOrderListingDTO
    {
        public string Id { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public ServiceOrderUserListingDTO User { get; set; } = null!;
        public List<ServiceOrderCheckListResultListingDTO> CheckList { get; set; } = null!;
        public List<ServiceOrderImageListingDTO> ImageList { get; set; } = null!;

    }

    public class ServiceOrderUserListingDTO
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class ServiceOrderCheckListResultListingDTO
    {
        public string Id { get; set; } = null!;
        public string Question { get; set; } = null!;
        public bool IsOk { get; set; }
    }

    public class ServiceOrderImageListingDTO
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Url { get; set; } = null!;
    }

}
