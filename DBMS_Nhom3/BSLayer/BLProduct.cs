using DBMS_Nhom3.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBMS_Nhom3.BSLayer
{
    class BLProduct
    {
        string err;
        DBMain db = null;
        public BLProduct()
        {
            db = new DBMain();
        }
        public DataSet GetProduct()
        {
            return db.ExcuteQueryDataSet("select * from view_product", CommandType.Text);
        }


        // them phone
        public bool addProduct(string name_product,string price,string id_company,string warranty_month)
        {

            string sqlString = "Insert Into dbo.Product Values('" + name_product  + "',dbo.IDmaxProduct()+1," + price+ ","+id_company+","+warranty_month+")";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        //xoa phone 
        public bool deleteProduct(ref string err, string ID_product)
        {
            string sqlString = "Delete From dbo.Product where ID_product = " + ID_product;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        // cap nhat phone
        public bool updateProduct(string ID_product, string name_product, string price, string id_company, string warranty_month)
        {
            string sqlString = "Update dbo.Product Set Name_product = '" + name_product + "', Price = " + price +",ID_company = "+id_company + ",warranty_month = "+warranty_month + " where ID_product = " + ID_product;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet search_ProductName(string name)
        {
            string sqltring = "SELECT * FROM dbo.Product WHERE Name_product LIKE '" + name + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }
    }
}
