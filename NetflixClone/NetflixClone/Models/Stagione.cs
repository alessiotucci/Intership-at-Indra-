using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixClone.Models
{
    public class Stagione
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Serie")]
        public int Id_Serie { get; set; }
        [Required]
        public int NumeroStagione { get; set; }
        [Required]
        public DateOnly InizioVisibilita { get; set; }

        public DateOnly? FineVisibilita { get; set; }

    }
}
