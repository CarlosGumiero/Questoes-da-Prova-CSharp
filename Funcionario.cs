using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO
{
    class Funcionario
    {
		public String nome { get; set; }
		public int idade { get; set; }
		public float salario { get; set; }

		public Funcionario()
		{

		}

		public Funcionario(String nome, int idade, float salario)
		{
			this.nome = nome;
			this.idade = idade;
			this.salario = salario;
		}

		public float bonificacao()
		{
			return salario;
		}
	}
}
