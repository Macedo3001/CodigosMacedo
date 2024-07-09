using System;

namespace ExemplosFundamentos.Programas.Propriedades
{
    public class ClassePessoa
    {
        private string _nome;
        private int _idade;

        // Construtor padrão com valores padrão
        public ClassePessoa()
        {
            Nome = "Nome Padrão"; // Definindo valor padrão para Nome
            Sobrenome = "Sobrenome Padrão"; // Definindo valor padrão para Sobrenome
        }

        // Construtor com parâmetros
        public ClassePessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome 
        { 
            get => _nome.ToUpper();
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Esse campo precisa ser preenchido.");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string Nome_Completo => $"{Nome} {Sobrenome}";

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Digite uma idade valida");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome_Completo}, Idade: {Idade}");
        }
    }
}

