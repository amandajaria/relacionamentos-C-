using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_MotoristaCelular_Click(object sender, EventArgs e)
        {
            Celular o_Celular = new Celular();
            o_Celular.id_celular = 1;
            o_Celular.contato = "98848-8986";

            MotoristaUber o_Motorista = new MotoristaUber();
            o_Motorista.id_motorista = 2;
            o_Motorista.nome_motorista = "João";
            o_Motorista.status = "Ativo";
            o_Motorista.celular = o_Celular;

            o_Motorista.imprimirMotorista();
        }

        private void btn_CargoFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario o_Amanda = new Funcionario();
            o_Amanda.id_funcionario = 124;
            o_Amanda.nome_funcionario = "Amanda Macedo Jaria";

            Funcionario o_Lummy = new Funcionario();
            o_Lummy.id_funcionario = 258;
            o_Lummy.nome_funcionario = "Lummy Monteiro";

            Funcionario o_Sally = new Funcionario();
            o_Sally.id_funcionario = 496;
            o_Sally.nome_funcionario = "Sally Gallagher";

            Cargo o_Cargo = new Cargo();
            o_Cargo.id_cargo = 879;
            o_Cargo.descricao_cargo = "Analista Júnior";

            o_Cargo.funcionario.Add(o_Amanda);
            o_Cargo.funcionario.Add(o_Lummy);
            o_Cargo.funcionario.Add(o_Sally);

            o_Cargo.imprimirCargo();


        }

        private void btn_gerenteDepartamento_Click(object sender, EventArgs e)
        {
            Gerente o_Gerente = new Gerente();
            o_Gerente.id_gerente = 12;
            o_Gerente.descricao_gerente = "Pedro Mathias";

            Departamento o_Departamento = new Departamento();
            o_Departamento.id_departamento = 23;
            o_Departamento.descricao_departamento = "Recursos Humanos";

            // Associaçao Binaria ????
            o_Gerente.departamento = o_Departamento;
            o_Departamento.gerente = o_Gerente;

            o_Gerente.imprimirGerente();
            o_Departamento.imprimirDepartamento();
        }

        private void btn_SetorEmpregado_Click(object sender, EventArgs e)
        {
            Empregado o_Luiz = new Empregado();
            o_Luiz.id_empregado = 124;
            o_Luiz.descricao_empregado = "Luiz Jaria";

            Empregado o_Elisabete = new Empregado();
            o_Elisabete.id_empregado = 321;
            o_Elisabete.descricao_empregado = "Elisabete Macedo";

            Empregado o_Guilherme = new Empregado();
            o_Guilherme.id_empregado = 421;
            o_Guilherme.descricao_empregado = "Guilherme Maia";

            Setor o_Setor = new Setor();
            o_Setor.id_setor = 879;
            o_Setor.descricao_setor = "Vendas";

            o_Setor.empregado.Add(o_Luiz);
            o_Setor.empregado.Add(o_Elisabete);
            o_Setor.empregado.Add(o_Guilherme);

            o_Setor.imprimirSetor();

            o_Luiz.setor = o_Setor;
            o_Luiz.imprimirEmpregado();

            o_Elisabete.setor = o_Setor;
            o_Elisabete.imprimirEmpregado();

            o_Guilherme.setor = o_Setor;
            o_Guilherme.imprimirEmpregado();

        }

        private void btn_EmailAnexo_Click(object sender, EventArgs e)
        {
            Anexo o_Anexo1 = new Anexo();
            o_Anexo1.id_anexo  =  12;
            o_Anexo1.tamanho  =  100;

            Anexo o_Anexo2 = new Anexo();
            o_Anexo2.id_anexo = 13;
            o_Anexo2.tamanho = 234;

            Email o_Email = new Email();
            o_Email.id_email  =  10;
            o_Email.assunto  =  "Projeto P2";
            o_Email.mensagem = "Boa noite, seguem anexos os arquivos referentes ao Projeto P2";

            o_Email.anexo.Add(o_Anexo1);
            o_Email.anexo.Add(o_Anexo2);

            o_Email.imprimirEmail();
        }

        private void btn_AluguelImovel_Click(object sender, EventArgs e)
        {
            Imovel o_Imovel = new Imovel();
            o_Imovel.id_imovel = 123;
            o_Imovel.endereco = "Rua Das Aguas Claras, 345";
            o_Imovel.imprimirImovel();

            Aluguel o_Aluguel = new Aluguel();
            o_Aluguel.inserirDados(100, 3456.90f, o_Imovel);
            o_Aluguel.imprimirAluguel();

        }

        private void btn_MedicoPacienteConsulta_Click(object sender, EventArgs e)
        {
            Medico o_Medico1 = new Medico();
            o_Medico1.id_medico = 874;
            o_Medico1.nome_medico = "José Ferreira";

            Medico o_Medico2 = new Medico();
            o_Medico2.id_medico = 213;
            o_Medico2.nome_medico = "Aline Machado";

            Paciente o_Paciente1  = new Paciente();
            o_Paciente1.id_paciente = 324;
            o_Paciente1.nome_paciente  = "Amanda Jaria";

            Paciente o_Paciente2 = new Paciente();
            o_Paciente2.id_paciente = 987;
            o_Paciente2.nome_paciente = "Lummy Monteiro";

            Consulta o_Consulta1 = new Consulta();
            o_Consulta1.id_consulta = 458;
            o_Consulta1.data  =  "24/06/20";
            o_Consulta1.medico = o_Medico1;

            o_Paciente1.consulta.Add(o_Consulta1);

            Consulta o_Consulta2 = new Consulta();
            o_Consulta2.id_consulta = 124;
            o_Consulta2.data = "18/07/20";
            o_Consulta2.medico = o_Medico2;

            o_Paciente1.consulta.Add(o_Consulta2);

            o_Paciente1.imprimirPaciente();

        }

        private void btn_PessoaFisioterapeuta_Click(object sender, EventArgs e)
        {
         
            float calculoSalario;

            Fisioterapeuta o_fisioterapeuta = new Fisioterapeuta();
            o_fisioterapeuta.Horas_trabalhadas = 160;
            o_fisioterapeuta.Crefito = 9878656;
            o_fisioterapeuta.Especializacao = "Pediatria";
            o_fisioterapeuta.Nome = "Maria Clara Ferreira";
            o_fisioterapeuta.Id_pessoa = 1234;
            o_fisioterapeuta.Valor_hora = 40;


            calculoSalario = o_fisioterapeuta.calcularSalario(o_fisioterapeuta.Valor_hora, o_fisioterapeuta.Horas_trabalhadas);
            o_fisioterapeuta.imprimirPessoa();
            Console.WriteLine("Salário da Fisioterapeuta: " + calculoSalario);

        }

        private void bmt_IStatusDispositico_Click(object sender, EventArgs e)
        {
            Dispositivo o_Dispositivo = new Dispositivo();
            o_Dispositivo.id_dispositivo = 847;
            o_Dispositivo.status  =  1;
            o_Dispositivo.imprimirDispositivo();
            o_Dispositivo.desligar();
            o_Dispositivo.imprimirDispositivo();


        }

        private void btn_MensagemAssunto_Click(object sender, EventArgs e)
        {
            Mensagem o_Mensagem = new Mensagem();

            o_Mensagem.id_mensagem = 234;
            o_Mensagem.conteudo = "Bom dia, Gostaria de Marcar uma Reunião!";

            o_Mensagem.assunto.Add(new Assunto() { titulo = "Importante", fonte = "Arial" });
            o_Mensagem.imprimirMensagem();

            Mensagem o_Mensagem2 = new Mensagem();
            o_Mensagem2.id_mensagem = 234;
            o_Mensagem2.conteudo = "Boa noite, Infomamos que o prazo para matricula se encerra amanhã!";

            o_Mensagem2.assunto.Add(new Assunto() { titulo = "Urgente", fonte = "Arial" });
            o_Mensagem2.imprimirMensagem();
        }
    }
}
