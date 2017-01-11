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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HistoricoAlugueres" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HistoricoAlugueres.svc or HistoricoAlugueres.svc.cs at the Solution Explorer and start debugging.
    public class HistoricoAlugueres : IHistoricoAlugueres
    {
        #region CREATE
        /// <summary>
        /// Metodo para adicionar o historico de um aluguer de um cliente para uma habitacao
        /// </summary>
        /// <param name="ha"></param>
        public void AdicionarHistoricoAlu(HistoricoAluguer ha)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO HistoricoAluguer(idQuarto, idHabitacao, idCliente, dataInicio, dataFim, descricao) Values");
                sb.AppendFormat("('{0}', '{1}', '{2}', '{3}', '{4}', '{5}' )",
                    ha.IdQuarto, ha.IdHabitacao, ha.IdCliente, ha.DataInicio, ha.DataFim, ha.Descricao);

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
        /// Metodo para apagar o historico de um aluguer pelo seu ID
        /// </summary>
        /// <param name="id"></param>
        public void ApagarHistoricoAlu(string id)
        {
            try
            {
                (new Dal.DbHelper()).SqlExecute("DELETE FROM HistoricoAluguer where idHistoricoAluguer = " + id);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao apagar", ex);
            }
        }
        #endregion

        #region LIST
        /// <summary>
        /// Metodo para listar todos os historicos
        /// </summary>
        /// <returns></returns>
        public List<HistoricoAluguer> ListarHistoricoAlu()
        {
            try
            {
                var dt = (new Dal.DbHelper()).GetResultSet("SELECT idHistoricoAluguer, idQuarto, idHabitacao, idCliente, dataInicio, dataFim, descricao FROM HistoricoAluguer");
                List<HistoricoAluguer> listaHistorico = new List<HistoricoAluguer>();
                foreach (DataRow item in dt.Rows)
                {
                    listaHistorico.Add(new HistoricoAluguer(item));
                }
                return listaHistorico;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a devolver lista", ex);
            }
        }
        #endregion

        #region SEARCH 
        /// <summary>
        /// Metodo para pesquisar Historicos por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HistoricoAluguer ProcurarHistoricoAluId(string id)
        {
            try
            {
                var dt = (new Dal.DbHelper()).GetResultSet("SELECT  idHistoricoAluguer, idQuarto, idHabitacao, idCliente, dataInicio, dataFim, descricao FROM HistoricoAluguer WHERE idHistoricoAluguer = " + id);
                if (dt.Rows.Count > 0)
                {
                    List<HistoricoAluguer> listaHistorico = new List<HistoricoAluguer>();
                    foreach (DataRow item in dt.Rows)
                    {
                        listaHistorico.Add(new HistoricoAluguer(item));
                    }
                    return listaHistorico.First();

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
        /// Metodo para atualizar o historico de um cliente
        /// </summary>
        /// <param name="ha"></param>
        public void UpdateHistoricoAlu(HistoricoAluguer ha)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("UPDATE HistoricoAluguer SET ");
                sb.AppendFormat("idQuarto = '{0}', ", ha.IdQuarto);
                sb.AppendFormat("idHabitacao = '{0}', ", ha.IdHabitacao);
                sb.AppendFormat("idCliente = {0}, ", ha.IdCliente);
                sb.AppendFormat("dataInicio = {0} ", ha.DataInicio);
                sb.AppendFormat("dataFim = {0}, ", ha.DataFim);
                sb.AppendFormat("descricao = {0} ", ha.Descricao);
                sb.AppendFormat(" WHERE idHistoricoAluguer = {0}", ha.IdHistoricoAluguer);

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
