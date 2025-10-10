namespace Domain.Entities
{
    public class FormsCategorys
    {
        public string? Id { get; set; }
        public string? CalcResultForm { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public bool? EvaluationPerCategory { get; set; }
        public string? Form { get; set; }
        public int? Ordenation { get; set; }
        public string? Parent { get; set; }
        public string? ScaleEvaluation { get; set; }
        public string? ScaleResult { get; set; }
        public string? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Slug { get; set; }
    }
}
