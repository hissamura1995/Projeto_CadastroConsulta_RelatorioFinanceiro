using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_CadastroConsulta_RelatorioFinanceiro
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tela de login //
            TelaLogin _telaLogin = new TelaLogin();
            Application.Run(_telaLogin);

            // Verifica se o usuário foi autenticado, caso sim, abre a tela principal do usuário //
            if (_telaLogin.AutenticadoComSucesso)
            {
                TelaPrincipal _telaPrincipal = new TelaPrincipal();
                _telaPrincipal.UsuarioLogado = _telaLogin.UsuarioLogado;
                Application.Run(_telaPrincipal);

            }
        }
    }
}
