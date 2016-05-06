using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceTicket" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceTicket
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/Add/",
            Method = "POST")]
        Ticket Add(Ticket ticket);


        [OperationContract]
        [WebGet(UriTemplate = "/Tickets", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<Ticket> GetAlls(DateTime initialDate, DateTime finalDate);

        [OperationContract]
        [WebGet(UriTemplate = "/Customer/{id}", ResponseFormat = WebMessageFormat.Json)]
        Ticket Get(string id);

    }
}
