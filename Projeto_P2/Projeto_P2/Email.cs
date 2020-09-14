using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Email
{
	public int id_email;

	public string assunto;

    public string mensagem;

    public List <Anexo> anexo = new List <Anexo>();

	public void imprimirEmail()
	{
        Console.WriteLine("---------------------Email----------------------- ");
        Console.WriteLine("ID do Email: " + id_email);
        Console.WriteLine("Assunto do Email: " + assunto);
        Console.WriteLine("Mensagem: " + mensagem);

        if (anexo != null)
        {
            foreach (Anexo item in anexo)
            {
                Console.WriteLine("-------------------Dados Anexo--------------------- ");
                Console.WriteLine("\t ID do Anexo: " + item.id_anexo);
                Console.WriteLine("\t Tamanho do Anexo: " + item.tamanho);
            }
        }

    }

}