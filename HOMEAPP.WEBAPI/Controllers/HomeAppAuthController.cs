using HOMEAPP.WEBAPI.Models;
using HOMEAPP.WEBAPI.HOMEAPP_Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace HOMEAPP.WEBAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/ds/v2")]
    public class HOMEAPPAuthController : ApiController
    {

        private IManager managerService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="manager"></param>
        public HOMEAPPAuthController(IManager manager)
        {
            managerService = manager;
        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns>User Id</returns>
        [Route("login")]
        [HttpPost]
        [Authorize]
        public HttpResponseMessage UserLogin(vm_User objUser)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, managerService.UserLogin(objUser));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }





        /// <summary>
        /// Register new User ..
        /// </summary>
        [Route("register")]
        [HttpPost]
        
        public HttpResponseMessage InsertNewUser(vm_User vmUser)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, managerService.InsertUser(vmUser));


            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





    }
}
