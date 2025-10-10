using Clinic4Us.Domain.Model;

namespace Domain.Entities
{
    public class FormItems : Base
    {
        public bool? Active { get; set; }
        public string? Category { get; set; }
        public bool? CommentsMandatory { get; set; }
        public string? CommentsMandatoryIf { get; set; }
        public string? Description { get; set; }
        public string? EvaluationScale { get; set; }
        public string? Form { get; set; }
        public bool? Mensurable { get; set; }
        public bool? MultipleResponses { get; set; }
        public int? MultipleResponsesMax { get; set; }
        public int? MultipleResponsesMin { get; set; }
        public int? Ordenation { get; set; }
        public string? Question { get; set; }
    }
}
