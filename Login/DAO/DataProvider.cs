using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.DAO
{
    class DataProvider
    {
        private static DataProvider instance;

        //public static List<Control_User.Item> ListItem;
        static string strCon = "Data Source=DESKTOP-LBAULH5;Initial Catalog=QuanLyKho;Integrated Security=True";
        private static string connectionStr = "Data Source=DESKTOP-5E0I4OU\\SQLEXPRESS01;Initial Catalog=QuanLyKho;Integrated Security=True";
        private static SqlConnection conn;
        public static void IntializeConnection()
        {
            if (conn != null)
                conn.Close();

            conn = new SqlConnection(strCon);
        }

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value;
        }

        public static DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand command = new SqlCommand(query, sqlCon);
                if(parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }

                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                sqlCon.Close();
            }
            return dt;
        }
        //ExecuteNonQuery: Insert, Update, Delete
        public static int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int kq = 0;
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand command = new SqlCommand(query, sqlCon);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                try
                {
                    kq = command.ExecuteNonQuery();
                }
                catch
                {
                    return kq;
                }
                sqlCon.Close();
            }
            return kq;
        }

        public static object ExecuteScalar(string query, object[] parameter = null)
        {
            object kq = 0;
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand command = new SqlCommand(query, sqlCon);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                kq = command.ExecuteScalar();
                sqlCon.Close();
            }
            return kq;
        }

        //View Stored Procedure
        public static DataTable ViewStoredProc(string procName, int SoHD)
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection(strCon);
            SqlCommand command = connect.CreateCommand();
            command.CommandText = procName;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SoHD", SoHD);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            connect.Close();
            return dt;
        }
        //
        public static DataTable ExcuseQuery1(string strQuery)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(strQuery, conn);

            DataTable result = new DataTable();
            result.Load(cmd.ExecuteReader());

            conn.Close();

            return result;
        }
        public static void ExcuseNonQuery1(string Query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(Query, conn);

            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
