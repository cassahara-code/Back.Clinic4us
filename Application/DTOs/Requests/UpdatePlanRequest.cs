using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Requests
{
    public class UpdatePlanRequest
    {
        [Required(ErrorMessage = "O ID � obrigat�rio")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O t�tulo do plano � obrigat�rio")]
        [StringLength(250, ErrorMessage = "O t�tulo deve ter no m�ximo 250 caracteres")]
        public string PlanTitle { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "A descri��o deve ter no m�ximo 500 caracteres")]
        public string? Description { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "O valor mensal deve ser maior que zero")]
        public decimal? MonthlyValue { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "O valor anual deve ser maior que zero")]
        public decimal? AnualyValue { get; set; }

        public List<UpdatePlanBenefitRequest>? PlansBenefits { get; set; }
    }

    public class UpdatePlanBenefitRequest
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "A descri��o do benef�cio � obrigat�ria")]
        [StringLength(500, ErrorMessage = "A descri��o deve ter no m�ximo 500 caracteres")]
        public string ItenDescription { get; set; } = string.Empty;

        public bool Covered { get; set; } = true;
    }
}