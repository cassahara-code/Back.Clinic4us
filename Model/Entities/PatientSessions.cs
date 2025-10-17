namespace Domain.Entities
{
    public class PatientSessions
    {
        public string Id { get; set; } = default!;
        public bool? Active { get; set; }
        public string? Aproach { get; set; }
        public bool? DisregardPlan { get; set; }
        public string? GasScale { get; set; }
        public string? Guidance { get; set; }
        public string? Observation { get; set; }
        public string? Patient { get; set; }
        public string? PatientCondition { get; set; }
        public string? PatientConditionJustify { get; set; }
        public string? PatientPlan { get; set; }
        public string? PatientSituation { get; set; }
        public int? PlanEvolutionScale { get; set; }
        public string? ProfessionalSchedule { get; set; }
        public string? TherapeuticEvolution { get; set; }
        public string? TherapeuticResource { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}