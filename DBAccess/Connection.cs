using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    public class Connection
    {
        static string strConnectionString = "Data Source=XE;User Id=hospital2;Password=hospital2;";
        OracleConnection objConn;

        public OracleConnection DB()
        {
            if (objConn == null)
            {
                objConn = new OracleConnection(strConnectionString);
            }
            return objConn;
        }
    }
}
