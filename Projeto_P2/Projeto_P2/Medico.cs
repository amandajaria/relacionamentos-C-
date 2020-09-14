using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Medico
{
	public int id_medico;

	public string nome_medico;

    public List<Consulta> consulta = new List<Consulta>();

    public void imprimirMedico()
	{
        
        Console.WriteLine("ID do Médico: " + id_medico);
        Console.WriteLine("Nome do Médico: " + nome_medico);

        if (consulta != null)
        {
            foreach (Consulta item in consulta)
            {
                Console.WriteLine("-------------------Consulta--------------------- ");
                Console.WriteLine("\t ID Consulta: " + item.id_consulta);
                Console.WriteLine("\t Data Consulta: " + item.data);               
            }
        }

    }

}

