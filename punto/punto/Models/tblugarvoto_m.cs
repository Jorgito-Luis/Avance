using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itblugarvoto))]
    public partial class tblugarvoto
    {
        void ss()
        {

        }
    }
    public interface itblugarvoto
    {
        [Display(Name = "Numero votos")]//nombre votos de los labels
        [Required]//debe tener algo de informacion
        [MinLength(2)]//debe tener por lo menos 2 caracteres
        object titulo { get; set; }

        [Display(Name = "Numero votos")]//nombre votos de los labels
        [Editable(false)]//no se podra editar
        object num_votos { get; set; }//nro votos de la columna

        [Display(Name = "total score")]//nombre score de los labels
        [Editable(false)]//no se podra editar
        object total_score { get; set; }//total score votos de la columna

        [Display(Name = "Rating")]//nombre de los labels
        [Editable(false)]//no se podra editar
        object rating { get; set; }//rating de la columna

        [Display(Name = "ID")]//nombre de los labels
        [Editable(false)]//no se podra editar
        object id { get; set; }//id de la columna

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
        object idvoto { get; set; }
    }
}