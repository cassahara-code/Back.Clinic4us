using Clinic4Us.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{

    [Table("users")]
    public class User : Base
    {
        public string? Name { get; set; }
        public string? Document { get; set; }
        public string? DocumentType { get; set; }
        public string? CompanyName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public bool? Active { get; set; }

        // Navigation properties
        public ICollection<UsersAddress>? Addresses { get; set; }
        public ICollection<PlansSubscription>? PlansSubscriptions { get; set; }
    }
}
