using HOMEAPP.WEBAPI.HOMEAPP_Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Timers;
using System.Web.Http;
using System.Threading;

namespace HOMEAPP.WEBAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/v1")]
    public class HOMEAPPController : ApiController
    {
      
        private static Action NonStaticDelegate;
        private IManager managerService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="manager"></param>
        public HOMEAPPController(IManager manager)
        {
            managerService = manager;
            
            
        }

        


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("RegisterUser")]
        [HttpPost]
        public HttpResponseMessage RegisterUser()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, managerService.RegisterUser());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("LoginUser")]
        [HttpPost]
        public HttpResponseMessage LoginUser()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, managerService.LoginUser());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }









    }
}
