using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BL.DAO
{
    public class Connection
    {
        private const string BillerDB = "BillerDB";

        public static string BillerDBConnection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[BillerDB].ConnectionString;
            }
        }
    }
}
