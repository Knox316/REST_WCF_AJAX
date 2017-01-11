using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ImoServicos.Model
{
    [DataContract(Namespace = "")]
    public class DadosHabitacao
    {
        int idDadosHabitacao;
        string tipologia;
        int numeroQuartos;
        int totalMetrosQuadrados;
        int anoConstrucao;
        bool wifi;
        bool despesasIncluidas;
        int numeroQuartoOcupados;
        string morada;
        string codigoPostal;
        string localidade;
        string detalhes;
        double longitude;
        double latitude;
        string tipoImovel;

        [DataMember(Order = 0)]
        public int IdDadosHabitacao
        {
            get { return idDadosHabitacao; }
            set { idDadosHabitacao = value; }
        }

        [DataMember(Order = 1)]
        public string Tipologia
        {
            get { return tipologia; }
            set { tipologia = value; }
        }

        [DataMember(Order = 2)]
        public int NumeroQuartos
        {
            get { return numeroQuartos; }
            set { numeroQuartos = value; }
        }

        [DataMember(Order = 3)]
        public int TotalMetrosQuadrados
        {
            get { return totalMetrosQuadrados; }
            set { totalMetrosQuadrados = value; }
        }

        [DataMember(Order = 4)]
        public int AnoConstrucao
        {
            get { return anoConstrucao; }
            set { anoConstrucao = value; }
        }

        [DataMember(Order = 5)]
        public bool Wifi
        {
            get { return wifi; }
            set { wifi = value; }
        }

        [DataMember(Order = 6)]
        public bool DespesasIncluidas
        {
            get { return despesasIncluidas; }
            set { despesasIncluidas = value; }
        }

        [DataMember(Order = 7)]
        public int NumeroQuartoOcupados
        {
            get { return numeroQuartoOcupados; }
            set { numeroQuartoOcupados = value; }
        }

        [DataMember(Order = 8)]
        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        [DataMember(Order = 9)]
        public string CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }

        [DataMember(Order = 10)]
        public string Localidade
        {
            get { return localidade; }
            set { localidade = value; }
        }

        [DataMember(Order = 11)]
        public string Detalhes
        {
            get { return detalhes; }
            set { detalhes = value; }
        }

        [DataMember(Order = 12)]
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        [DataMember(Order = 13)]
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        [DataMember(Order = 14)]
        public string TipoImovel
        {
            get { return tipoImovel; }
            set { tipoImovel = value; }
        }
        /// <summary>
        /// Inicio a entidade
        /// </summary>
        public DadosHabitacao()
        {
            idDadosHabitacao = 0;
            tipologia = "";
            numeroQuartos = 0;
            totalMetrosQuadrados = 0;
            anoConstrucao = 0;
            wifi = false;
            despesasIncluidas = false;
            numeroQuartoOcupados = 0;
            morada = "";
            codigoPostal = "";
            localidade = "";
            detalhes = "";
            longitude = 0;
            latitude = 0;
            tipoImovel = "";
        }


        /// <summary>
        /// Construtor de  um datarow para uma entidade
        /// </summary>
        /// <param name="dataRow">DataRow</param>
        public DadosHabitacao(DataRow dataRow)
        {
            IdDadosHabitacao = Convert.ToInt32(dataRow["idDadosHabitacao"]);
            Tipologia = dataRow["tipologia"].ToString();
            NumeroQuartos = Convert.ToInt32(dataRow["numeroQuartos"]);
            TotalMetrosQuadrados = Convert.ToInt32(dataRow["totalMetrosQuadrados"]);
            AnoConstrucao = Convert.ToInt32(dataRow["anoConstrucao"]);
            Wifi = Convert.ToBoolean(dataRow["wifi"]);
            DespesasIncluidas = Convert.ToBoolean(dataRow["despesasIncluidas"]);
            NumeroQuartoOcupados = Convert.ToInt32(dataRow["numeroQuartoOcupados"]);
            Morada = dataRow["morada"].ToString();
            CodigoPostal = dataRow["codigoPostal"].ToString();
            Localidade = dataRow["localidade"].ToString();
            Detalhes = dataRow["detalhes"].ToString();
            Longitude = Convert.ToInt32(dataRow["longitude"]);
            Latitude = Convert.ToInt32(dataRow["latitude"]);
            TipoImovel = dataRow["tipoImovel"].ToString();
        }
    }
}