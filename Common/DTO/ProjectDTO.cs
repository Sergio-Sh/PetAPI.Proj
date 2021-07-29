namespace WebAPI.Proj.Common.DTO
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Deadline { get; set; }
        public string CreatedAt { get; set; }
    }
}
