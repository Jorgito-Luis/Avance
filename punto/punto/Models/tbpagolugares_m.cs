using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbpagolugares))]
    public partial class tbpagolugares
    {
        void ss()
        {

        }
    }
    public interface itbpagolugares
    {
        [Key]//indicamos en es la llave de la tabla
        [ScaffoldColumn(false)]
        object idpago { get; set; }

        [Key]//indicamos en es la llave de la tabla
        [ScaffoldColumn(false)]
        object idlugar { get; set; }

        [Display(Name = "Fecha")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        object fecha { get; set; }//fecha de la columna

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
        object idlugarpagos { get; set; }
    }
}