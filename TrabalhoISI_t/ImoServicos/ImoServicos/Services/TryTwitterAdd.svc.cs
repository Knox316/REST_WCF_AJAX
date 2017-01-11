using ImoServicos.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace ImoServicos.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TryTwitterAdd" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TryTwitterAdd.svc or TryTwitterAdd.svc.cs at the Solution Explorer and start debugging.
    public class TryTwitterAdd : ITryTwitterAdd
    {
        public bool TwiHabitacao(Habitacao hab)
        {
            try
            {
                
                string mensagem =
                       "ID Habitacao  : " + hab.IdHabitacao + "\n" +
                       "ID Cliente : " + hab.IdCliente + "\n" +
                       "Preco : " + hab.Preco + "\n" +
                       "Ocupado : " + hab.TipoOcupacao + "\n" +
                       "Detalhes : " + hab.Ocupado + "\n";


      
                // Generate credentials that we want to use

                //var creds = new TwitterCredentials("CONSUMER_KEY", "CONSUMER_SECRET", "ACCESS_TOKEN", "ACCESS_TOKEN_SECRET");

                var creds = new TwitterCredentials("yOL0Zct84XYBHDBVPjqjF7gwI", "ebbDgSawNG6RkMWU9FXTLuc47DzeWVUM2YxL3NLzFP7kVI1rXq", "225601284-eTK3PJJ5ugTlWRjphJw2ykjvcduIPQDUtQYDhp6e", "joYZroDfb0NLtDMJ9lgMYyxdXRXU7rHdrkQyoSkOFNcno");

                // Use the ExecuteOperationWithCredentials method to invoke an operation with a specific set of credentials
                var tweet = Auth.ExecuteOperationWithCredentials(creds, () =>
                {
                    return Tweet.PublishTweet(mensagem);
                });
                return true;
            }
            catch (Exception ex)
            {
                //throw new Exception("erro", ex);
                return false;
            }
            

                /*
                string mensagem =
                       "ID Habitacao  : " + hab.IdHabitacao + "\n" +
                       "ID Cliente : " + hab.IdCliente + "\n" +
                       "Preco : " + hab.Preco + "\n" +
                       "Ocupado : " + hab.TipoOcupacao + "\n" +
                       "Detalhes : " + hab.Ocupado + "\n";
                string filename = "http://imm-tecnologia.com.br/imobiliaria-modelo-2/wp-content/uploads/2016/11/casa-topo.png";
                byte[] file1 = File.ReadAllBytes(filename);
                var media = Upload.UploadImage(file1);

                //var creds = new TwitterCredentials("CONSUMER_KEY", "CONSUMER_SECRET", "ACCESS_TOKEN", "ACCESS_TOKEN_SECRET");

                var creds = new TwitterCredentials("yOL0Zct84XYBHDBVPjqjF7gwI", "ebbDgSawNG6RkMWU9FXTLuc47DzeWVUM2YxL3NLzFP7kVI1rXq", "225601284-eTK3PJJ5ugTlWRjphJw2ykjvcduIPQDUtQYDhp6e", "joYZroDfb0NLtDMJ9lgMYyxdXRXU7rHdrkQyoSkOFNcno");

                // Use the ExecuteOperationWithCredentials method to invoke an operation with a specific set of credentials
                var tweet = Auth.ExecuteOperationWithCredentials(creds, () =>
                {
                    return Tweet.PublishTweet(mensagem, new PublishTweetOptionalParameters
                    {

                        Medias = new List<IMedia> { media }

                    });

                });
                return true;
            }
            catch //(Exception ex)
            {
                //throw new Exception("erro", ex);
                return false;
            }
            */
            }

    }
}
