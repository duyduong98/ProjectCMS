namespace ProjectCMS.Models
{
    public class Department
    {
        public int DepId { get; set; }
        public string Name { get; set;}
        public ICollection<User> Users { get; set; }
    }
}
