using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUygulamaIdentity.Models
{
    public class Work
    {
        public int WorkId { get; set; }

        public int InteriorWorkId { get; set; }
        public InteriorWork InteriorWork { get; set;}

        public int OutsideWorkId { get; set; }
        public OutsideWork OutsideWork { get; set; }

        public int FurnitureWorkId { get; set; }
        public FurnitureWork FurnitureWork { get; set; }



    }
}
