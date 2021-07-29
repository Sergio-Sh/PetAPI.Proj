using System;
using Newtonsoft.Json;
using WebAPI.Proj.DAL.Enums;
using WebAPI.Proj.DAL.Entities.Interface;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebAPI.Proj.DAL.Entities
{
    public class Task : IEntity
    {
        [Required]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int PerformerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskState State { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime FinishedAt { get; set; }
    }
}
