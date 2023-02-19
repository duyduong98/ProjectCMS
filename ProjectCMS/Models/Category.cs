﻿namespace ProjectCMS.Models
{
    public class Category
    {
        public int CateId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime AddedDate { get; set; }
        public ICollection <Event> Events { get; set;}
    }
}
