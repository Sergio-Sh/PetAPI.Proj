using System;
using Newtonsoft.Json;

namespace WebAPI.Proj.Common.DTO
{
    public class TeamDTO
    {
        public int Id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
