using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HOMEAPP.WEBAPI.HOMEAPP_Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IManager
    {




        /// user Login 
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        DataTable LoginUser();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vmUser"></param>
        /// <returns></returns>
        //Insert the new  deices 
        DataTable RegisterUser();

        /// <summary>
        /// Get all home list...
        /// </summary>
        /// <returns></returns>
       









    }
}