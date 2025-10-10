using System.ComponentModel.DataAnnotations;

namespace Clinic4Us.Domain.Model
{
    public class Base
    {
        [Key]
        public Guid Id { get; set; }
    }
}
