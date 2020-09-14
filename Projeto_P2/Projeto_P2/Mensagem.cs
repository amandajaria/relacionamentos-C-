using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mensagem
{
	public int id_mensagem;
	public string conteudo;

	public List<Assunto> assunto = new List<Assunto>();

	public void imprimirMensagem()
	{
		Console.WriteLine("-------------------Mensagem--------------------- ");
		Console.WriteLine("Identificação da Mensagem: " + id_mensagem);
		Console.WriteLine("Conteúdo da Mensagem: " + conteudo);

		if (assunto != null)
		{
			foreach (Assunto item in assunto)
			{
				Console.WriteLine("-------------------Título--------------------- ");
				Console.WriteLine("\tTítulo Da Mensagem: " + item.titulo);
			}
		}
			
	}

}

