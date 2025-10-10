using Clinic4Us.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("plansbenefits")]
    public class PlansBenefit : Base
    {
        public Guid? PlanId { get; set; }
        public string? ItenDescription { get; set; }
        public bool? Covered { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        // Navigation property
        public Plans? Plan { get; set; }
    }
}
