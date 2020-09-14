using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Paciente
{
	public int id_paciente;

	public string nome_paciente;

	public List <Consulta> consulta = new List <Consulta>();

	public void imprimirPaciente()
	{
        Console.WriteLine("-------------------Paciente--------------------- "); 
        Console.WriteLine("ID do Paciente: " + id_paciente);
        Console.WriteLine("Nome do Paciente: " + nome_paciente);

        if (consulta != null)
        {
            foreach (Consulta item in consulta)
            {
                Console.WriteLine("-------------------Consulta--------------------- ");
                Console.WriteLine("\t ID Consulta: " + item.id_consulta);
                Console.WriteLine("\t Data Consulta: " + item.data);
                
                Console.WriteLine("\t ID Médico: " + item.medico.id_medico);
                Console.WriteLine("\t Nome Médico: " + item.medico.nome_medico);
            }
        }

    }

}

