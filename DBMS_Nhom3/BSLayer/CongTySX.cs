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
        public int returnMaxID()
        {
            string sqlString = "select max(ID_company) as max_id from CongTySX";
            DataSet ds = db.ExcuteQueryDataSet(sqlString, CommandType.Text);
            try
            {
                if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                    return 0;
                else
                    return int.Parse(ds.Tables[0].Rows[0]["max_id"].ToString());
            }
            catch (Exception error)
            {
                return 0;
            }

        }
        public DataSet GetCompany()
        {
            return db.ExcuteQueryDataSet("select * from CongTySX", CommandType.Text);
        }
        public DataSet FindCongTySX(string name)
        {
            return db.ExcuteQueryDataSet("select * from CongTySX where Company_name Like '" + name + "%'", CommandType.Text);
        }
        public DataSet FindCongTySX_byID(string id)
        {
            return db.ExcuteQueryDataSet("select * from CongTySX where ID_company = " + id, CommandType.Text);
        }

        public bool addCompany(string company_name, string address)
        {

            string sqlString = "Insert Into CongTySX Values(dbo.IDmaxCompany()+1,'" + company_name + "','" + address + "')";
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
