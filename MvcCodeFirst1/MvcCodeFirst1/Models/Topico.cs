using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCodeFirst1.Models
{
    public class Topico
    {
        [Key]
        public int IDtopico { get; set; }

        [DisplayName("Professor")]

        [Required(ErrorMessage = "Digite o tópico")]
        [MaxLength(100), MinLength(5)]
        public string Descricao { get; set; }

        public virtual Professor Professor { get; set; }
    }
}