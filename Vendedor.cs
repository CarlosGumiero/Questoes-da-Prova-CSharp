using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO
{
    class Vendedor : Funcionario
    {
		public Vendedor(String nome, int idade, float salario) : base(nome, idade, salario)
		{

		}

		public new float bonificacao()
		{
			return this.salario + 3000;
		}
	}
}
