using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Requests
{
    public class UpdateEntityRequest : CreateEntityRequest
    {
        [Required]
        public Guid Id { get; set; }
        public Guid? Creator { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
