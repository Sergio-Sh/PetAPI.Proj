using System.Collections.Generic;

namespace WebAPI.Proj.Common.DTO
{
    public class Users_TaskDTO
    {
        public UserDTO User { get; set; }
        public List<TaskDTO> Tasks { get; set; }
    }
}
