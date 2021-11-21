/*Thêm user vào database*/
USE ShopDB
EXEC sp_addrolemember 'db_datareader', 'user1'

USE ShopDB
EXEC sp_addrolemember 'db_datareader', 'admin'

/*Thêm phân quyền user, admin thì có tất cả bảng trên database*/
GRANT select,delete,insert,update,REFERENCES,ALTER ON dbo.CongTySX TO admin
GRANT select,delete,insert,update,REFERENCES,ALTER ON dbo.Customer TO admin
GRANT select,delete,insert,update,REFERENCES,ALTER ON dbo.Staff TO admin
GRANT select,delete,insert,update,REFERENCES,ALTER ON dbo.Product TO admin
GRANT select,delete,insert,update,REFERENCES,ALTER ON dbo.Transactions TO admin
GRANT select,delete,insert,update,REFERENCES,ALTER ON dbo.Transaction_Details TO admin


/*Thêm phân quyền user, user1 thì chỉ có quyền trên tất cả bảng trừ bảng Staff bảng trên database*/
GRANT select,delete,insert,update ON dbo.CongTySX TO user1
GRANT select,delete,insert,update ON dbo.Customer TO user1
GRANT select,delete,insert,update ON dbo.Product TO user1
GRANT select,delete,insert,update ON dbo.Transactions TO user1
GRANT select,delete,insert,update ON dbo.Transaction_Details TO user1
GRANT select ON dbo.Staff TO user1






