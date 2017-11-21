using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NDATA_MRP
{
    class ConnectDB
    {
        public SqlConnection Conn = null;

        private String connectString = "";
        public ConnectDB()
        {
            //connectString = "DSN=PostgreSQL35W";
            //connectString = "DSN=NDATA_MRP";
            connectString = ConfigurationManager.ConnectionStrings["NDATA_MRP.Properties.Settings.NDATAConnectionString"].ConnectionString;
            //connectString = "DRIVER={MySQL ODBC 5.3 Unicode Driver};SERVER=localhost; DATABASE=PATAYA_MRP;USER=pataya;PASSWORD=vnp@2018;";
            //connectString = "Driver ={ PostgreSQL Unicode}; SERVER=localhost; DATABASE=PATAYA_MRP;USER=pataya;PASSWORD=vnp@2018;";
        }
        private SqlConnection Connect;
        public SqlConnection Connection
        {
            get { return Connect; }
            set { Connection = value; }
        }

        public SqlConnection getConnection()
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();
            return connect;
        }
        public bool checkTable(String sSQL)
        {
            bool flag = false;
            SqlCommand cm = new SqlCommand(sSQL, getConnection());
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read()) flag = true;
            cm.Dispose();
            return flag;
        }
    }
}
