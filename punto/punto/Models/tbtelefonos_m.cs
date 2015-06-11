using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbtelefonos))]
    public partial class tbtelefonos
    {
        void ss()
        {

        }
    }
    public interface itbtelefonos
    {
        [Display(Name = "Numero")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        [Required]
        [Range(10000, 7000000)]
        object numero { get; set; }//numero de la columna

        [Display(Name = "tipo")]//nombre de los labels
        [Editable(false)]//no se podra editar
        object tipo { get; set; }//tipo de la columna

        [Display(Name = "Codigo area")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        [Required]
        [Range(10000, 4000000)]
        object codigoarea { get; set; }//codigoarea de la columna

        [Key]//indicamos en es la llave de la tabla
        [ScaffoldColumn(false)]
        object idlugar { get; set; }//id lugar de la columna

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
        object idtelefonos { get; set; }
    }
}