namespace Projeto_P2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_MotoristaCelular = new System.Windows.Forms.Button();
            this.btn_CargoFuncionario = new System.Windows.Forms.Button();
            this.btn_gerenteDepartamento = new System.Windows.Forms.Button();
            this.btn_SetorEmpregado = new System.Windows.Forms.Button();
            this.btn_AluguelImovel = new System.Windows.Forms.Button();
            this.btn_EmailAnexo = new System.Windows.Forms.Button();
            this.btn_MensagemAssunto = new System.Windows.Forms.Button();
            this.btn_MedicoPacienteConsulta = new System.Windows.Forms.Button();
            this.btn_PessoaFisioterapeuta = new System.Windows.Forms.Button();
            this.bmt_IStatusDispositico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MotoristaCelular
            // 
            this.btn_MotoristaCelular.Location = new System.Drawing.Point(43, 37);
            this.btn_MotoristaCelular.Name = "btn_MotoristaCelular";
            this.btn_MotoristaCelular.Size = new System.Drawing.Size(75, 46);
            this.btn_MotoristaCelular.TabIndex = 0;
            this.btn_MotoristaCelular.Text = "Motorista / Celular";
            this.btn_MotoristaCelular.UseVisualStyleBackColor = true;
            this.btn_MotoristaCelular.Click += new System.EventHandler(this.btn_MotoristaCelular_Click);
            // 
            // btn_CargoFuncionario
            // 
            this.btn_CargoFuncionario.Location = new System.Drawing.Point(180, 37);
            this.btn_CargoFuncionario.Name = "btn_CargoFuncionario";
            this.btn_CargoFuncionario.Size = new System.Drawing.Size(75, 46);
            this.btn_CargoFuncionario.TabIndex = 1;
            this.btn_CargoFuncionario.Text = "Cargo / Funcionario";
            this.btn_CargoFuncionario.UseVisualStyleBackColor = true;
            this.btn_CargoFuncionario.Click += new System.EventHandler(this.btn_CargoFuncionario_Click);
            // 
            // btn_gerenteDepartamento
            // 
            this.btn_gerenteDepartamento.Location = new System.Drawing.Point(338, 39);
            this.btn_gerenteDepartamento.Name = "btn_gerenteDepartamento";
            this.btn_gerenteDepartamento.Size = new System.Drawing.Size(85, 46);
            this.btn_gerenteDepartamento.TabIndex = 2;
            this.btn_gerenteDepartamento.Text = "Gerente / Departamento";
            this.btn_gerenteDepartamento.UseVisualStyleBackColor = true;
            this.btn_gerenteDepartamento.Click += new System.EventHandler(this.btn_gerenteDepartamento_Click);
            // 
            // btn_SetorEmpregado
            // 
            this.btn_SetorEmpregado.Location = new System.Drawing.Point(516, 39);
            this.btn_SetorEmpregado.Name = "btn_SetorEmpregado";
            this.btn_SetorEmpregado.Size = new System.Drawing.Size(75, 46);
            this.btn_SetorEmpregado.TabIndex = 3;
            this.btn_SetorEmpregado.Text = "Setor / Empregado";
            this.btn_SetorEmpregado.UseVisualStyleBackColor = true;
            this.btn_SetorEmpregado.Click += new System.EventHandler(this.btn_SetorEmpregado_Click);
            // 
            // btn_AluguelImovel
            // 
            this.btn_AluguelImovel.Location = new System.Drawing.Point(680, 39);
            this.btn_AluguelImovel.Name = "btn_AluguelImovel";
            this.btn_AluguelImovel.Size = new System.Drawing.Size(75, 44);
            this.btn_AluguelImovel.TabIndex = 4;
            this.btn_AluguelImovel.Text = "Aluguel / Imovel";
            this.btn_AluguelImovel.UseVisualStyleBackColor = true;
            this.btn_AluguelImovel.Click += new System.EventHandler(this.btn_AluguelImovel_Click);
            // 
            // btn_EmailAnexo
            // 
            this.btn_EmailAnexo.Location = new System.Drawing.Point(43, 144);
            this.btn_EmailAnexo.Name = "btn_EmailAnexo";
            this.btn_EmailAnexo.Size = new System.Drawing.Size(76, 37);
            this.btn_EmailAnexo.TabIndex = 5;
            this.btn_EmailAnexo.Text = "Email / Anexo";
            this.btn_EmailAnexo.UseVisualStyleBackColor = true;
            this.btn_EmailAnexo.Click += new System.EventHandler(this.btn_EmailAnexo_Click);
            // 
            // btn_MensagemAssunto
            // 
            this.btn_MensagemAssunto.Location = new System.Drawing.Point(170, 144);
            this.btn_MensagemAssunto.Name = "btn_MensagemAssunto";
            this.btn_MensagemAssunto.Size = new System.Drawing.Size(75, 37);
            this.btn_MensagemAssunto.TabIndex = 6;
            this.btn_MensagemAssunto.Text = "Mensagem / Assunto";
            this.btn_MensagemAssunto.UseVisualStyleBackColor = true;
            this.btn_MensagemAssunto.Click += new System.EventHandler(this.btn_MensagemAssunto_Click);
            // 
            // btn_MedicoPacienteConsulta
            // 
            this.btn_MedicoPacienteConsulta.Location = new System.Drawing.Point(322, 144);
            this.btn_MedicoPacienteConsulta.Name = "btn_MedicoPacienteConsulta";
            this.btn_MedicoPacienteConsulta.Size = new System.Drawing.Size(114, 37);
            this.btn_MedicoPacienteConsulta.TabIndex = 7;
            this.btn_MedicoPacienteConsulta.Text = "Medico / Paciente / Consulta";
            this.btn_MedicoPacienteConsulta.UseVisualStyleBackColor = true;
            this.btn_MedicoPacienteConsulta.Click += new System.EventHandler(this.btn_MedicoPacienteConsulta_Click);
            // 
            // btn_PessoaFisioterapeuta
            // 
            this.btn_PessoaFisioterapeuta.Location = new System.Drawing.Point(504, 144);
            this.btn_PessoaFisioterapeuta.Name = "btn_PessoaFisioterapeuta";
            this.btn_PessoaFisioterapeuta.Size = new System.Drawing.Size(87, 37);
            this.btn_PessoaFisioterapeuta.TabIndex = 8;
            this.btn_PessoaFisioterapeuta.Text = "Pessoa / Fisioterapeuta";
            this.btn_PessoaFisioterapeuta.UseVisualStyleBackColor = true;
            this.btn_PessoaFisioterapeuta.Click += new System.EventHandler(this.btn_PessoaFisioterapeuta_Click);
            // 
            // bmt_IStatusDispositico
            // 
            this.bmt_IStatusDispositico.Location = new System.Drawing.Point(680, 144);
            this.bmt_IStatusDispositico.Name = "bmt_IStatusDispositico";
            this.bmt_IStatusDispositico.Size = new System.Drawing.Size(75, 37);
            this.bmt_IStatusDispositico.TabIndex = 9;
            this.bmt_IStatusDispositico.Text = "IStatus / Dispositivo";
            this.bmt_IStatusDispositico.UseVisualStyleBackColor = true;
            this.bmt_IStatusDispositico.Click += new System.EventHandler(this.bmt_IStatusDispositico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.bmt_IStatusDispositico);
            this.Controls.Add(this.btn_PessoaFisioterapeuta);
            this.Controls.Add(this.btn_MedicoPacienteConsulta);
            this.Controls.Add(this.btn_MensagemAssunto);
            this.Controls.Add(this.btn_EmailAnexo);
            this.Controls.Add(this.btn_AluguelImovel);
            this.Controls.Add(this.btn_SetorEmpregado);
            this.Controls.Add(this.btn_gerenteDepartamento);
            this.Controls.Add(this.btn_CargoFuncionario);
            this.Controls.Add(this.btn_MotoristaCelular);
            this.Name = "Form1";
            this.Text = "Projeto P2 - Amanda e Lummy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MotoristaCelular;
        private System.Windows.Forms.Button btn_CargoFuncionario;
        private System.Windows.Forms.Button btn_gerenteDepartamento;
        private System.Windows.Forms.Button btn_SetorEmpregado;
        private System.Windows.Forms.Button btn_AluguelImovel;
        private System.Windows.Forms.Button btn_EmailAnexo;
        private System.Windows.Forms.Button btn_MensagemAssunto;
        private System.Windows.Forms.Button btn_MedicoPacienteConsulta;
        private System.Windows.Forms.Button btn_PessoaFisioterapeuta;
        private System.Windows.Forms.Button bmt_IStatusDispositico;
    }
}

