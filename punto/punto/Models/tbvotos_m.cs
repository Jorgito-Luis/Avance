using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbvotos))]
    public partial class tbvotos
    {
        void ss()
        {

        }
    }
    public interface itbvotos
    {
        [Display(Name = "titulo")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        [MaxLength(30, ErrorMessage = "No maximo de 30 caracteres")]
        [StringLength(30)]//max 30
        [MinLength(2)]//debe tener por lo menos 2 caracteres
        object titulo { get; set; }

        [Display(Name = "total votos")]//nombre votos de los labels
        [Editable(false)]//no se podra editar
        object total_votes { get; set; }//total votos de la columna

        [Display(Name = "total value")]//nombre votos de los labels
        [Editable(false)]//no se podra editar
        object total_volue { get; set; }//total value de la columna

        [Display(Name = "used ips")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto...!!!")]
        [Editable(false)]//no se podra editar
        [MaxLength(50, ErrorMessage = "No maximo de 50 caracteres")]
        [StringLength(50)]//max 50
        object used_ips { get; set; }//used ips de la columna

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
        object id { get; set; }
    }
      
}