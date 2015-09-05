using System;
using System.Configuration;
namespace Light.Command
{
   public class PubConstant
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string GetConnectionString
        {
            get
            {
                string _connectionString = ConfigurationManager.ConnectionStrings["LightConnectionString"].ConnectionString;
                return _connectionString;
            }
        }

    }
}
