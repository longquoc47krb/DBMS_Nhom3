using DBMS_Nhom3.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBMS_Nhom3.BSLayer
{
    class CongTySX
    {
        string err;
        DBMain db = null;
        public CongTySX()
        {
            db = new DBMain();
        }
        public DataSet GetStaff()
        {
            return db.ExcuteQueryDataSet("select * from CongTySX", CommandType.Text);
        }
        public DataSet FindCongTySX(string name)
        {
            return db.ExcuteQueryDataSet("select * from CongTySX where Company_name Like '" + name + "%'", CommandType.Text);
        }


        public bool addCompany(int id,string company_name, string address)
        {

            string sqlString = "Insert Into CongTySX Values(" + id + ",'" + company_name + "','" + address + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //xoa phone
        public bool deleteCompany(ref string err, string id)
        {
            string sqlString = "Delete From CongTySX where ID_company = " + id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        // cap nhat phone
        public bool updateCompany(int id,string company_name, string address, ref string err)
        {
            string sqlString = "Update CongTySX Set Company_name = '" + company_name + "',address = '"+address +"' where ID_company = " + id.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
