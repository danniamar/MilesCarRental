using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class VehicleEntity
    {
        [Key]
        [StringLength(50)]
        public string VehicleId { get; set; }
        [Required]
        [StringLength(100)]
        public string VehicleName { get; set; }
        [Required]
        public int VehicleCapacity { get; set; }
        public int QuantityLargeSuitcases { get; set; }
        public int QuantitySmallSuitcases { get; set; }
        [Required]
        [StringLength (20)]
        public string Transmission { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        public string LocationId { get; set; }
        public LocationEntity Location { get; set; }
    }
}
