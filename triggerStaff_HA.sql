
/*Thêm trigger thông báo thêm staff thành công*/
drop trigger tg_addStaff;
create trigger tg_addStaff on Staff
instead of insert
as
begin
	declare @username nvarchar(50), @password nvarchar(50), @Name_staff nvarchar(50), @Phone nvarchar(50), @address nvarchar(50),@position nvarchar(50),@gender nvarchar(50)
	select @username = username, @password = password, @Name_staff = Name_Staff,@Phone = Phone, @Address = Address,@position= Posision, @Gender = Gender
	from inserted
	if (@username = '' or @password = '' or @Name_staff = '' or @Phone = '' or @Address = '' or @position= '' or @Gender = '')
		begin
			PRINT N'Vui lòng nhập đầy đủ thông tin'	
		end
	else
		begin
			insert into Staff(username,password,Name_Staff,Phone,Address,Posision,Gender)
			values (@username,@password,@Name_staff,@Phone,@address,@position,@gender)
			PRINT N'Thêm thành công'
		end
end


/*Thêm trigger thông báo cập nhật thành công*/
drop trigger tg_updateStaff 
create trigger tg_updateStaff  on Staff
instead of update
as
begin
	declare @old_password nvarchar(50),@new_password nvarchar(50),@username nvarchar(50)
	select @old_password = ol.password,@new_password = ne.password,@username = ol.username
	from inserted ne,deleted ol
	where ne.username = ol.username
	if(@old_password = @new_password)
	begin
		print N'Mật khẩu giống mật khẩu cũ'
	end
	else
	begin
		Update Staff
		Set password = @new_password
		where username = @username
		PRINT N'Cập nhật thành công'
	end
end



/*Thêm trigger thông báo xóa thành công staff*/
drop trigger tg_deleteStaff 
create trigger tg_deleteStaff  on Staff
after delete
as
begin
	print N'Xóa thành công'
end

/*Tạo view*/
drop view view_staff
create view view_staff as
select * from staff