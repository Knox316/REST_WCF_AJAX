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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Habitacoes" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Habitacoes.svc or Habitacoes.svc.cs at the Solution Explorer and start debugging.
    public class Habitacoes : IHabitacoes
    {
        #region CREATE
        /// <summary>
        /// Metodo para adicionar uma Habitacao na base de dados
        /// </summary>
        /// <param name="hab"></param>
        public void AdicionarHabitacao(Habitacao hab)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Habitacao(idCliente, preco, ocupado, tipoOcupacao) Values");
                sb.AppendFormat("('{0}', '{1}', '{2}', '{3}' )",
                    hab.IdCliente, hab.Preco, hab.Ocupado, hab.TipoOcupacao);

                (new Dal.DbHelper()).SqlExecute(sb.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Inserir", ex);
            }
        }
        #endregion

        #region DELETE
        /// <summary>
        /// Metodo para apagar uma habitacao 
        /// </summary>
        /// <param name="id"></param>
        public void ApagarHabitacao(string id)
        {

            try
            {
                (new Dal.DbHelper()).SqlExecute("DELETE FROM Cliente where idHabitacao = " + id);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao apagar", ex);
            }
        }
        #endregion

        #region LIST
        /// <summary>
        /// metodo para listar todas as habitacoes
        /// </summary>
        /// <returns></returns>
        public List<Habitacao> ListarHabitacao()
        {

            try
            {
                var dt = (new Dal.DbHelper()).GetResultSet("SELECT idHabitacao, idCliente, preco, ocupado, tipoOcupacao FROM Habitacao");
                List<Habitacao> listaClientes = new List<Habitacao>();
                foreach (DataRow item in dt.Rows)
                {
                    listaClientes.Add(new Habitacao(item));
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
        /// Procurar Habitacoes por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Habitacao ProcurarHabitacaoId(string id)
        {
            try
            {
                var dt = (new Dal.DbHelper()).GetResultSet("SELECT idHabitacao, idCliente, preco, ocupado, tipoOcupacao FROM Habitacao WHERE idHabitacao = " + id);
                if (dt.Rows.Count > 0)
                {
                    List<Habitacao> listaClientes = new List<Habitacao>();
                    foreach (DataRow item in dt.Rows)
                    {
                        listaClientes.Add(new Habitacao(item));
                    }
                    return listaClientes.First();
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a procurar Habitacao", ex);
            }
        }
        #endregion

        #region UPDATE
        /// <summary>
        /// Metodo para atualizar os dados de uma Habitacao
        /// </summary>
        /// <param name="hab"></param>
        public void UpdateHabitacao(Habitacao hab)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("UPDATE Habitacao SET ");
                sb.AppendFormat("idCliente = '{0}', ", hab.IdCliente);
                sb.AppendFormat("preco = '{0}', ", hab.Preco);
                sb.AppendFormat("ocupado = '{0}', ", hab.Ocupado ? 1 : 0);
                sb.AppendFormat("tipoOcupacao = '{0}', ", hab.TipoOcupacao);
                sb.AppendFormat(" WHERE idHabitacao = {0}", hab.IdHabitacao);

                (new Dal.DbHelper()).SqlExecute(sb.ToString());
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar", ex);
            }
        }
        #endregion
    }
}
