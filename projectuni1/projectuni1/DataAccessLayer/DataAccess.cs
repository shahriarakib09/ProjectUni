using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace projectuni1.DataAccessLayer
{

    class DataAccess
    {
        private static OracleConnection SqlCon;

        //string strConnString = ConfigurationManager.ConnectionStrings["PROJECTUNI"].ConnectionString;
        public static OracleConnection SqlConn
        {
            get
            {
                if (SqlCon == null)
                {
                    SqlCon = new OracleConnection(@"TNS_ADMIN=F:\app\oracle\product\10.2.0\server\NETWORK\ADMIN;USER ID=PROJECTUNI; Password=tiger; DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True");
                }
                else if (SqlCon.State != ConnectionState.Open)
                {
                    SqlCon.Open();
                }
                return SqlCon;
            }
        }
        public static int ExecuteUpdateQuery(string query)
            {
                OracleCommand sqcom = new OracleCommand(query, SqlConn);
                return sqcom.ExecuteNonQuery();
            }
    }
}
    
