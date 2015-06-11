using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbpersona))]
        public partial class tbpersona
        {
           void ss(){
           
           }
        }
        public interface itbpersona{
            [Display(Name="Tu nombre")]//nombre de los labels
            [DataType(DataType.Text,ErrorMessage="Tonto...!!!")]
            [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
            [Editable(false)]//no se podra editar
            [MaxLength(20,ErrorMessage="No maximo de 20 caracteres")]
            [StringLength(20)]//max 20
            [Required]
            [Range(60000, 15000000)]
            object nombre {get; set; }//nombre de la columna

            [Display(Name="Ap. Paterno")]//nombre de los labels
            [DataType(DataType.Text,ErrorMessage="Tonto...!!!")]
            [Editable(false)]//no se podra editar
            [MaxLength(20,ErrorMessage="No maximo de 20 caracteres")]
            [StringLength(20)]//max 20
            object paterno {get; set; }//paterno de la columna

            [Display(Name="Ap. Materno")]//nombre de los labels
            [DataType(DataType.Text,ErrorMessage="Tonto...!!!")]
            [Editable(false)]//no se podra editar
            [MaxLength(20,ErrorMessage="No maximo de 20 caracteres")]
            [StringLength(20)]//max 20
            object materno {get; set; }//materno de la columna

            [Display(Name="C.I.")]//nombre de los labels
            [DataType(DataType.Text,ErrorMessage="Tonto...!!!")]
            [Editable(false)]//no se podra editar
            [Range(70000, 1000000)]
            object ci {get; set; }//ci de la columna

            [Display(Name="Fecha de Nacimiento")]//nombre de los labels
            [DataType(DataType.Text,ErrorMessage="Tonto...!!!")]
            [Editable(false)]//no se podra editar
            object fechanac {get; set; }//fecha nacimiento de la columna

            [Display(Name="Fecha de creacion")]//nombre de los labels
            [DataType(DataType.Text,ErrorMessage="Tonto...!!!")]
            [Editable(false)]//no se podra editar
            object fechacreacion {get; set; }//fecha creacion de la columna

            [Display(Name="Fecha de modificacion")]//nombre de los labels
            [DataType(DataType.Text,ErrorMessage="Tonto...!!!")]
            [Editable(false)]//no se podra editar
            object fechamodificacion {get; set; }//fecha modificacion de la columna

            [Required]//debe tener algo de informacion
            object estado { get; set; }

            [Key]//indicamos en es la llave de la tabla
            [ScaffoldColumn(false)]
            object idpersona { get; set; }

        }
    }
}