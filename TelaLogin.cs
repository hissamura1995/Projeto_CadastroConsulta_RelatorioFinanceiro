// -- Icones baixados pelo https://www.flaticon.com -- //

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_CadastroConsulta_RelatorioFinanceiro.Business.Model;
using Projeto_CadastroConsulta_RelatorioFinanceiro.Business.BLL;
using Projeto_CadastroConsulta_RelatorioFinanceiro.Business.DAO;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace Projeto_CadastroConsulta_RelatorioFinanceiro
{
    public partial class TelaLogin : Form
    {
        #region ... Propriedades ...

        private TextBox txtLoginUsuario;
        private Label lblSenhaUsuario;
        private TextBox txtSenhaUsuario;
        private Button btnEntrar;
        private Label lblUsuario;
        private Button btnRecuperarSenha;
        private PictureBox pcbImagemFundo;
        private ErrorProvider errorProviderUsuario;
        private IContainer components;
        private BackgroundWorker backgroundWorker1;
        private Label lblLogin;

        /// <summary>
        /// Armazena os dados do usuario logado
        /// </summary>
        public UsuarioModel UsuarioLogado { get; set; }

        /// <summary>
        /// Armazena o status de autenticação
        /// </summary>
        public bool AutenticadoComSucesso { get; private set; }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnRecuperarSenha = new System.Windows.Forms.Button();
            this.pcbImagemFundo = new System.Windows.Forms.PictureBox();
            this.errorProviderUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagemFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLogin.Location = new System.Drawing.Point(135, 47);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(80, 31);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsuario.Location = new System.Drawing.Point(36, 135);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(281, 27);
            this.txtLoginUsuario.TabIndex = 1;
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSenhaUsuario.Location = new System.Drawing.Point(33, 165);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(49, 17);
            this.lblSenhaUsuario.TabIndex = 2;
            this.lblSenhaUsuario.Text = "Senha";
            this.lblSenhaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUsuario.Location = new System.Drawing.Point(36, 185);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.PasswordChar = '*';
            this.txtSenhaUsuario.Size = new System.Drawing.Size(281, 27);
            this.txtSenhaUsuario.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(36, 277);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(281, 47);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUsuario.Location = new System.Drawing.Point(33, 115);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRecuperarSenha
            // 
            this.btnRecuperarSenha.BackColor = System.Drawing.Color.White;
            this.btnRecuperarSenha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRecuperarSenha.FlatAppearance.BorderSize = 0;
            this.btnRecuperarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnRecuperarSenha.Location = new System.Drawing.Point(169, 218);
            this.btnRecuperarSenha.Name = "btnRecuperarSenha";
            this.btnRecuperarSenha.Size = new System.Drawing.Size(148, 25);
            this.btnRecuperarSenha.TabIndex = 6;
            this.btnRecuperarSenha.Text = "Esqueceu a senha?";
            this.btnRecuperarSenha.UseVisualStyleBackColor = false;
            // 
            // pcbImagemFundo
            // 
            this.pcbImagemFundo.BackColor = System.Drawing.Color.Transparent;
            this.pcbImagemFundo.Image = ((System.Drawing.Image)(resources.GetObject("pcbImagemFundo.Image")));
            this.pcbImagemFundo.Location = new System.Drawing.Point(4, 2);
            this.pcbImagemFundo.Name = "pcbImagemFundo";
            this.pcbImagemFundo.Size = new System.Drawing.Size(351, 360);
            this.pcbImagemFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagemFundo.TabIndex = 7;
            this.pcbImagemFundo.TabStop = false;
            // 
            // errorProviderUsuario
            // 
            this.errorProviderUsuario.ContainerControl = this;
            // 
            // TelaLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 374);
            this.Controls.Add(this.btnRecuperarSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.lblSenhaUsuario);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pcbImagemFundo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Enter += new System.EventHandler(this.btnEntrar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagemFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion ... Propriedades ...

        #region ... Métodos Privados ...

        /// <summary>
        /// Validador de preenchimento da tela de Login
        /// </summary>
        private void ValidarCampoLogin()
        {
            if (!string.IsNullOrEmpty(this.txtLoginUsuario.Text) & !string.IsNullOrEmpty(this.txtSenhaUsuario.Text))
            {
                // Parametros a serem passados para a camada BLL //
                Dictionary<string, object> searhCriteria = new Dictionary<string, object>();

                searhCriteria.Add("LoginUsuario", this.txtLoginUsuario.Text);
                searhCriteria.Add("SenhaUsuario", this.txtSenhaUsuario.Text);

                // Armazena o retorno //
                this.UsuarioLogado = UsuarioBLL.SearchUsuario(searhCriteria);

                // Verifica se existe o usuário com base no retorno - 0 = Nenhum usuário encontrado //
                // Caso exista, Fecha a tela de login e abre o form da tela principal do usuário (Program.cs) //
                if (UsuarioLogado.IdUsuario != 0)
                {
                    this.AutenticadoComSucesso = true;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
            else
            {
                if (string.IsNullOrEmpty(this.txtLoginUsuario.Text))
                {
                    this.txtLoginUsuario.Focus();
                    this.errorProviderUsuario.SetError(this.txtLoginUsuario, "Preencha o campo do usuário.");
                }
                if (string.IsNullOrEmpty(this.txtSenhaUsuario.Text))
                {
                    this.txtSenhaUsuario.Focus();
                    this.errorProviderUsuario.SetError(this.txtSenhaUsuario, "Preencha o campo da senha.");

                }
            }
        }

        #endregion ... Métodos Privados ...

        #region ... Eventos ...

        /// <summary>
        /// Inicializa o componente
        /// </summary>
        public TelaLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento de click do botão btnEntrar_Click
        /// </summary>
        /// <param name="sender">Origem do evento</param>
        /// <param name="e">Argumentos do evento</param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.ValidarCampoLogin();
        }


        #endregion ... Eventos ...
    }
}
