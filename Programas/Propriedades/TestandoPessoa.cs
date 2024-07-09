using ExemplosFundamentos.Programas.Propriedades;

ClassePessoa p1 = new ClassePessoa
{
    Nome = "João",
    Sobrenome = "Emanuel",
    Idade = 14
};

ClassePessoa p2 = new ClassePessoa
{
    Nome = "Lucas",
    Sobrenome = "Emanuel",
    Idade = 14
};

Curso geografia = new Curso
{
    Nome = "Geografia"
};

geografia.AdicionarAluno(p1);
geografia.AdicionarAluno(p2);
geografia.ListarAlunos();







