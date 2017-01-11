using ImoServicos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ImoServicos.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDadosHabitacoes" in both code and config file together.
    [ServiceContract]
    public interface IDadosHabitacoes
    {
        /// <summary>
        /// GET Dados Habitacoes
        /// </summary>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "GET", UriTemplate = "/ListarDadosHabitacao", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<DadosHabitacao> ListarDadosHabitacao();

        /// <summary>
        /// GET Dados habitacoes by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "GET", UriTemplate = "/ProcurarDadosHabitacao/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        DadosHabitacao ProcurarDadosHabitacao(string id);
    }
}
