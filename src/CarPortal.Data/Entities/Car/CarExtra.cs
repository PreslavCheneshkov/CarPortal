using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.Entities.Car
{
    public class CarExtra
    {
        [Required]
        [ForeignKey(nameof(Car))]
        public int CarId { get; set; }

        public virtual Car Car { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Extra))]
        public int ExtraId { get; set; }

        public virtual Extra Extra { get; set; } = null!;
    }
}
