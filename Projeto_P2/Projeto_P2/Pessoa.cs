using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Pessoa
{
    //Atributos
	protected int id_pessoa;
	protected string nome;
	//Propriedade abstrata
    protected float valor_hora;

    //Propriedades
    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            nome = value;
        }
    }
    public int Id_pessoa
    {
        get
        {
            return id_pessoa;
        }
        set
        {
            id_pessoa = value;
        }
    }
    // abstrata
    public abstract float Valor_hora { get; set; }

    //Metodos
    public virtual void imprimirPessoa()
    {
        
        Console.WriteLine("Codigo: " + id_pessoa);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Valor da hora trabalhada: " + valor_hora);
    }

    public abstract float calcularSalario(float valor, int horas_trabalhadas);


}