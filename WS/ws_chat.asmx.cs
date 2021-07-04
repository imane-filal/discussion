using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Threading;

namespace WS
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class ws_chat : System.Web.Services.WebService
    {
        List<Participant> participants = new List<Participant>();

        [WebMethod]
        public List<Participant> Participer(String pseudo)
        {
            Thread.Sleep(10000);
            
                bool valable = !DB.Exists(pseudo);
                if (valable)
                {
                    DB.Add(pseudo);
                    return DB.GetParticipants();
                }
                else return null;
            }
        }
    
}