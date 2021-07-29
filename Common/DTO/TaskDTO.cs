using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Proj.Common.DTO
{
    public class TaskDTO
    {
        [Required]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int PerformerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
        public TaskState State { get; set; }
        public DateTime CreatedAt { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime FinishedAt { get; set; }
    }
    public enum TaskState
    {
        ToDo,
        InProgress,
        Done,
        Canceled
    }
}
