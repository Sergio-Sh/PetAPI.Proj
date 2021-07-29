using Newtonsoft.Json;
using System.Collections.Generic;
using WebAPI.Proj.DAL.Entities.Interface;
using System.ComponentModel.DataAnnotations;


namespace WebAPI.Proj.DAL.Entities
{
    public class Project : IEntity
    {
        [Required]
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public string Deadline { get; set; }
        public string CreatedAt { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
