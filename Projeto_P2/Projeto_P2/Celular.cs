using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Celular
{
	public int id_celular;
	public string contato;
	public MotoristaUber motoristaUber;

	public void imprimirCelular()
	{
		Console.WriteLine("-------------------Celular--------------------- ");
		Console.WriteLine("\t Identificaçao do Celular: " + id_celular);
		Console.WriteLine("\t Numero de contato: " + contato);
	}

	
}