using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class LocationEntity
    {
        [Key]
        [StringLength(50)]
        public string LocationId { get; set; }

        [Required]
        [StringLength(250)]
        public string LocationName { get; set; }
        public bool IsOrigin { get; set; }
        public bool IsDestination { get; set; }
        public DateTime Registration { get; set; }

        public ICollection<VehicleEntity> Vehicles { get; set; }
    }
}
