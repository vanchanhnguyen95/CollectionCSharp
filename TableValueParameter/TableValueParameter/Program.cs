using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace TableValueParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Data Table
            DataTable myTable = CreateTable();
            myTable.Rows.Add(1, "Jignesh Trivedi");
            myTable.Rows.Add(2, "Tejas Trivedi");
            myTable.Rows.Add(3, "Rakesh Trivedi");

            SqlConnection connection = new SqlConnection("Data Source=datasever;Initial Catalog=AdventureWorks;User Id=sa;Password=password;");
            connection.Open();
            SqlCommand cmd = new SqlCommand("InsertValue", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            //Pass table Valued parameter to Store Procedure
            SqlParameter sqlParam = cmd.Parameters.AddWithValue("@TempTable", myTable);
            sqlParam.SqlDbType = SqlDbType.Structured;

            cmd.ExecuteNonQuery();
            connection.Close();

            //Create Collection class
            myDataCollection myTable1 = new myDataCollection();
            myTable1.Add(new myData { CustomerId = 4, CustomerName = "Jignesh" });
            myTable1.Add(new myData { CustomerId = 5, CustomerName = "Tejas" });
            myTable1.Add(new myData { CustomerId = 6, CustomerName = "Rakesh" });

            connection.Open();
            cmd = new SqlCommand("InsertValue", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            //Pass table Valued parameter to Store Procedure
            SqlParameter sqlParam1 = cmd.Parameters.AddWithValue("@TempTable", myTable1);
            sqlParam1.SqlDbType = SqlDbType.Structured;

            cmd.ExecuteNonQuery();
            connection.Close();

            Console.Write("Data Save Successfully.");
            Console.ReadKey();
        }
        public class myData
        {
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
        }
        public class myDataCollection : List<myData>, IEnumerable<SqlDataRecord>
        {
            IEnumerator<SqlDataRecord> IEnumerable<SqlDataRecord>.GetEnumerator()
            {
                SqlDataRecord ret = new SqlDataRecord(
                    new SqlMetaData("CustomerId", SqlDbType.Int),
                    new SqlMetaData("CustomerName", SqlDbType.VarChar, 20)
                    );

                foreach (myData data in this)
                {
                    ret.SetInt32(0, data.CustomerId);
                    ret.SetString(1, data.CustomerName);
                    yield return ret;
                }
            }
        }
        static DataTable CreateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerId", typeof(Int32));
            dt.Columns.Add("CustomerName", typeof(string));
            return dt;
        }
    }
}
