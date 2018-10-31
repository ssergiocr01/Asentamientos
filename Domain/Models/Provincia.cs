using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Provincia
    {
        [Key]
        public int IDProvincia { get; set; }
        
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Nombre { get; set; }
    }
}
