namespace Domain.Entities
{
    public class PatientEvaluationResponses
    {
        public string? Id { get; set; }
        public string? Comments { get; set; }
        public string? Form { get; set; }
        public string? FormItem { get; set; }
        public string? Patient { get; set; }
        public string? PatientEvaluation { get; set; }
        public string? ScaleItem { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
