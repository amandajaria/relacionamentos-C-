using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Gerente
{
	public int id_gerente;
	public string descricao_gerente;
	public Departamento departamento;

	public void imprimirGerente()
	{
		Console.WriteLine("-------------------Gerente--------------------- ");
		Console.WriteLine("Identificação do Gerente: " + id_gerente);
		Console.WriteLine("Descrição da Função: " + descricao_gerente);

		if(departamento != null)
		{
			Console.WriteLine("-------------------Departamento--------------------- ");
			Console.WriteLine("\t Identificação do Departamento: " + departamento.id_departamento);
			Console.WriteLine("\t Descrição do Departamento: " + departamento.descricao_departamento);
		}

	}

}
