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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DadosHabitacoes" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DadosHabitacoes.svc or DadosHabitacoes.svc.cs at the Solution Explorer and start debugging.
    public class DadosHabitacoes : IDadosHabitacoes
    {
        #region LISTAR
        /// <summary>
        /// Metodo para Listar os dsdos das Habitacoes
        /// </summary>
        /// <returns></returns>
        public List<DadosHabitacao> ListarDadosHabitacao()
        {
            try
            {
                var dt = (new DbHelper()).GetResultSet("SELECT idDadosHabitacao, tipologia, numeroQuartos, totalMetrosQuadrados, anoConstrucao, wifi, despesasIncluidas, numeroQuartoOcupados, morada, codigoPostal, localidade, detalhes, longitude, latitude, tipoImovel FROM DadosHabitacao");
                List<DadosHabitacao> listaDadosHabitacao = new List<DadosHabitacao>();
                foreach (DataRow item in dt.Rows)
                {
                    listaDadosHabitacao.Add(new DadosHabitacao(item));
                }
                return listaDadosHabitacao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a devolver lista", ex);
            }
        }
        #endregion

        #region SEARCH
        /// <summary>
        /// Metodo para procurar Dados de Habitacoes pelo seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DadosHabitacao ProcurarDadosHabitacao(string id)
        {
            try
            {
                var dt = (new Dal.DbHelper()).GetResultSet("SELECT idDadosHabitacao, tipologia, numeroQuartos, totalMetrosQuadrados, anoConstrucao, wifi, despesasIncluidas, numeroQuartoOcupados, morada, codigoPostal, localidade, detalhes, longitude, latitude, tipoImovel FROM DadosHabitacao WHERE idDadosHabitacao = " + id);
                if (dt.Rows.Count > 0)
                {
                    List<DadosHabitacao> listaDadosHabitacao = new List<DadosHabitacao>();
                    foreach (DataRow item in dt.Rows)
                    {
                        listaDadosHabitacao.Add(new DadosHabitacao(item));
                    }
                    return listaDadosHabitacao.First();
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a procurar Cliente", ex);
            }
        }
        #endregion
    }
}
