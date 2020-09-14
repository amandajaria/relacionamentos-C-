using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Aluguel
{
	public int id_locacao;
	public float valor;
	public string descricao;

	public void inserirDados(int id_locacao, float valor, Imovel o_Imovel)
	{
		this.id_locacao = id_locacao;
		this.valor = valor;
		descricao = o_Imovel.endereco;
	}
	public void imprimirAluguel()
	{
		Console.WriteLine("-------------------Aluguel--------------------- ");
		Console.WriteLine("Codigo da Locação: " + id_locacao);
		Console.WriteLine("Valor da Locação: " + valor);
		

	}

}
