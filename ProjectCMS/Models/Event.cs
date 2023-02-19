using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCMS.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime First_Closure { get; set; }
        public DateTime Last_Closure { get; set;}

        public int CateId { get; set; }
        [ForeignKey("Category")]
        public Category Category { get; set; }
        public ICollection<Idea> Ideas { get; set; }
    }
}
