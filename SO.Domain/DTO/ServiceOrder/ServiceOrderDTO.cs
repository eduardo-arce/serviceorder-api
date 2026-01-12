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
    public class ServiceOrderDTO
    {
        public string Description { get; set; } = null!;
        public List<IFormFile> Images { get; set; } = null!;
        public string CheckListResultsJson { get; set; } = null!;

        [JsonIgnore]
        public List<CheckListResultDTO> CheckListResults =>
            JsonSerializer.Deserialize<List<CheckListResultDTO>>(CheckListResultsJson)
            ?? new();
    }
}
