using System.ComponentModel.DataAnnotations;
namespace TaskManagementSystem.Core.Entities
{
    public class TaskEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
    }
}
