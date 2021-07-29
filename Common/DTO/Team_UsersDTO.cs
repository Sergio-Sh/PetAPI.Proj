using System.Collections.Generic;

namespace WebAPI.Proj.Common.DTO
{
    public class Team_UsersDTO
    {
        public int Id { get; set; }
        public string TimeName { get; set; }

        public List<string> Users { get; set; }
    }
}
