﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCMS.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Phone { get; set; }
        public DateOnly DoB { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        public DateTime AddedDate { get; set; }
        public int Role { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreate { get; set; }
        public DateTime TokenExpires { get; set; }

        public int DepID { get; set; }
        [ForeignKey("Department")]
        public Department department { get; set; }
    }
}
