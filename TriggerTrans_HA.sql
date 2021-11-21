/*Tạo view chi tiết transaction details*/
drop view viewTrans_details
create view viewTrans_details
as
select Transactions.ID_transaction,Customer_Name,PhoneNumber,VIP,Product.ID_product,Name_product,Price,quantity,warranty_month,Dates,username as seller
from Customer, Product, Transaction_Details, Transactions 
where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_product = Product.ID_product

/*Tạo funtion return maxid transaction*/
drop function IDmaxTrans
create function IDmaxTrans()
RETURNS int 
as
begin
	declare @maxid int
	select @maxid = max(ID_transaction)
	from Transactions
	if(@maxid IS NULL)
		set @maxid = -1;
	return @maxid
end

/*Tạo trigger thêm transaction*/
drop trigger Trig_addTrans
create trigger Trig_addTrans on Transactions
instead of insert
as
begin
	declare @idtrans int,@total int,@date date,@idcus int,@seller nvarchar(50)
	select @idtrans = ID_transaction,@total =Total_price,@date =Dates,@idcus=ID_customer,@seller = username
	from inserted
	if(@total > 0)
	begin
		begin try
			insert into Transactions(ID_transaction,Total_price,Dates,ID_customer,username)
			values (@idtrans,@total,@date,@idcus,@seller)
			begin
			/*cập nhật lại trên bảng customer*/
				declare @VIP int
				if(dbo.Sum_TotalBuy(@idcus) > 100000000)
				begin
					set @VIP = 1
					print N'Khách hàng VIP'
				end
				else
				begin
					set @VIP = 0
				end
				update Customer
				set VIP = @VIP
				where ID_customer = @idcus
			end
			PRINT N'Thực thi thành công'
		end try
		begin catch
			PRINT N'Yêu cầu thất bại'	
		end catch	
	end
	else
		PRINT N'Không có sản phẩm nào trong giỏ hàng'
end

