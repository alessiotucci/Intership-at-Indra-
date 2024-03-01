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
        
        [MaxLength(50)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime Data_Subscription {  get; set; }

        [StringLength(17)]
        public string? Iban { get; set; }

        // Un utente puo avere piu profili 
        public ICollection<Profilo> Profili { get; set; } // Collection Navigations
    }
}
