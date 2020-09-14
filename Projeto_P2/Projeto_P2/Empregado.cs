using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Empregado
{
	public int id_empregado;

    public string descricao_empregado;

    public Setor setor;

	public void imprimirEmpregado()
	{
        Console.WriteLine("-------------------Empregado--------------------- ");
        Console.WriteLine("ID Empregado: " + id_empregado);
        Console.WriteLine("Nome Empregado: " + descricao_empregado);


        if (setor != null)
        {
            Console.WriteLine("-------------------Setor--------------------- ");
            Console.WriteLine("\t ID Setor: " + setor.id_setor);
            Console.WriteLine("\t Nome Setor: " + setor.descricao_setor);
        }

    }

}
