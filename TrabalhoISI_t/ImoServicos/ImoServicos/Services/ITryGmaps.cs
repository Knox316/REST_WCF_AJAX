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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITryGmaps" in both code and config file together.
    [ServiceContract]
    public interface ITryGmaps
    {
        /// <summary>
        /// Metodo para ver e atualizar referencias no GMAPS
        /// Nao acabei
        /// </summary>
        /// <param name="idh"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        string getPacientes(string idh);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        string getDirecciones(string iddhab);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        string ActualizarDireccion(DadosHabitacao dh);
    }
}
