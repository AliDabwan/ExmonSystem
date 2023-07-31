using ExmonSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem
{
   public class AppSettings
    {
        Configuration config;
        public AppSettings()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);


        }
        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }
        public void SaveConnectionString(string key,string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";

            config.Save(ConfigurationSaveMode.Modified);
        }

        public SqlConnectionStringBuilder conDetails(string key)
        {

            string connectString = GetConnectionString(key); 
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);
            // Retrieve the DataSource property.    
            return builder;
        }
    }
}
