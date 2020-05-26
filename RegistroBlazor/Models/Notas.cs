using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroBlazor.Models
{
    public class Notas
    {
        [Key]
        [Required(ErrorMessage = "El campo Id no puede estar vacío.")]
        [Range(0, 1000000, ErrorMessage = "El campo Id no puede ser menor que cero o mayor a 1000000.")]
        public int notasId { get; set; }
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm, yyyy}")]
        public DateTime fecha { get; set; }
        [Required(ErrorMessage = "El campo RUTA es requerido.")]
        [Url]
        public string ruta { get; set; }
        [Range(0, 10, ErrorMessage = "La importancia debe ser de 0 a 10.")]
        public int importancia { get; set; }

        public Notas()
        {
            notasId = 0;
            fecha = DateTime.Now;
            ruta = string.Empty;
            importancia = 0;
        }

    }
}
