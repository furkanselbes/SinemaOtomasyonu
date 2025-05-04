using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace baglantiClass
{
    public static class bagkod
    {
        private static string conString = "Server=Furkan\\SQLEXPRESS;Database=SinemaOtomasyonu;Trusted_Connection=True;MultipleActiveResultSets=True";

        public static string ConnectionString
        {
            get { return conString; }
            set { conString = value; }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(conString);
        }
    }
}
