using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    public class btusuario
    {
        void ss()
        {

        }
    }
    public interface itbpersona{
        [Display(Name = "Login")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "No maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        object login { get; set; }//login de la columna

        [Display(Name = "Password")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "No maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        object pass { get; set; }//password de la columna

        [Display(Name = "fid")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        object fid { get; set; }//fid de la columna

        [Display(Name = "femail")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        object femail { get; set; }//femail de la columna

        [Display(Name = "full mane")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "No maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        object pass { get; set; }//password de la columna

        [Required]//debe tener algo de informacion
        object estado { get; set; }

        [Key]//indicamos en es la llave de la tabla
        [ScaffoldColumn(false)]
        object idusuario { get; set; }
    }
}