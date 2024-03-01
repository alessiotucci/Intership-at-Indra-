using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixClone.Models
{
    public class Profilo
    {
        [Required]
        public int Id { get; set; }

        // Profilo appartiene solo ad un Utente
        [Required]
        [ForeignKey("Utente")]
        public int Id_Utente { get; set; }
        public Utente Utente { get; set; } // Navigation property;

        [Required]
        [MaxLength(15)]
        public string Nome { get; set; } = string.Empty;

        public ICollection<Video>? VideoVisti { get; set; }

    }
}
