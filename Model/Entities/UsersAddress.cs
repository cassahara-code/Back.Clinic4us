using Clinic4Us.Domain.Model;
using System;

namespace Model.Entities
{
    public class UsersAddress : Base
    {
        public int? UserId { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string? Complement { get; set; }
        public string? PostalCode { get; set; }
        public string? Neighborhood { get; set; }
        public bool? MainAddress { get; set; }
        public bool? Active { get; set; }
        public int? UpdatedBy { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation property
        public User? User { get; set; }
    }
}
