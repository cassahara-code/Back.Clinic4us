using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic4Us.Domain.Model
{
    public class Base
    {
        [Key]
        public long Id { get; set; }
    }
}
