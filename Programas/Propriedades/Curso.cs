using System;
using System.Collections.Generic;

namespace ExemplosFundamentos.Programas.Propriedades
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<ClassePessoa> Alunos { get; set; }

        public Curso()
        {
            Alunos = new List<ClassePessoa>();
        }

        public void AdicionarAluno(ClassePessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAlunos(ClassePessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"Nº {count+1} - {Alunos[count].Nome_Completo}";
                Console.WriteLine(texto);
            }
        

        }
    }
}

