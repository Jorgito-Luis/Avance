using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itblugares))]
    public partial class tblugares
    {
        void ss()
        {

        }
    }
    public interface itblugares
    {
        [Display(Name = "titulo")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        [MaxLength(30, ErrorMessage = "No maximo de 30 caracteres")]
        [StringLength(30)]//max 30
        [MinLength(2)]//debe tener por lo menos 2 caracteres
        object titulo { get; set; }

        [Display(Name = "direccion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        [MaxLength(50, ErrorMessage = "No maximo de 50 caracteres")]
        [StringLength(50)]//max 50
        object direccion { get; set; }//direccion de la columna

        [Display(Name = "descripcion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        [MaxLength(50, ErrorMessage = "No maximo de 50 caracteres")]
        [StringLength(50)]//max 50
        object descripcion { get; set; }//descripcion de la columna

        [Display(Name = "web")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        object web { get; set; }//web de la columna

        [Display(Name = "Imagen")]//nombre de los labels
        [Editable(false)]//no se podra editar
        object imagen { get; set; }//imagen de la columna

        [Display(Name = "email")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        object email { get; set; }//email de la columna

        [Display(Name = "Lat.")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        [Range(70000, 1000000)]
        object lat { get; set; }//lat de la columna

        [Display(Name = "Long")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        [Range(70000, 1000000)]
        object longi { get; set; }//long de la columna

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
        object idlugar { get; set; }
    }
}