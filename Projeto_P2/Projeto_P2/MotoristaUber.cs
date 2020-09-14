using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MotoristaUber
{
	public int id_motorista;
	public string nome_motorista;
	public string status;
	public Celular celular;

	public void imprimirMotorista()
	{
		//motorista de Uber
		Console.WriteLine("-------------------Motorista de Uber--------------------- ");
		Console.WriteLine("Identificaçao do Motorista: " + id_motorista);
		Console.WriteLine("Nome do Motorista: " + nome_motorista);
		Console.WriteLine("Status do Motorista: " + status);

		// celular
		
		celular.imprimirCelular();
	}

}
