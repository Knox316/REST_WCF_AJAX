using ImoServicos.Dal;
using ImoServicos.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ImoServicos.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Clientes" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Clientes.svc or Clientes.svc.cs at the Solution Explorer and start debugging.
    public class Clientes : IClientes
    {
        #region CREATE
        /// <summary>
        /// Método para adicionar um Cliente na base de dados
        /// </summary>
        /// <param name="cl"></param>
        public void AdicionarCliente(Cliente cl)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Cliente(nomeUtilizador, password, tipoUtilizador, ativo) Values");
                sb.AppendFormat("('{0}', '{1}', '{2}', '{3}' )",
                    cl.NomeUtilizador, cl.Password, cl.TipoUtilizador, cl.Ativo); // ? 1 : 0

                (new DbHelper()).SqlExecute(sb.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Inserir", ex);
            }
        }
        #endregion

        #region DELETE
        /// <summary>
        /// Metodo para apagar um Cliente da base de dados
        /// </summary>
        /// <param name="id"></param>
        public void ApagarCliente(string id)
        {
            try
            {
                (new DbHelper()).SqlExecute("DELETE FROM Cliente where idCliente = " + id);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao apagar", ex);
            }
        }
        #endregion

        #region LIST

        /// <summary>
        /// Metodo para apagar um Cliente da base de dados
        /// </summary>
        /// <returns></returns>
        public List<Cliente> ListarClientes()
        {
            try
            {
                List<Cliente> listaClientes = new List<Cliente>();
                DataTable dt = (new DbHelper()).GetResultSet("SELECT idCliente, nomeUtilizador, password, tipoUtilizador, ativo FROM Cliente");

                foreach (DataRow item in dt.Rows)
                {
                    listaClientes.Add(new Cliente(item));
                }
                return listaClientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a devolver lista", ex);
            }
        }
        #endregion

        #region SEARCH

        /// <summary>
        /// Metodo para procurar um cliente por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cliente ProcurarClienteId(string id)
        {
            try
            {
                var dt = (new DbHelper()).GetResultSet("SELECT idCliente, nomeUtilizador, password, tipoUtilizador, ativo FROM Cliente WHERE idCliente = " + id);
                if (dt.Rows.Count > 0)
                {
                    List<Cliente> listaClientes = new List<Cliente>();
                    foreach (DataRow item in dt.Rows)
                    {
                        listaClientes.Add(new Cliente(item));
                    }
                    return listaClientes.First();
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a procurar Cliente", ex);
            }
        }
        #endregion

        #region UPDATE
        /// <summary>
        /// Metodo para atualizar um cliente
        /// </summary>
        /// <param name="cli"></param>
        public void UpdateCliente(Cliente cli)
        {
            try
            {

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("UPDATE Cliente SET ");
                //sb.AppendFormat("nomeUtilizador = '{0}', ", cli.NomeUtilizador);
                sb.AppendFormat("password = '{0}', ", cli.Password);
                sb.AppendFormat("tipoUtilizador = {0}, ", cli.TipoUtilizador);
                sb.AppendFormat("ativo = {0} ", cli.Ativo ? 1 : 0);
                sb.AppendFormat(" WHERE idCliente = {0}", cli.IdCliente);

                (new DbHelper()).SqlExecute(sb.ToString());
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar", ex);
            }
        }
        #endregion
    }
}
