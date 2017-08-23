using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace K.Booking.Data
{
    public class Access
    {
        private string ConnectionString()
        {
            string useDB = ConfigurationManager.AppSettings["UseConnection"];
            string key = ConfigurationManager.AppSettings[useDB];
            return key;
        }

        private SqlConnection _con;
        private SqlConnection Connection
        {
            get
            {
                if (_con == null)
                    _con = new SqlConnection();
                _con.ConnectionString = ConnectionString();
                return _con;
            }

        }

        public int Save(string SQL)
        {
            return ExecuteNonQuery(SQL);
        }

        public int Delete(string SQL)
        {
            return ExecuteNonQuery(SQL);
        }

        public int Save(SqlCommand cmd)
        {
            return ExecuteNonQuery(cmd);
        }

        public int Delete(SqlCommand cmd)
        {
            return ExecuteNonQuery(cmd);
        }

        public void SaveFromArray(ArrayList SQLArray)
        {
            using (SqlConnection con = Connection)
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                for (int i = 0; i < SQLArray.Count; i++)
                {
                    string SQL = CleanSQL(SQLArray[i].ToString());
                    using (SqlCommand cmd = new SqlCommand(SQL, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private string CleanSQL(string SQL)
        {
            return SQL.Replace("true", "1")
                .Replace("True", "1")
                .Replace("false", "0")
                .Replace("False", "0")
                .Replace("#", "'");
        }

        public DataSet getDataset(string SQL)
        {
            DataSet ds = new DataSet();
            SQL = CleanSQL(SQL);
            string test;
            try
            {
                using (SqlConnection con = Connection)
                {
                    using (SqlCommand cmd = new SqlCommand(SQL, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        if (cmd.Connection.State != ConnectionState.Open)
                            cmd.Connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(ds);

                    }
                }
            }
            catch (Exception ex)
            {
                test = ex.ToString();
            }
            

            return ds;
        }

        private int ExecuteNonQuery(SqlCommand cmd)
        {
            using (cmd)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Connection;

                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        private SqlDataReader ExecuteReader(SqlCommand cmd)
        {
            using (cmd)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Connection;

                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();

                return cmd.ExecuteReader();
            }
        }

        private int ExecuteNonQuery(string SQL)
        {
            SQL = CleanSQL(SQL);
            using (SqlConnection con = Connection)
            {
                using (SqlCommand cmd = new SqlCommand(SQL, con))
                {
                    cmd.CommandType = CommandType.Text;

                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();

                    return cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
