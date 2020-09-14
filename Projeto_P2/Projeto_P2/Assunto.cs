using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Assunto
{
	public string titulo;
	public string fonte;


	public void imprimirAssunto()
	{
		Console.WriteLine("-------------------Assunto--------------------- ");
		Console.WriteLine("Título Da Mensagem: " + titulo);
		Console.WriteLine("Fonte Da Mensagem: " + fonte);
	}

}
