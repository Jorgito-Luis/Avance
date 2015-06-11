using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbcategorias))]
    public partial class tbcategorias
    {
        void ss()
        {

        }
    }
    public interface itbcategorias
    {
        [Display(Name = "nombre")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "No maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        object nombre { get; set; }//nombre de la columna

        [Display(Name = "Responsable")]//nombre de los labels
        [Editable(false)]//no se podra editar
        object responsable { get; set; }//responsable de la columna

        [Display(Name = "Padre")]//nombre de los labels
        [Editable(false)]//no se podra editar
        object padre { get; set; }//padre de la columna

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
        object idcategorias { get; set; }
    }
}