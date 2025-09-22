using System;
using System.Collections.Generic;

namespace Application.Commands.ViewModels
{
    public class PlansBenefitViewModel
    {
        public long Id { get; set; }
        public long? PlanId { get; set; }
        public string? ItenDescription { get; set; }
        public bool? Covered { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
