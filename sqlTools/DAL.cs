using System;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;


namespace sqlTools
{
    public class DAL
    {
        public static DataTable getColumnMetaData(String connString, String schemaName)
        {
            var con = new SqlConnection(connString);
            Console.WriteLine("Attempting to connect to database");
            con.Open();
            Console.WriteLine("Connected");
            var schema = con.GetSchema("Columns");
            //DisplayData(schema, schemaName);
            con.Close();
            return schema;
        }
        public static DataTable getTableMetaData(String connString)
        {
            var con = new SqlConnection(connString);
            Console.WriteLine("Attempting to connect to database");
            con.Open();
            Console.WriteLine("Connected");
            var schema = con.GetSchema("Tables");
            DisplayData(schema);
            con.Close();
            return schema;
        }
        public static DataTable getSchemaMetaData(String connString)
        {
            var con = new SqlConnection(connString);
            Console.WriteLine("Attempting to connect to database");
            con.Open();
            Console.WriteLine("Connected");
            var schema = con.GetSchema("Tables");
            DisplayData(schema);
            con.Close();
            return schema;
        }
        public static DataTable getDbaseMetaData(String connString)
        {
            var con = new SqlConnection(connString);
            Console.WriteLine("Attempting to connect to database");
            con.Open();
            Console.WriteLine("Connected");
            var schema = con.GetSchema("Databases");
            DisplayData(schema);
            con.Close();
            return schema;
        }
        public static DataTable getServerList()
        {
            return SqlDataSourceEnumerator.Instance.GetDataSources();
        }
        private static void DisplayData(System.Data.DataTable table)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    Console.WriteLine("{0} = {1}", col.ColumnName, row[col]);
                }
                Console.WriteLine("============================");
            }
        }
        private static void DisplayData(System.Data.DataTable table, String schemaName)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {
                if (row[1].ToString().Equals(schemaName))
                {
                    foreach (System.Data.DataColumn col in table.Columns)
                    {
                        Console.WriteLine("{0} = {1}", col.ColumnName, row[col]);
                    }
                    Console.WriteLine("============================");
                }
            }
        }
        public static String buildConnString(String username, String pass, String serverName)
        {
            String conn = String.Format("user id={0}; password={1}; server={2}; Trusted_Connection=yes; connection timeout=30", username, pass, serverName);
            return conn;
        }
        public static String buildConnString(String username, String pass, String serverName, String dbaseName)
        {
            String conn = String.Format("user id={0}; password={1}; server={2}; Database={3}; Trusted_Connection=yes; connection timeout=30", username, pass, serverName, dbaseName);
            return conn;
        }
    }
}
