using DBMS_Nhom3.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBMS_Nhom3.BSLayer
{
    class BLTransaction_Details
    {
        DBMain db = null;
        string err;
        public BLTransaction_Details()
        {
            db = new DBMain();
        }

        public DataSet getTransaction_details()
        {
            string sqlString = "select * from Customer, Product, Transaction_Details, Transactions where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_product = Product.ID_product";
            return db.ExcuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool addTransaction_details(string quantity, string idtransaction, string idproduct)
        {
            string sqlString = "Insert Into Transaction_Details Values(" + quantity + "," + idtransaction + "," + idproduct + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool deleteTransaction_details(string idtransaction)
        {
            string sqlString = "Delete From Transaction_Details where ID_transaction = " + idtransaction;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet search_byCusname(string cusname)
        {
            string sqltring = "select * from Customer, Product, Transaction_Details, Transactions where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_product = Product.ID_product and Customer.Customer_Name like '" + cusname + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }
        public DataSet search_byProduct(string productname)
        {
            string sqltring = "select * from Customer, Product, Transaction_Details, Transactions where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_product = Product.ID_product and Product.Name_product like '" + productname + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }

        public DataSet search_byDate(string date)
        {
            string sqltring = "select * from Customer, Product, Transaction_Details, Transactions where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_Product = Product.ID_Product and Transactions.Date = '" + date + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }

        public DataSet search_byProductnum(string Phonenum)
        {
            string sqltring = "select * from Customer, Product, Transaction_Details, Transactions where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_Product = Product.ID_Product and Customer.PhoneNumber like '" + Phonenum + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }
        public DataSet search_byTrans_ID(int ID)
        {
            string sqltring = "select Customer_Name,Name_product,Price,quantity,Total_price,Dates,username from Customer, Product, Transaction_Details, Transactions where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_product = Product.ID_product and Transaction_Details.ID_transaction = " + ID;
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }
    }
}
