using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using WebAPI.Proj.DAL.Entities.Interface;


namespace WebAPI.Proj.DAL.Entities
{
    public class User : IEntity
    {
        [Required]
        public int Id { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
