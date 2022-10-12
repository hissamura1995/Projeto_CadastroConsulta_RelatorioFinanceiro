
using System;

namespace Projeto_CadastroConsulta_RelatorioFinanceiro.Business.Model
{
    [Serializable]
    public class UsuarioModel
    {
        /// <summary>
        /// Armazena IdUsuario
        /// </summary>
        public int IdUsuario { get; set; }

        /// <summary>
        /// Armazena LoginUsuario
        /// </summary>
        public string LoginUsuario { get; set; }

        /// <summary>
        /// Armazena SenhaUsuario
        /// </summary>
        public string SenhaUsuario { get; set; }

        /// <summary>
        /// Armazena EmailUsuario
        /// </summary>
        public string EmailUsuario { get; set; }

        /// <summary>
        /// Armazena CPFUsuario
        /// </summary>
        public string CPFUusuario { get; set; }

        /// <summary>
        /// Armazena DddUsuario
        /// </summary>
        public string DddUsuario { get; set; }

        /// <summary>
        /// Armazena TelefoneUsuario
        /// </summary>
        public string TelefoneUsuario { get; set; }

        /// <summary>
        /// Armazena EnderecoUsuario
        /// </summary>
        public string EnderecoUsuario { get; set; }

        /// <summary>
        /// Armazena EstadoUsuario
        /// </summary>
        public string EstadoUsuario { get; set; }

        /// <summary>
        /// Armazena CidadeUsiario
        /// </summary>
        public string CidadeUsuario { get; set; }

        /// <summary>
        /// Armazena SexoUsuario
        /// </summary>
        public string SexoUsuario { get; set; }

        /// <summary>
        /// Armazena NomeCompletoUsuario
        /// </summary>
        public string NomeCompletoUsuario { get; set; }

        /// <summary>
        /// Armazena EstadoCivilUsuario
        /// </summary>
        public string EstadoCivilUsuario { get; set; }

        /// <summary>
        /// Armazena StatusUsuario
        /// </summary>
        public string StatusUsuario { get; set; }

        /// <summary>
        /// Armazena Bloqueado
        /// </summary>
        public bool Bloqueado { get; set; }
    }
}
