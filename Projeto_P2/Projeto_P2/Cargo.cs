using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cargo
{
	public int id_cargo;

	public string descricao_cargo;

	public List <Funcionario> funcionario = new List<Funcionario>();

	public void imprimirCargo()
	{
        Console.WriteLine("-------------------Cargo--------------------- ");
        Console.WriteLine("id cargo: " + id_cargo);
        Console.WriteLine("descricao cargo: " + descricao_cargo);

        if (funcionario != null)
        {

            foreach (Funcionario item in funcionario)
                {
                    Console.WriteLine("-------------------Funcioário--------------------- ");
                    Console.WriteLine("\t id funcionário: " + item.id_funcionario);
                    Console.WriteLine("\t nome funcionário: " + item.nome_funcionario);
                }
        }

    }	

}