using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCMS.Models
{
    public class Category
    {
        [Key]
        public int CateId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        
        public DateOnly AddedDate { get; set; }
        public ICollection <Event> Events { get; set;}
    }
}
