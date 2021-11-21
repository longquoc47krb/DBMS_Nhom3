/*Func tìm MaxID CongTySX*/
create function IDmaxCompany()
RETURNS int 
as
begin
	declare @maxid int
	select @maxid = max(ID_company)
	from CongTySX
	if(@maxid IS NULL)
		set @maxid = -1;
	return @maxid
end

/*Trigger thêm company*/
create trigger trig_addCompany on CongTySX
instead of insert
as
begin
	declare @name nvarchar(50), @id int, @address nvarchar(50)
	select @name = Company_name, @id = dbo.IDmaxCompany()+1, @address = address
	from inserted
	begin try
		insert into CongTySX(Company_name,ID_company,address)
		values (@name,@id,@address)
		PRINT N'Thêm thành công'
	end try
	begin catch
		PRINT N'Yêu cầu thất bại'	
	end catch	
end