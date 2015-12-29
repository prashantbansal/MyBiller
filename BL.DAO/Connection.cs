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
