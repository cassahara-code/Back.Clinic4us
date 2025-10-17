using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Requests
{
    public class CreatePlansBenefitRequest
    {
        [Required(ErrorMessage = "O ID do plano � obrigat�rio")]
        public Guid PlanId { get; set; }

        [Required(ErrorMessage = "A descri��o do benef�cio � obrigat�ria")]
        [StringLength(500, ErrorMessage = "A descri��o deve ter no m�ximo 500 caracteres")]
        public string ItenDescription { get; set; } = string.Empty;

        public bool Covered { get; set; } = true;
    }
}
