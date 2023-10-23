using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagementSystem.Class
{
     class AddConnection
    {
        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionStrings["ScoreManagementSystem"].ConnectionString;

        }
    }
}
