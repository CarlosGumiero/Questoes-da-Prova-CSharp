using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO
{
    class Gerente : Funcionario
	{
		public Gerente()
		{

		}

		public Gerente(String nome, int idade, float salario) : base (nome, idade, salario)
		{
		}

		public new float bonificacao()
		{
			return this.salario + 10000;
		}
	}
}
