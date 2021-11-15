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
        public bool addProduct(int ID_product,string name_product,int price,int id_company)
        {

            string sqlString = "Insert Into Product Values(" + ID_product.ToString() + ",'" + name_product + "'," + price.ToString() + ","+id_company.ToString()+")";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        //xoa phone
        public bool deleteProduct(ref string err, string ID_product)
        {
            string sqlString = "Delete From Product where ID_product = " + ID_product.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        // cap nhat phone
        public bool updateProduct(int ID_product, string name_product, int price, int id_company)
        {
            string sqlString = "Update Phone Set Name_product = '" + name_product + "', Price = " + price.ToString() + " where ID_product = " + ID_product.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet search_ProductName(string name)
        {
            string sqltring = "SELECT * FROM Product WHERE Name_product LIKE '" + name + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }
    }
}
