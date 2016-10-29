using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClientScheduler.DAL;

namespace ClientScheduler.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        public ClientScheduler.DAL.ClientSchedulerModel ClientSchedulerModel;

        public DataFactoryProvider DataMapperProvider;

        protected BaseApiController()
        {

            if (ClientSchedulerModel == null)
            {
                ClientSchedulerModel = new ClientSchedulerModel();
            }

            if (DataMapperProvider == null)
            {
                DataMapperProvider = new DataFactoryProvider();
            }


        }

    }

}
