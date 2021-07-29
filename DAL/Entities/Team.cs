using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using WebAPI.Proj.DAL.Entities.Interface;


namespace WebAPI.Proj.DAL.Entities
{
    public class Team : IEntity
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<User> Users { get; set; }
    }
}
