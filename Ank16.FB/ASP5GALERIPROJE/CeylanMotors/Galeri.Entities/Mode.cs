using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entities
{
    public class Mode: BaseEntity
    {
        public string Name { get; set; }
        public int MarkaId { get; set; }
        [ForeignKey("MarkaId")]
        public Marka Marka { get; set; }

    }
}
