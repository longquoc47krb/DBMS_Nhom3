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
            return db.ExcuteQueryDataSet("select * from Product", CommandType.Text);
        }
        public int returnMaxID()
        {
            string sqlString = "select max(ID_product) as max_id from Product";
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

        // them phone
        public bool addProduct(int ID_product,string name_product,string price,string id_company)
        {

            string sqlString = "Insert Into dbo.Product Values('" + name_product  + "'," + ID_product.ToString() + "," + price+ ","+id_company+")";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        //xoa phone
        public bool deleteProduct(ref string err, string ID_product)
        {
            string sqlString = "Delete From dbo.Product where ID_product = " + ID_product;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        // cap nhat phone
        public bool updateProduct(string ID_product, string name_product, string price, string id_company)
        {
            string sqlString = "Update dbo.Product Set Name_product = '" + name_product + "', Price = " + price +",ID_company = "+id_company + " where ID_product = " + ID_product;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet search_ProductName(string name)
        {
            string sqltring = "SELECT * FROM dbo.Product WHERE Name_product LIKE '" + name + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }
    }
}
