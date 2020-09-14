using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dispositivo : IStatus
{
	public int id_dispositivo;

	public int status;

	public void ligar()
	{
        status  =  1;
        Console.WriteLine("Ligado");
    }

	public void desligar()
	{
        status = 0;
        Console.WriteLine("Desligado com sucesso");

    }

	public void imprimirDispositivo()
	{
        Console.WriteLine("-------------------Dispositivo--------------------- ");
        Console.WriteLine("ID do dispositivo: " + id_dispositivo);
        Console.WriteLine("Status: " + status);
    }

}