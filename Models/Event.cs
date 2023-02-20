using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectCMS.Models
{
    public class Event
    {
        [Key]
        public int EvId { get; set; }
        public string Name { get; set; }
        
        public DateOnly  First_Closure { get; set; }
        
        public DateOnly  Last_Closure { get; set;}

        public int CateId { get; set; }

        [ForeignKey("CateId")]
        public Category Category { get; set; }
        public ICollection<Idea> Ideas { get; set; }
    }
}
