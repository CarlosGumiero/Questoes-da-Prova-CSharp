using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
			int maiorIdade = 0, qtdLista;
			String pessoaMaior = null;

			Pessoa p = new Pessoa();
			Pessoa p1 = new Pessoa("João", 15);
			Pessoa p2 = new Pessoa("Leandro", 21);
			Pessoa p3 = new Pessoa("Paulo", 17);
			Pessoa p4 = new Pessoa("Jessica", 18);

			List< Pessoa> listaPessoas = new List<Pessoa>();

			listaPessoas.Add(p1);
			listaPessoas.Add(p2);
			listaPessoas.Add(p3);
			listaPessoas.Add(p4);

			foreach (Pessoa pessoa in listaPessoas)
			{
				if (maiorIdade < pessoa.idade)
				{
					maiorIdade = pessoa.idade;
					pessoaMaior = pessoa.nome;
				}
			}

			Console.WriteLine("Questão 1: ");
			Console.WriteLine("A pessoa com a maior idade é: " + pessoaMaior + " com " + maiorIdade + " anos.");

			Console.WriteLine("");
			Console.WriteLine("Questão 2: ");

			qtdLista = listaPessoas.Count;

			Console.WriteLine("A lista tem " + qtdLista + " pessoas.");

				p.tiraMenor(listaPessoas);

			qtdLista = listaPessoas.Count;
			Console.WriteLine("A lista tem " + qtdLista + " pessoas.");
			Console.WriteLine("");

			Console.WriteLine("Questão 3: ");

			foreach (Pessoa pessoa in listaPessoas)
			{
				if (pessoa.nome == "Jessica")
				{
					Console.WriteLine(pessoa.nome + " está na lista, sua idade é de " + pessoa.idade + " anos.");
				}
			}
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");

			Gerente g1 = new Gerente("Robson", 33, 10000);
			Supervisor s1 = new Supervisor("Estefâno", 26, 8000);
			Vendedor v1 = new Vendedor("Robsclêison", 51, 5000);

			Console.WriteLine("O gerente " + g1.nome + " tem " + g1.idade + " anos e ganha R$" + g1.bonificacao() + " de salário com a bonificação.");
			Console.WriteLine("O supervisor " + s1.nome + " tem " + s1.idade + " anos e ganha R$" + s1.bonificacao() + " de salário com a bonificação.");
			Console.WriteLine("O vendedor " + v1.nome + " tem " + v1.idade + " anos e ganha R$" + v1.bonificacao() + " de salário com a bonificação.");
		}
    }
}
