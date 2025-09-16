using Clinic4Us.Domain.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("usersAddress")]
    public class UsersAddress : Base
    {
        public long? UserId { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string? Complement { get; set; }
        public string? PostalCode { get; set; }
        public string? Neighborhood { get; set; }
        public bool? MainAddress { get; set; }
        public bool? Active { get; set; }
        public long? UpdatedBy { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation property
        public User? User { get; set; }
    }
}
