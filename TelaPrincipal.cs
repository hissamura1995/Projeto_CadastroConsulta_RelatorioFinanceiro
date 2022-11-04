using Microsoft.Azure.Management.Sql;
using Projeto_CadastroConsulta_RelatorioFinanceiro.Business.Model;
using Projeto_CadastroConsulta_RelatorioFinanceiro.Form_Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto_CadastroConsulta_RelatorioFinanceiro
{
    public partial class TelaPrincipal : Form
    {

        #region ... Propriedades ...

        /// <summary>
        /// Evento de quando o mouse esta sobre o evento e é pressionado
        /// Permite que o form seja arrastado mesmo sem a borda padrão do windows
        /// Referência: https://social.msdn.microsoft.com/Forums/pt-BR/5465b4bc-5433-45ae-9689-4fdc30d2ba8b/como-arrastar-uma-form-sem-bordas?forum=vsvbasicpt 
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        /// <summary>
        /// Armazena os dados do usuario logado
        /// </summary>
        public UsuarioModel UsuarioLogado;

        #endregion ... Propriedades ...

        /// <summary>
        /// Armazena o form aberto atualmente 
        /// </summary>
        private Form formFilhoAtual;

        private Button botaoAtual;


        #region ... Métodos Privados ...

        /// <summary>
        /// Abre o form conforme click no botão de menu
        /// </summary>
        /// <param name="formFilho"></param>
        private void AbrirFormFilho(Form formFilho)
        {
            if (formFilhoAtual != null)
            {
                // fecha o form tual // 
                formFilhoAtual.Close();
            }
            formFilhoAtual = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            PanelCentral.Controls.Add(formFilho);
            PanelCentral.Tag = formFilho;
            formFilho.BringToFront();
            formFilho.Show();
            lblTitulo.Text = formFilho.Text;
        }

        /// <summary>
        /// Troca o título para o padrão de início 
        /// </summary>
        private void Reset()
        {
            this.desabilitarSelecao();
            lblTitulo.Text = "Início";
        }

        private void botaoSelecionado(object botao, Color cor)
        {
            if (botao != null)
            {
                this.desabilitarSelecao();
                this.botaoAtual = (Button)botao;

                botaoAtual.BackColor = Color.FromArgb(92, 92, 112);
            }
        }


        private void desabilitarSelecao()
        {
            if (this.botaoAtual != null)
            {
                this.botaoAtual.BackColor = Color.FromArgb(51, 51, 76);
            }
        }


        #endregion ... Métodos Privados ...


        #region ... Eventos ...

        public TelaPrincipal()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        /// <summary>
        /// Evento load da tela principal
        /// </summary>
        /// <param name="sender">Origem do evento</param>
        /// <param name="e">Argumentos do evento</param>
        public void TelaPrincipal_Load(object sender, EventArgs e)
        {
            // Apresenta o nome do usuário logado e a data/hora atual //
            this.lblNomeUsuarioLogado.Text = "Bem-vindo(a): " + this.UsuarioLogado.NomeCompletoUsuario;

            // ToolTip para os botões de fechar, minimizar e expandir o form //
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 500;

            toolTip.SetToolTip(this.btnFechar, "Fechar");
            toolTip.SetToolTip(this.btnMaximizar, "Maximizar");
            toolTip.SetToolTip(this.btnMinimizar, "Minimizar");
            //this.PanelPrincipal.BackColor = Color.FromArgb(25, Color.Green);
        }

        /// <summary>
        /// Evento de quando o mouse esta sobre o evento e é pressionado
        /// Permite que o form seja arrastado mesmo sem a borda padrão do windows
        /// Referência: https://social.msdn.microsoft.com/Forums/pt-BR/5465b4bc-5433-45ae-9689-4fdc30d2ba8b/como-arrastar-uma-form-sem-bordas?forum=vsvbasicpt 
        /// </summary>
        /// <param name="sender">Origem do evento</param>
        /// <param name="e">Argumentos do evento</param>
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Evento de click do botão btnFechar
        /// </summary>
        /// <param name="sender">Origem do evento</param>
        /// <param name="e">Argumentos do evento</param>
        private void btnFechar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        /// <summary>
        ///  Evento de MouseHover do btnFechar
        /// </summary>
        /// <param name="sender">Origem do evento</param>
        /// <param name="e">Argumentos do evento</param>
        private void btnFechar_MouseHover(object sender, EventArgs e)
        {

            this.btnFechar.ForeColor = Color.Red;
        }

        /// <summary>
        ///  Evento de MouseHover Leave do btnFechar
        /// </summary>
        /// <param name="sender">Origem do evento</param>
        /// <param name="e">Argumentos do evento</param>
        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            this.btnFechar.ForeColor = Color.White;
        }

        /// <summary>
        /// Evento de click do botão btnMaximizar
        /// </summary>
        /// <param name="sender">Origem do evento</param>
        /// <param name="e">Argumentos do evento</param>
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            // Verifica se o form esta no tamanho normal // 
            if (WindowState == FormWindowState.Normal)
            {
                // caso esteja no tamanho normal, maximiza o form
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Caso contrário, coloca como tamanho normal
                this.WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// Evento de click do botão btnMinimizar
        /// </summary>
        /// <param name="sender">Origem do evento</param>
        /// <param name="e">Argumentos do evento</param>
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            // Minimiza o form //
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Evento do timer 
        /// </summary>
        /// <param name="sender">Origem do evento</param>
        /// <param name="e">Argumentos do evento</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            this.lblTimer.Text = DateTime.Now.ToLongTimeString() + " - " + DateTime.Now.ToShortDateString();

        }

        /// <summary>
        /// Evento de click do botão btnAgendamentos
        /// </summary>
        /// <param name="sender">Origem do evento</param>
        /// <param name="e">Argumentos do evento</param>
        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            this.botaoSelecionado(sender, Color.FromArgb(92, 92, 112));
            this.AbrirFormFilho(new FormAgendamentos());
        }

        /// <summary>
        /// Evento de click do botão btnPacientes
        /// </summary>
        /// <param name="sender">Origem do evento</param>
        /// <param name="e">Argumentos do evento</param>
        private void btnPacientes_Click(object sender, EventArgs e)
        {
            this.botaoSelecionado(sender, Color.FromArgb(92, 92, 112));
            this.AbrirFormFilho(new FormAgendamentos());
        }

        /// <summary>
        /// Evento de click do botão btnLogo
        /// </summary>
        /// <param name="sender">Origem do evento</param>
        /// <param name="e">Argumentos do evento</param>
        private void btnLogo_Click(object sender, EventArgs e)
        {
            if (formFilhoAtual != null)
            {
                formFilhoAtual.Close();
            }
            this.Reset();
        }

        #endregion ... Eventos ...


    }
}


