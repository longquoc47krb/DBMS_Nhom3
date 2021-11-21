USE ShopDB
EXEC sp_addrolemember 'db_datareader', 'user1'

USE ShopDB
EXEC sp_addrolemember 'db_datareader', 'admin'

GRANT select,delete,insert,update,REFERENCES,ALTER ON dbo.CongTySX TO admin
GRANT select,delete,insert,update,REFERENCES,ALTER ON dbo.Customer TO admin
GRANT select,delete,insert,update,REFERENCES,ALTER ON dbo.Staff TO admin
GRANT select,delete,insert,update,REFERENCES,ALTER ON dbo.Product TO admin
GRANT select,delete,insert,update,REFERENCES,ALTER ON dbo.Transactions TO admin
GRANT select,delete,insert,update,REFERENCES,ALTER ON dbo.Transaction_Details TO admin



GRANT select,delete,insert,update ON dbo.CongTySX TO user1
GRANT select,delete,insert,update ON dbo.Customer TO user1
GRANT select,delete,insert,update ON dbo.Product TO user1
GRANT select,delete,insert,update ON dbo.Transactions TO user1
GRANT select,delete,insert,update ON dbo.Transaction_Details TO user1



