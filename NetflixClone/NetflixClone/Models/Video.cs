using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixClone.Models
{
    public  class Video
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public string Sinossi { get; set; } = string.Empty ;

        [Required]
        public int Voto { get; set; }

        public ICollection<Profilo>? Visualizzatori { get; set; }
    }
}
