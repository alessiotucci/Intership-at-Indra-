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
        public int Id { get; set; }

        public int UtenteId { get; set; }
        public Utente Utente { get; set; } = new Utente(); // Navigation property;

        public string Nome { get; set; } = string.Empty;

        public ICollection<Video>? VideoVisti { get; set; }

    }
}
