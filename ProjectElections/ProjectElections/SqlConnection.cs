using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjectElections
{
    public class sqlConnection
    {
        private SqlConnection con;
        private static sqlConnection instance;
        private SqlCommand cmd;
        private DataTable ds;
        private SqlDataAdapter sda;
        private static string connection_string = "Data Source=ROTEM\\rotem;Initial Catalog=ElectionsProjectNew;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(connection_string);

        private sqlConnection()
        {
            con = new SqlConnection(connection_string);
            con.Open();
        }

        public static sqlConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new sqlConnection();
                }
                return instance;
            }
        }

        /// <summary>
        /// getTableBycommand - returns table by given command
        /// </summary>
        /// <param name="command">the command string</param>
        /// <returns></returns>
        public static DataTable getTableBycommand(string command)
        {
            SqlCommand comm = new SqlCommand(command);
            comm.Connection = connection; comm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data_a = new SqlDataAdapter(comm);
            DataTable matrix = new DataTable();
            data_a.Fill(matrix); return matrix;
        }

        /// <summary>
        /// getTableBycommand - returns table by given command
        /// </summary>
        /// <param name="command">the command string</param>
        /// <param name="par">paramaters array</param>
        /// <returns></returns>
        public static DataTable getTableBycommand(string command, SqlParameter[] par)
        {
            SqlCommand comm = new SqlCommand(command);
            comm.Connection = connection; comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddRange(par);
            SqlDataAdapter data_a = new SqlDataAdapter(comm);
            DataTable matrix = new DataTable();
            data_a.Fill(matrix);
            return matrix;
        }

        public void sqlCommand(string querytext)
        {
            cmd = new SqlCommand(querytext, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        }
        public DataTable GetData(string Command)
        {
            this.NonQueryE();
            sda = new SqlDataAdapter(cmd);
            ds = new DataTable();
            sda.Fill(ds);
            return ds;
        }
        public void NonQueryE()
        {
            cmd.ExecuteNonQuery();
        }

        public void InsertValstring(string query, string val)
        {
            cmd.Parameters.AddWithValue(query, val);
        }
        public void InsertValDate(string query, DateTime val)
        {
            cmd.Parameters.AddWithValue(query, val);
        }
        public void InsertValint(string query, int val)
        {
            cmd.Parameters.AddWithValue(query, val);
        }

        public void InsertValBool(string query, bool val)
        {
            cmd.Parameters.AddWithValue(query, val);
        }

        public void InsertValDOB(string query, DateTime val)
        {
            cmd.Parameters.AddWithValue(query, val);
        }

        public string getVal(string name)
        {
            SqlParameter sqlparam = new SqlParameter(name, DbType.Int32);
            sqlparam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sqlparam);
            NonQueryE();
            return cmd.Parameters[name].Value.ToString();
        }

        public static string getConnectionString()
        {
            return connection_string;
        }
    }
}
