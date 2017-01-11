using Facebook;
using ImoServicos.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;

namespace ImoServicos.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TryFacebookAdd" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TryFacebookAdd.svc or TryFacebookAdd.svc.cs at the Solution Explorer and start debugging.
    public class TryFacebookAdd : ITryFacebookAdd
    {
        /// <summary>
        /// Metodo para Postar uma habitacao no facebook com uma imagem anexada
        /// </summary>
        /// <param name="hab"></param>
        /// <returns></returns>
        bool ITryFacebookAdd.FaceHabitacao(Habitacao hab)
        {
            //Codigo da documentação de facebookdevelopers
            try
            {
                //token de acesso            
                var accessToken = "EAACEdEose0cBAJZB1Ggh0F5TI4G7OuTYQ6m53EvFkqcVRRybLzTGti289uJM2tS0ETuVsbNk018mBxyIpx0YfzjmkVz25I07ZCKBg5X6Qlg6i29rF2d6lCZBH256JZAHTZBW2tAcrkxndNF0F7sB3Pqodc2jgG22uvQ0sZByqfVQZDZD";

                FacebookClient fbc = new FacebookClient(accessToken);

                //mensagem a ser enviada
                string encodeaccesstoken = HttpUtility.UrlEncode(accessToken);
                string mensagem =
                  "ID Habitacao  : " + hab.IdHabitacao + "\n" +
                  "ID Cliente : " + hab.IdCliente + "\n" +
                  "Preco : " + hab.Preco + "\n" +
                  "Ocupado : " + hab.Ocupado + "\n" +
                  "Tipo Ocupacao : " + hab.TipoOcupacao + "\n";

                var paramaters = new Dictionary<string, object>
                                {
                                    { "display", "popup" },
                                    { "response_type", "token" }
                                };

                paramaters.Add("name", mensagem);
                paramaters.Add("message", mensagem);


                //FacebookMediaObject media = new FacebookMediaObject();
                string filename = "http://imm-tecnologia.com.br/imobiliaria-modelo-2/wp-content/uploads/2016/11/casa-topo.png";
                paramaters.Add("link", filename);

                //localziacao de envio
                fbc.Post("me/feed", paramaters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
