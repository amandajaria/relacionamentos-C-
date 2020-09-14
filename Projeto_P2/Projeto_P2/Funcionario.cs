using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Funcionario
{
	public int id_funcionario;

	public string nome_funcionario;


	public void imprimirFuncionario()
	{
		Console.WriteLine("-------------------Funcionário--------------------- ");
		Console.WriteLine("id funcionário: " + id_funcionario);
        Console.WriteLine("nome funcionário: " + nome_funcionario);
    }

	

}

