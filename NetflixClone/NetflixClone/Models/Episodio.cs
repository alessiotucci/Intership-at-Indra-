using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixClone.Models
{
    public class Episodio
    {
        [Required]
        public int Id { get; set; }

        [Required] //[ForeignKey(nameof(Id))]
        public int StagioneId { get; set; }
        public Stagione Stagione { get; set; } = new Stagione();

        [Required]
        public int NumeroEpisodio { get; set; }

        [Required]
        [MaxLength(50)]
        public string Titolo { get; set; } = string.Empty;

        public string? Sinossi {  get; set; }
    }
}
