﻿/*Func tìm MaxID product*/
create function IDmaxProduct()
RETURNS int 
as
begin
	declare @maxid int
	select @maxid = max(ID_product)
	from Product
	if(@maxid IS NULL)
		set @maxid = -1;
	return @maxid
end

/*Trigger thêm product*/
create trigger trig_addProduct on Product
instead of insert
as
begin
	declare @name nvarchar(50), @id int, @price int, @idcom int,@warranty_month int
	select @name = Name_product, @id = dbo.IDmaxProduct()+1, @price = Price, @idcom = ID_company, @warranty_month = warranty_month
	from inserted
	begin try
		insert into Product(Name_product,ID_product,Price,ID_company,warranty_month)
		values (@name,@id,@price,@idcom,@warranty_month)
		PRINT N'Thêm thành công'
	end try
	begin catch
		PRINT N'Yêu cầu thất bại'	
	end catch	
end


/*Trigger update product*/
create trigger trig_updateProduct on Product
instead of update
as
begin
	declare @name nvarchar(50), @id int, @price int, @idcom int,@warranty_month int
	select @name = ne.Name_product, @id = ol.ID_product, @price = ne.Price, @idcom = ne.ID_company, @warranty_month = ne.warranty_month
	from inserted ne,deleted ol
	Update Product
	Set Name_product = @name,Price = @price,ID_company=@idcom,warranty_month = @warranty_month
	where Name_product = @name
	PRINT N'Cập nhật thành công'
end

/*Trigger xóa product*/
create trigger tg_deleteProduct  on Product
after delete
as
begin
	print N'Xóa thành công'
end

/*Tạo view*/
create view view_product
as select * from Product

