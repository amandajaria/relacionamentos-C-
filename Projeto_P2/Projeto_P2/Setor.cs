using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Setor
{
    public int id_setor;

    public string descricao_setor;

    public List<Empregado> empregado=new List<Empregado>();

    public void imprimirSetor()
	{
        Console.WriteLine("-------------------Setor--------------------- ");
        Console.WriteLine("ID do Setor: " + id_setor);
        Console.WriteLine("Nome do Setor: " + descricao_setor);

        if (empregado != null)
        {
            foreach (Empregado item in empregado)
            {
                Console.WriteLine("-------------------Empregado--------------------- ");
                Console.WriteLine("\t ID do Empregado: " + item.id_empregado);
                Console.WriteLine("\t Nome do Empregado: " + item.descricao_empregado);
            }
        }

    }

}