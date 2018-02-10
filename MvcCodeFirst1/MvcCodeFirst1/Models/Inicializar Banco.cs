using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcCodeFirst1.Models
{
    public class Inicializar_Banco : DropCreateDatabaseAlways<BancoContexto>
    {
        protected override void Seed(BancoContexto context)
        {
            // criar alguns dados no banco
            new List<Professor>{
                 new Professor
                 {
                  Nome="Diogo dias",
                  materia = "teste c#",
                  Salario=4000,
                  Telefone="123456789",
                  TwitterBlog="http//weblogs.asp.net/renatohadad",
                  Admissão= new DateTime(2012,05,01)

                 }
            }
            base.Seed(context);
        }
    }
}