using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem 
{
    public class SQLHelpr
    {
        SqlConnection cn;
        public SQLHelpr(String connectionString) 
        {
            cn = new SqlConnection(connectionString);
        }
        public  bool IsConnection
        {
            get
            {
                try
                {
                    if (cn.State == System.Data.ConnectionState.Closed)
                        cn.Open();
                    return true;
                }
                catch 
                {

                    return false;
                }
              
            }
        }
    }
}
