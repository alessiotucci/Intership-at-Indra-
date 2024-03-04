using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixClone.Models
{
    public class Utente
    {
        public int Id { get; set; }
        
        public string NomeUtente { get; set; } = string.Empty;

        public DateTime DataCreazione {  get; set; }

        public string? Iban { get; set; }

        // Un utente puo avere piu profili 
        public ICollection<Profilo> Profili { get; set; } = []; // Collection Navigations
    }
}
