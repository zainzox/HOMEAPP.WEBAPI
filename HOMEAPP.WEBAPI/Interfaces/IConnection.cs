using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HOMEAPP.WEBAPI.HOMEAPP_Interfaces
{
    public interface IConnection
    {
        DataTable GetDataTable(string procName, SqlParameter[] paramsArray);
        DataSet GetDataSet(string procName, SqlParameter[] paramsArray); 


    }
}