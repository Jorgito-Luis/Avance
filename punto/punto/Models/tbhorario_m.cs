using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbhorario))]
    public partial class tbhorario
    {
        void ss()
        {

        }
    }
    public interface itbhorario
    {
        [Display(Name = "Inicio")]//nombre de los labels
        [Required]
        [Range(10000, 24000000)]
        object inicio { get; set; }//inicio de la columna

        [Display(Name = "Fin")]//nombre de los labels
        [Required]
        [Range(10000, 24000000)]
        object fin { get; set; }//fin de la columna

        [Key]//indicamos en es la llave de la tabla
        [ScaffoldColumn(false)]
        object idlugares { get; set; }

        [Display(Name = "Tipo")]//nombre de los labels
        [Editable(false)]//no se podra editar
        object tipo { get; set; }//tipo de la columna

        [Display(Name = "Fecha de creacion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        object fechacreacion { get; set; }//fecha creacion de la columna

        [Display(Name = "Fecha de modificacion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        object fechamodificacion { get; set; }//fecha modificacion de la columna

        [Required]//debe tener algo de informacion
        object estado { get; set; }

        [Key]//indicamos en es la llave de la tabla
        [ScaffoldColumn(false)]
        object idhorario { get; set; }

    }
}