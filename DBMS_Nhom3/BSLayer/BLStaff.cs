using DBMS_Nhom3.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBMS_Nhom3.BSLayer
{
    class BLStaff
    {
        string err;
        DBMain db = null;
        public BLStaff()
        {
            db = new DBMain();
        }
        public DataSet GetStaff()
        {
            return db.ExcuteQueryDataSet("select * from Staff", CommandType.Text);
        }
        public DataSet FindStaff(string name)
        {
            return db.ExcuteQueryDataSet("select * from Staff where username Like '" + name + "%'", CommandType.Text);
        }


        public bool checkAccount(string user, string pass)
        {
            string sqlcmm = "select * from Staff where username = '" + user + "' and password = '" + pass + "'";

            DataSet ds = db.ExcuteQueryDataSet(sqlcmm, CommandType.Text);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else return true;
        }
        public bool isAdmin(string user)
        {
            string sqlcmm = "select*from Staff where username = '" + user + "' and Posision = 'admin'";
            DataSet ds = db.ExcuteQueryDataSet(sqlcmm, CommandType.Text);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else return true;
        }

        public bool ExistAccount(string user)
        {
            string sqlcmm = "select * from Staff where username = '" + user + "'";

            DataSet ds = db.ExcuteQueryDataSet(sqlcmm, CommandType.Text);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else return true;
        }
        // them phone
        public bool addStaff(string user, string pass,string Name_staff,string phone,string address,string position,string gender)
        {

            string sqlString = "Insert Into Staff Values('" + user + "','" + pass + "','" + Name_staff + "','" + phone + "','" + address + "','" + position + "','" + gender + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //xoa phone
        public bool deleteAccount(ref string err, string user)
        {
            string sqlString = "Delete From Accounts where username = '" + user + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        // cap nhat phone
        public bool updateAccount(string user, string pass, ref string err)
        {
            string sqlString = "Update Staff Set password = '" + pass + "' where username = '" + user + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool updateStaffInfor(string user, string pass, string Name_staff, string phone, string address, string position, string gender,ref string err)
        {
            string sqlString = "Update Staff Set Name_Staff = '" + Name_staff+ "Phone = '" + phone+ "Address = '"+address+ "Position = '"+position+ "Gender = '"+gender + "' where username = '" + user + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}

