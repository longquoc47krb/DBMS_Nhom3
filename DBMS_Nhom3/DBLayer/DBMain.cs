using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DBMS_Nhom3.DBLayer
{
    class DBMain
    {
        string Connstr = "Data Source=PC-RTX3060Ti;Initial Catalog=ShopDB;Integrated Security=True"; // thêm conn, khi chạy cần sửa lại data string
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMain()
        {
            conn = new SqlConnection(Connstr);
            //try
            //{

            //}
            //catch
            //{
            //    try
            //    {
            //        conn = new SqlConnection(ConnStr2);
            //    }
            //    catch
            //    {
            //        conn = new SqlConnection(ConnStr3);
            //    }
            //}

            comm = conn.CreateCommand();
        }
        static void conn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        public DataSet ExcuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            conn.InfoMessage += new SqlInfoMessageEventHandler(conn_InfoMessage);
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            //try
            //{
            try
            {
                
                comm.ExecuteNonQuery();
                conn.InfoMessage -= new SqlInfoMessageEventHandler(conn_InfoMessage);


            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            
            //System.Windows.Forms.MessageBox.Show("Successed");
            f = true;

            //}
            //catch(SqlException err)
            //{
            //    error = err.Message;
            //    System.Windows.Forms.MessageBox.Show("Un Successed");
            //}
            //finally
            //{
            //    conn.Close();
            //}
            return f;

        }


    }

}
