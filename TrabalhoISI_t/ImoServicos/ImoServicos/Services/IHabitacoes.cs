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
    /// <summary>
    /// Assinaturas POST,GET,PUT,DELETE Para as Habitacoes
    /// </summary>
    [ServiceContract]
    public interface IHabitacoes
    {
        [OperationContract()]
        [WebInvoke(Method = "GET", UriTemplate = "/ListarHabitacao", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Habitacao> ListarHabitacao();

        [OperationContract()]
        [WebInvoke(Method = "GET", UriTemplate = "/ProcurarHabitacaoId/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Habitacao ProcurarHabitacaoId(string id);

        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "/AdicionarHabitacao", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AdicionarHabitacao(Habitacao hab);

        [OperationContract()]
        [WebInvoke(Method = "PUT", UriTemplate = "/UpdateHabitacao", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void UpdateHabitacao(Habitacao hab);

        [OperationContract()]
        [WebInvoke(Method = "DELETE", UriTemplate = "/ApagarHabitacao/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void ApagarHabitacao(string id);
    }
}
