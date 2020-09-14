using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Departamento
{
	public int id_departamento;
	public string descricao_departamento;
	public Gerente gerente;

	public void imprimirDepartamento()
	{
		Console.WriteLine("-------------------Departamento--------------------- ");
		Console.WriteLine("Identificação do Departamento: " + id_departamento);
		Console.WriteLine("Descrição do Departamento: " + descricao_departamento);

		if (gerente != null)
		{
			Console.WriteLine("---------------------Gerente----------------------- ");
			Console.WriteLine("\t Identificação do Gerente: " + gerente.id_gerente);
			Console.WriteLine("\t Descrição do Gerente: " + gerente.descricao_gerente);
		}
	}

}