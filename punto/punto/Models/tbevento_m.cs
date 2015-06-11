using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbevento))]
    public partial class tbevento
    {
        public void prueba() {
            //this.estado = 1*5;
        }
    }
    public interface itbevento {
        [Required]//debe tener algo de informacion
        object estado { get; set; }
        [MinLength(2)]//debe tener por lo menos 2 caracteres
        object titulo { get; set; }

        [Key]//indicamos en es la llave de la tabla
        object idevento { get; set; }

    }
    
}