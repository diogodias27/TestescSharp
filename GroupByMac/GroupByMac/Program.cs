using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupByMac
{
    class Program
    {
        private static IList<Aluno> listaAlunos = GetAlunos();

        static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>()
           {
          new Aluno() { AlunoId = 1, Curso = "Fisica", Nome = "Vitor", Sexo = 'M' },
          new Aluno() { AlunoId = 2, Curso = "Quimica", Nome = "Jorge", Sexo = 'M' },
          new Aluno() { AlunoId = 3, Curso = "Engenharia", Nome = "Bernardo", Sexo = 'M' },
          new Aluno() { AlunoId = 4, Curso = "Moda", Nome = "Danusa", Sexo = 'F' },
          new Aluno() { AlunoId = 5, Curso = "Moda", Nome = "Carla", Sexo = 'F' },
          new Aluno() { AlunoId = 6, Curso = "Fisica", Nome = "Helio", Sexo = 'M' },
          new Aluno() { AlunoId = 7, Curso = "Engenharia", Nome = "Bianca", Sexo = 'F' },
          new Aluno() { AlunoId = 8, Curso = "Quimica", Nome = "Vilma", Sexo = 'F' },
          new Aluno() { AlunoId = 9, Curso = "Engenharia", Nome = "Amanda", Sexo = 'F' }
          };
            return alunos;
        }


        static void Main(string[] args)
        {
            var listaAgrupada = from aluno in listaAlunos
                                group aluno by aluno.Curso into cursoGrupo
                                orderby cursoGrupo.Key ascending
                                select cursoGrupo;

            foreach (var grupo in listaAgrupada)
            {
                Console.WriteLine(string.Format($"Curso:{grupo.Key}"));
                foreach (var aluno in grupo)
                {
                    Console.WriteLine($"\t{aluno.Nome}.{aluno.Sexo}");
                }
            }

            AgruparPorCursoLetraNome();
        

            Console.ReadKey();
        }

        static void AgruparPorCursoLetraNome()
        {
            var listaAgrupada = from aluno in listaAlunos
                                group aluno by new
                                {
                                    aluno.Curso,
                                    aluno.Sexo
                                };

            foreach (var grupo in listaAgrupada)
            {
                Console.WriteLine(string.Format("Curso : {0}", grupo.Key.Curso, grupo.Key.Sexo));

                foreach (var aluno in grupo)
                {
                    Console.WriteLine($"\t{aluno.Nome} - {aluno.Sexo}");
                }
            }
        }



    }
}
