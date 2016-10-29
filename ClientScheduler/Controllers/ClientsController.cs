using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClientScheduler.Models;

namespace ClientScheduler.Controllers
{
    public class ClientsController : BaseApiController
    {

        public ClientsController() : base()
        {

        }


        /// <summary>
        /// Get clients.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get(int clientId)
        {

            try
            {
                var clients = ClientSchedulerModel.Clients
                                                        .Select(r => r)
                                                        .ToList();


                var result = new List<ClientModel>();

                foreach (var client in clients)
                {
                    result.Add( DataMapperProvider.MapEntityToModel<DAL.Client, ClientModel>(client) );
                }


                return Request.CreateResponse( HttpStatusCode.OK, result );

            }
            catch (Exception ex)
            {

                // Log Exception

                return Request.CreateResponse(HttpStatusCode.NotFound, "No Clients found in the system due to an unexpected error.");

            }

        }

        /// <summary>
        /// Gets the specified client identifier.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <returns></returns>
        [Route("api/v2/clients/{clientId}")]
        public HttpResponseMessage GetV2(int clientId)
        {

            try
            {
                var client = ClientSchedulerModel.Clients
                                                        .FirstOrDefault(r => r.ClientId == clientId);


                return Request.CreateResponse(HttpStatusCode.OK, DataMapperProvider.MapEntityToModel<DAL.Client, ClientModel>(client));

            }
            catch (Exception ex)
            {

                // Log Exception

                return Request.CreateResponse(HttpStatusCode.NotFound, "No Clients found in the system due to an unexpected error.");

            }

        }

    }
}
