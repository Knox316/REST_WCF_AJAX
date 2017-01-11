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

    [ServiceContract]
    public interface ITryTwitterAdd
    {
        /// <summary>
        /// Metodo para partilhar uma Habitacao pelo twitter
        /// </summary>
        /// <param name="hab"></param>
        /// <returns></returns>
        [OperationContract()]
        [WebInvoke(Method = "POST", UriTemplate = "/status/Habitacao", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool TwiHabitacao(Habitacao hab);
    }
}
