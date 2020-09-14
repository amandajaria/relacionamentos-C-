using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Fisioterapeuta : Pessoa
{
	private int crefito;
    private int horas_trabalhadas;
    private string especializacao;


    //prepriedades
    public string Especializacao
    {
        get
        {
            return especializacao;
        }
        set
        {
            especializacao = value;
        }
    }
    public int Crefito
    {
        get
        {
            return crefito;
        }
        set
        {
            crefito = value;
        }
    }

    public int Horas_trabalhadas
    {
        get
        {
            return horas_trabalhadas;
        }
        set
        {
            horas_trabalhadas = value;
        }
    }

    // vem de Pessoa -> abstrata
    public override float Valor_hora {
    
        get
        {
            return valor_hora;
        }
        set
        {
            valor_hora = value;
        }
    }

    public override void imprimirPessoa()
    {
        Console.WriteLine("-------------------Fisioterapeuta--------------------- ");
        base.imprimirPessoa();
        Console.WriteLine("CREFITO: " + crefito);
        Console.WriteLine("Especialização: " + especializacao);
        Console.WriteLine("Horas Trabalhadas: " + horas_trabalhadas);
    }

    public override float calcularSalario(float valor, int horas_trabalhadas)
    {
        float salario;
        this.horas_trabalhadas = horas_trabalhadas;
        salario = (valor * horas_trabalhadas);
        return (salario);
    }


}