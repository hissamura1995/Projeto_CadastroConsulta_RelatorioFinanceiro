// Copyright (c) 2022 All Rights Reserved
// Autor: Renan Hissamura
// Data: 09/10/2022


using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Runtime.CompilerServices;
using Projeto_CadastroConsulta_RelatorioFinanceiro.Business.Model;
using System.Windows.Forms;

namespace Projeto_CadastroConsulta_RelatorioFinanceiro.Business.DAO
{
    public class UsuarioDAO
    {
        #region ... Propriedades ...

        private SqlConnection conn;

        #endregion ... Propriedades ...

        #region ... Métodos Internos ...

        /// <summary>
        /// Método de conexão com o banco
        /// </summary>
        internal void Conectar(SqlCommand cmd)
        {
            if (conn != null)
            {
                conn.Close();
            }
            //string de conexão//
            //string connStr = string.Format("server={0}; user id={1}; password={2}; database={3}; pooling={4}", server, user, password, database);
            string connStr = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            try
            {
                conn = new SqlConnection(connStr);
                cmd.Connection = conn;
                conn.Open();



            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Realiza uma pesquisa no banco para verificar se existe um registro com o usuario e senha informado
        /// </summary>
        /// <param name="criteria"></param>
        public UsuarioModel SearchUsuario(Dictionary<string, object> criteria)
        {
            UsuarioModel obj = new UsuarioModel();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.proc_ListarUsuario";

                cmd.Parameters.AddWithValue("@LoginUsuario", criteria["LoginUsuario"]);
                cmd.Parameters.AddWithValue("@SenhaUsuario", criteria["SenhaUsuario"]);

                this.Conectar(cmd);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Campos de retorno da execução da procedure //
                    obj.IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString());
                    obj.LoginUsuario = reader["LoginUsuario"].ToString();
                    obj.SenhaUsuario = reader["SenhaUsuario"].ToString();
                    obj.NomeCompletoUsuario = reader["NomeCompletoUsuario"].ToString();
                    obj.EstadoCivilUsuario = reader["EstadoCivilUsuario"].ToString();
                    obj.EmailUsuario = reader["EmailUsuario"].ToString();
                    obj.CPFUusuario = reader["CPFUsuario"].ToString();
                    obj.DddUsuario = reader["DDDUsuario"].ToString();
                    obj.TelefoneUsuario = reader["TelefoneUsuario"].ToString();
                    obj.CidadeUsuario = reader["CepUsuario"].ToString();
                    obj.EnderecoUsuario = reader["EnderecoUsuario"].ToString();
                    obj.EstadoUsuario = reader["EstadoUsuario"].ToString();
                    obj.CidadeUsuario = reader["CidadeUsuario"].ToString();
                    obj.StatusUsuario = reader["StatusUsuario"].ToString(); // 'A': Usuário admin | 'C' Usuário comum //
                    obj.Bloqueado = Convert.ToBoolean(reader["Bloqueado"].ToString()); // 0: Usuário desativado | 1: Usuário ativo //


                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return obj;
        }

        #endregion ...  Métodos Internos ...

    }
}
