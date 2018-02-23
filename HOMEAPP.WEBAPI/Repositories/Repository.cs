using HOMEAPP.WEBAPI.HOMEAPP_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using HOMEAPP.DATA;



namespace HOMEAPP.WEBAPI.HOMEAPP_Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class Repository : IRepository
    {

        //private IConnection dbInterface;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        public Repository()
        {
            //dbInterface = connection;
        }



       
        /// <summary>
        /// Insert Device 
        /// </summary>
        /// <param name="UserRegisterationDate"></param>
        /// <returns></returns>
        public DataTable RegisterUser()
        {

            //try
            //{

            //    SqlParameter[] paramsArray =
            //    {
            //        new SqlParameter("@UserName", UserName ),

            //        new SqlParameter("@UserPassword", UserPassword ),

            //        new SqlParameter("@IsAuthenticated", IsAuthenticated ),

            //        new SqlParameter("@UserTypeID", UserTypeID ),

            //        new SqlParameter("@UserEmail", UserEmail ),

            //        new SqlParameter("@UserRegisterationDate", UserRegisterationDate )


            //    };

            //    var Data = dbInterface.GetDataTable("InsertUser", paramsArray);
            //    return Data;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            return null;
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPass"></param>
        /// <returns></returns>
        public DataTable LoginUser(string userName, string userPass)
        {

            //try
            //{

            //        SqlParameter[] paraArr = {

            //        new SqlParameter("@Username",userName),
            //        new SqlParameter("@Password",userPass)
            //    };

            //    return dbInterface.GetDataTable("AdminLogin", paraArr);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            return null;
        }






    }
}