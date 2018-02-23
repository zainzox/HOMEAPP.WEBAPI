using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HOMEAPP.WEBAPI.HOMEAPP_Interfaces
{
    public interface IRepository
    {
        

        /// <summary>
        /// insert Devices...
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        DataTable RegisterUser();



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        DataTable LoginUser(string userName, string userPass);




    }
}