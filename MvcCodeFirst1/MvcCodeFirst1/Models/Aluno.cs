using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcCodeFirst1.Models
{
    public class Aluno
    {

        [Key]
        public int IDAluno { get; set; }

        [DisplayName("Pofessor")]
        public int IDProfessor { get; set; }

        [Required(ErrorMessage = "O nome não pode estar em branco")]
        [MaxLength(50), MinLength(5)]
        public string NomeAluno { get; set; }

        [Required(ErrorMessage = "Digite o email")]
        [StringLength(250)]
        public string Email { get; set;  }

        [Range(1980, 2020, ErrorMessage = "esta fora do intervalo das datas exigidas")]

        public bool Aprovado { get; set; }
        public DateTime Inscricao { get; set; }

        public virtual Professor Professor { get; set; }
    }
}