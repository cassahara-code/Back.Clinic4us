using System;
using System.Collections.Generic;

namespace Application.Commands.ViewModels
{
    public class PlansBenefitViewModel
    {
        //public Guid Id { get; set; }
        //public Guid? PlanId { get; set; }
        public string? ItenDescription { get; set; }
        public bool? Covered { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
