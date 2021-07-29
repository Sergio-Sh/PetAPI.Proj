using System;
using Newtonsoft.Json;

namespace WebAPI.Proj.Common.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int TeamId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
