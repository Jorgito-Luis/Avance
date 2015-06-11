using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbcatlugar))]
    public partial class tbcatlugar
    {
        void ss()
        {

        }
    }
    public interface itbcatlugar
    {
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
        object idcatlugares { get; set; }

        [Key]//indicamos en es la llave de la tabla
        [ScaffoldColumn(false)]
        object idcategorias { get; set; }

        [Key]//indicamos en es la llave de la tabla
        [ScaffoldColumn(false)]
        object idlugares { get; set; }
    }
}