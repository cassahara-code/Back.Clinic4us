namespace Domain.Entities
{
    public class PatientEvaluations
    {
        public string? Id { get; set; }
        public bool? Active { get; set; }
        public string? Comment { get; set; }
        public bool? Completed { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string? FinalComments { get; set; }
        public DateTime? FinalDateToComplete { get; set; }
        public string? Form { get; set; }
        public string? Patient { get; set; }
        public string? Professional { get; set; }
        public string? UserWhoFinished { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
