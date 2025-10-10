using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Requests
{
    public class CreatePlansBenefitRequest
    {
        [Required(ErrorMessage = "O ID do plano é obrigatório")]
        public Guid PlanId { get; set; }

        [Required(ErrorMessage = "A descrição do benefício é obrigatória")]
        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres")]
        public string ItenDescription { get; set; } = string.Empty;

        public bool Covered { get; set; } = true;
    }
}
