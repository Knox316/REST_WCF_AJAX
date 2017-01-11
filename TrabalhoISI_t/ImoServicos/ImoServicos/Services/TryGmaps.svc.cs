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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TryGmaps" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TryGmaps.svc or TryGmaps.svc.cs at the Solution Explorer and start debugging.
    public class TryGmaps : ITryGmaps
    {

        /// <summary>
        /// Not working
        /// Metodos para tentar ir buscar as coordenadas de um Cliente, Saber a habitacao dele pelas coordenadas
        /// E Atualizar as coordenadas pelo mapa
        /// </summary>
        /// <param name="idh"></param>
        /// <returns></returns>
        #region GetPats
        public string getPacientes(string idh)
        {
            var dt = (new Dal.DbHelper()).GetResultSet("SELECT idHabitacao, idCliente, preco, ocupado, tipoOcupacao FROM Habitacao WHERE idHabitacao = " + idh);
            List<Habitacao> listaClientes = new List<Habitacao>();
            foreach (DataRow item in dt.Rows)
            {
                listaClientes.Add(new Habitacao(item));
            }
            return listaClientes.ToString();
        }
        #endregion

        #region GetDir
        /// <summary>
        /// GetDir
        /// </summary>
        /// <param name="iddhab"></param>
        /// <returns></returns>
        public string getDirecciones(string iddhab)
        {
            List<DadosHabitacao> listaDadosHabitacao = new List<DadosHabitacao>();
            var dt = (new Dal.DbHelper()).GetResultSet("SELECT idDadosHabitacao, localidade, longitude, latitude FROM DadosHabitacao WHERE idDadosHabitacao = " + iddhab);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {

                    listaDadosHabitacao.Add(new DadosHabitacao
                    {
                        //done
                        IdDadosHabitacao = Convert.ToInt32(dataRow["idDadosHabitacao"]),
                        Localidade = dataRow["localidade"].ToString(),
                        Longitude = Convert.ToInt32(dataRow["longitude"]),
                        Latitude = Convert.ToInt32(dataRow["latitude"]),
                    });
                }
            }
            return listaDadosHabitacao.ToString();
        }
        #endregion

        #region UpDir
        public string ActualizarDireccion(DadosHabitacao dh)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("UPDATE DadosHabitacao SET ");
                sb.AppendFormat("latitude = '{0}', ", dh.Latitude);
                sb.AppendFormat("longitude = '{0}', ", dh.Longitude);
                sb.AppendFormat(" WHERE idDadosHabitacao = {0}", dh.IdDadosHabitacao);

                return sb.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion
    }
}

