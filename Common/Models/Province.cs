namespace Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Province
    {
        [Key]
        public int ProvinceId { get; set; }

        [Display(Name ="Provincia")]
        [Required(ErrorMessage ="Debe registrar un {0}")]
        [MaxLength(50, ErrorMessage ="El campo {0} debe contener un máximo de {1} carácteres")]
        public string Name { get; set; }
    }
}
