using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbvotousuario))]
    public partial class tbvotousuario
    {
        void ss()
        {

        }
    }
    public interface itbvotousuario
    {
        [Key]//indicamos en es la llave de la tabla
        [ScaffoldColumn(false)]
        object idlugar { get; set; }

        [Key]//indicamos en es la llave de la tabla
        [ScaffoldColumn(false)]
        object idusuario { get; set; }

        [Display(Name = "Scor")]//nombre votos de los labels
        [Editable(false)]//no se podra editar
        object scor { get; set; }//scor votos de la columna

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
        object idvotousuario { get; set; }
    }
}