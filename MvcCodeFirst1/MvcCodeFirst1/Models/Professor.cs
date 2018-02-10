using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

 
namespace MvcCodeFirst1.Models
{
    public class Professor
    {
        [Key , Column(Order = 0)]
        public int IDProfessor { get; set; }

        [Required(ErrorMessage = "Digite o nome do professor"), Column(Order = 1)]      
        [MinLength(8, ErrorMessage="O tamanho minimo são de 8 caracteres.")]


        public string Nome { get; set; }
        public string Telefone { get; set; }

        [DisplayFormat(DataFormatString= "{ 0: n2}",
            ApplyFormatInEditMode = true, NullDisplayText="Sem remuneração")]
        [Range(1200,25000, ErrorMessage= "O valor do sálario devera estar entre R$1.200 e R$ 25.000")]

        public decimal? Salario { get; set; }

        [Display(Name = "Twitwer/blog")]
        [Column("ContatoDigital", Order = 5)]
        public string TwitterBlog { get; set; }

        public string materia { get; set; }

        public bool Disponivel { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Admissão { get; set;}

        public List<Aluno> Alunos { get; set; }

        public List<Topico> Topicos { get; set; }



    }
}