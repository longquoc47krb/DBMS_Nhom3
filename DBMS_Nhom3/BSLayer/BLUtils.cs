using DBMS_Nhom3.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBMS_Nhom3.BSLayer
{
    class BLUtils
    {
        DBMain db = null;
        public BLUtils()
        {
            db = new DBMain();
        }
        public DataSet GetRevenueView()
        {
            return db.ExcuteQueryDataSet("select * from month_Revenue order by Total DESC", CommandType.Text);
        }
        public DataSet GetWarrantyView()
        {
            return db.ExcuteQueryDataSet("select * from view_warranty", CommandType.Text);
        }
        public DataSet searchWarranty_byPhone(string phone)
        {
            string sqltring = "select * from view_warranty where PhoneNumber like '" + phone + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }
    }
}
