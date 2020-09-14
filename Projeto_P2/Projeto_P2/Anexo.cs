using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Anexo
{
	public int id_anexo;

	public float tamanho;


	public void imprimirAnexo()
	{
		Console.WriteLine("-------------------Anexo--------------------- ");
		Console.WriteLine("id anexo: " + id_anexo);
        Console.WriteLine("tamanho anexo: " + tamanho);

    }

}

