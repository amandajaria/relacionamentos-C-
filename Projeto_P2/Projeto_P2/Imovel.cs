using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Imovel
{
	public int id_imovel;

	public string endereco;

	public void imprimirImovel()
	{
		Console.WriteLine("-------------------Imovel--------------------- ");
		Console.WriteLine("Codigo do Imovel: " + id_imovel);
		Console.WriteLine("Endereço: " + endereco);
	}

}