﻿using DBMS_Nhom3.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBMS_Nhom3.BSLayer
{
    class BLCustomers
    {
        DBMain db = null;
        string err;
        public BLCustomers()
        {
            db = new DBMain();
        }
        public DataSet GetCustomers()
        {
            return db.ExcuteQueryDataSet("select * from Customer", CommandType.Text);
        }

        public DataSet FindCustomer(string name, string phone)
        {
            return db.ExcuteQueryDataSet("select * from Customer where Customer_Name= '" + name + "' and PhoneNumber = '" + phone + "'", CommandType.Text);
        }

        public DataSet FindCustomer_SDT(string phone)
        {
            return db.ExcuteQueryDataSet("select * from Customer where PhoneNumber like '" + phone + "%'", CommandType.Text);
        }

        public int returnMaxID()
        {
            string sqlString = "select max(ID_customer) as max_id from Customer";
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
        public int isVip(string phonenumber)
        {
            string sqlString = "select VIP from Customer where PhoneNumber = '" + phonenumber + "'";
            DataSet ds = db.ExcuteQueryDataSet(sqlString, CommandType.Text);
            try
            {
                if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                    return -1;
                else
                    return int.Parse(ds.Tables[0].Rows[0]["VIP"].ToString());


            }
            catch (Exception error)
            {
                return -1;
            }
        }

        // them phone
        public bool addCustomer(string cusname, string phonenumber)
        {
            string sqlString = "insert into Customer(Customer_Name,PhoneNumber,ID_customer) Values('" + cusname + "','" + phonenumber + "',dbo.IDmaxCustomer()+1)";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //xoa phone
        public bool deleteCustomer(ref string err, int ID_customer)
        {
            string sqlString = "Delete From Customer where ID_customer = " + ID_customer.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        // cap nhat phone
        public bool updateCustomer(string cusname, string phonenumber, string idcus, ref string err)
        {
            string sqlString = "Update Customer Set Customer_Name = '" + cusname + "',PhoneNumber = '" + phonenumber + "',' where ID_customer = " + idcus.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
