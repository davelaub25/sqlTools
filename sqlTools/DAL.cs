using System;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;


namespace sqlTools
{
    public class DAL
    {
        public static DataTable getMetaData(String connString)
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
    }
}
