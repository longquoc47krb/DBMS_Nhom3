/*Tạo view thống kê doanh thu trong tháng*/
drop view month_Revenue
create view month_Revenue
as
select Staff.username,Name_Staff,Posision,SUM(Total_price) as Total
from Transactions,Staff
where Transactions.username = Staff.username and MONTH(Dates) = MONTH(GETDATE())
group by Staff.username, Name_Staff,Posision

/*Tạo view bảo hành*/
drop view view_warranty
create view view_warranty
as
select PhoneNumber,Customer.Customer_Name,Product.ID_product,Product.Name_product
from Customer,Transactions,Transaction_Details,Product
where Customer.ID_customer = Transactions.ID_customer and Transaction_Details.ID_transaction = Transactions.ID_transaction 
and Transaction_Details.ID_product = Product.ID_product and DATEDIFF(MONTH,Transactions.Dates,GETDATE()) < Product.warranty_month


