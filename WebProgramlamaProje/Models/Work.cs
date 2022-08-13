using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaProje.Models
{
    public class Work
    {

        public int Id { get; set; }

        public int? InteriorWorkId { get; set; }
        [ForeignKey("InteriorWorkId")]
        public InteriorWork InteriorWork { get; set; }

        public int? OutdoorWorkId { get; set; }
        [ForeignKey("OutdoorWorkId")]
        public OutdoorWork OutdoorWork { get; set; }

        public int? FurnitureWorkId { get; set; }
        [ForeignKey("FurnitureWorkId")]
        public FurnitureWork FurnitureWork { get; set; }

    }
}
