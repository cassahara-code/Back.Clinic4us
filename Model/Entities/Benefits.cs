using Clinic4Us.Domain.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("benefits")]
    public class Benefits : Base
    {
        public string? Description { get; set; }
    }
}
