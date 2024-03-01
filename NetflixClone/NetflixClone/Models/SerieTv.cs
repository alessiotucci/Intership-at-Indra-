using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixClone.Models
{
    public class SerieTv : Video
    {
        [Required]
        public bool Completata { get; set; }
         
    }
}
