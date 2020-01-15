using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO
{
	class Pessoa
	{
		public String nome { get; set; }
		public int idade { get; set; }

		public Pessoa(String nome, int idade)
		{
			this.nome = nome;
			this.idade = idade;
		}
		public Pessoa()
		{
		}

		public void tiraMenor(List<Pessoa> pessoa)
		{
			for (int i = 0; i < pessoa.Count; i++)
			{
				if ( idade < 18)
				{
					pessoa.RemoveAt(i);
				}
			}
		}
	}
}
