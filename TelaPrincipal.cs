using Projeto_CadastroConsulta_RelatorioFinanceiro.Business.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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


        #region ... Métodos Privados ...


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
            this.lblNomeUsuarioLogado.Text = "Bem-vindo(a): " + this.UsuarioLogado.NomeCompletoUsuario;
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

        #endregion ... Eventos ...
    }
}
