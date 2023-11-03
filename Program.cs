using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome:"Antonio", sobrenome: "Carlos");
Pessoa p2 = new Pessoa(nome:"Garcia", sobrenome: "Junior");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();


























// Pessoa p1 = new Pessoa();
// p1.Nome = "Antonio Carlos";
// p1.Sobrenome = "Garcia Junior";
// p1.Idade = 40;
// p1.Apresentar();
