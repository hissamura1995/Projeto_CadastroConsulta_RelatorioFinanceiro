using System;
using System.Collections.Generic;
using System.Data.Common;
using Projeto_CadastroConsulta_RelatorioFinanceiro.Business.DAO;
using Projeto_CadastroConsulta_RelatorioFinanceiro.Business.Model;

namespace Projeto_CadastroConsulta_RelatorioFinanceiro.Business.BLL
{
    public class UsuarioBLL
    {

        public static UsuarioModel SearchUsuario(Dictionary<string, object> criteria)
        {
            UsuarioDAO bd = new UsuarioDAO();

            return bd.SearchUsuario(criteria);
        }
    }
}
