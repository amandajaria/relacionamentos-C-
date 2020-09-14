using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Consulta
{
	public int id_consulta;

    public string data;

    public Paciente paciente = new Paciente();

    public Medico medico = new Medico();

	public void imprimirConsulta()
	{
        Console.WriteLine("-------------------Consulta--------------------- ");
        Console.WriteLine("ID da Consulta: " + id_consulta);
        Console.WriteLine("Data da Consulta: " + data);
        Console.WriteLine("-------------------Paciente--------------------- ");
        Console.WriteLine("\t ID do Paciente: " + paciente.id_paciente);
        Console.WriteLine("\t Nome do Paciente: " + paciente.nome_paciente);
        Console.WriteLine("\t ID do Médico: " + medico.id_medico);
        Console.WriteLine("\t Nome do Médico: " + medico.nome_medico);
    }

}
