using HOMEAPP.WEBAPI.HOMEAPP_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace HOMEAPP.WEBAPI.HOMEAPP_Managers
{
    /// <summary>
    /// 
    /// </summary>
    public class Manager : IManager
    {
        private IRepository _Repository;
        ///<summary>
        ///contructor...</summary>

        public Manager(IRepository respository)
        {
            _Repository = respository;
        }


        


        /// <summary>
        /// Register new devices asdsdsd...used
        /// </summary>
        /// <param name="objvmUserRegister"></param>
        /// <returns></returns>
        public DataTable RegisterUser()
        {
            try
            {
                return null;


            }
            catch (Exception ex)
            {
                ////insert the exception if is there any....
                //_Repository.InsertExceptions(
                //     100,
                //    "Users| InsertUser",
                //    objvmUserRegister.UserName,
                //    ex.Message,
                //    ex.StackTrace,
                //    null,
                //    DateTime.UtcNow.AddHours(5)
                //    );

                throw;
            }

        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        public DataTable LoginUser()
        {
            try
            {
                //return _Repository.UserLogin(objUser.UserName, objUser.UserPassword);
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}