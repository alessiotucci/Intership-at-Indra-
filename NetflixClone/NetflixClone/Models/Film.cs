using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixClone.Models
{
    public class Film : Video
    {
        [Required]
        public int DurataInMin { get; set; }
        [Required]
        public DateOnly DataInizio { get; set; }

        public DateOnly? DataFine { get; set; }
    }
}
