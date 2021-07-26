--Kiểm tra xem mã nhân viên tồn tại
--Nhập vào mã nhân viên cần kiểm tra trên server hiện tại và server phân mảnh cùng cấp, nếu đã tồn tại thì return 1, nếu không thì return 0
CREATE PROC SP_KIEMTRAMAGDVTONTAI
@MAGDV NCHAR(9)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM DBO.GIAODICHVIEN WHERE DBO.GIAODICHVIEN.MAGDV=@MAGDV)
	BEGIN
		RETURN 1--- TON TAI O SERVER HIEN TAI
	END


	IF EXISTS(SELECT 1 FROM LINK.QL_TAIKHOAN.DBO.GIAODICHVIEN GDV WHERE GDV.MAGDV=@MAGDV)
	BEGIN
		RETURN 1 ----SERVER CON LAI
	END

	RETURN 0 --- KHONG TON TAI
END

--Kiểm tra xem khách hàng tồn tại bằng số CMND
--Nhập số cmnd của khách cần kiểm tra trên server hiện tại và server phân mảnh cùng cấp, nếu đã tồn tại thì return 1, nếu không thì return 0

CREATE PROC SP_KIEMTRAKHACHHANGTONTAI
@CMND NCHAR(9)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM DBO.KHACHHANG WHERE DBO.KHACHHANG.CMND = @CMND)
	BEGIN
		RETURN 1
	END

	IF EXISTS (SELECT 1 FROM LINK.QL_TAIKHOAN.DBO.KHACHHANG KH WHERE KH.CMND = @CMND)
	BEGIN
		RETURN 1
	END
	RETURN 0
END


--Kiểm tra tài khoản tồn tại
-- Nhập vào tài khoản đăng nhập cần kiểm tra trên server hiện tại và server phân mảnh cùng cấp, nếu đã tồn tại thì return 1, nếu không thì return 0
CREATE PROC SP_KIEMTRATAIKHOANTONTAI
@TAIKHOAN CHAR(100)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM DBO.ACCOUNT A WHERE A.TAIKHOAN=@TAIKHOAN)
	BEGIN
		RETURN 1
	END

	IF EXISTS (SELECT 1 FROM LINK.QL_TAIKHOAN.DBO.ACCOUNT A WHERE A.TAIKHOAN=@TAIKHOAN)
	BEGIN
		RETURN 1
	END
	RETURN 0
END

--Kiểm tra tài khoản có phải ADMIN hay không?
-- Nhập tài khoản mật khẩu cần kiểm tra, nếu tài khoản này là quyền admin thì có thể đăng nhập bất cứ chi nhánh nào với quyền admin, nếu có return 1, ngược lại return 0

CREATE PROC SP_CHECKISADMIN
@TAIKHOAN  CHAR(100), @MATKHAU CHAR(100)
AS
BEGIN

	IF EXISTS(SELECT A.QUYEN FROM DBO.ACCOUNT A WHERE A.TAIKHOAN=@TAIKHOAN AND A.[MATKHAU] = @MATKHAU AND A.QUYEN=0)
	BEGIN
		RETURN 1
	END

	IF EXISTS (SELECT A.QUYEN FROM LINK.QL_TAIKHOAN.DBO.ACCOUNT A WHERE A.TAIKHOAN=@TAIKHOAN AND A.[MATKHAU] = @MATKHAU AND A.QUYEN=0)
	BEGIN
		RETURN 1
	END
	RETURN 0
END
--Kiểm tra tài khoản đăng nhập
-- Nhập tài khoản mật khẩu cần kiểm tra, xem ở chi nhánh cần kiểm tra có tồn tại tài khoản này hay không? nếu có return 1, ngược lại return 0
CREATE PROC SP_LOGINVERIFY
@TAIKHOAN  CHAR(100), @MATKHAU CHAR(100)
AS
BEGIN
	SELECT * FROM DBO.ACCOUNT A WHERE A.TAIKHOAN = @TAIKHOAN AND A.MATKHAU = @MATKHAU
END
GO

--Thêm khách hàng vào hệ thống
-- Nhập thông tin khách hàng và thêm khách hàng vào hệ thống
CREATE PROC SP_ADDNEWCUSTOMER
@HOTEN NVARCHAR(50), @DIACHI NVARCHAR(100), @CMND NCHAR(9) , @NGAYCAP DATE , @MACN NCHAR(5)
AS
BEGIN
	SET DATEFORMAT DMY
	INSERT INTO [dbo].[KHACHHANG] ([HOTEN],[DIACHI],[CMND],[NGAYCAP],[MACN],[rowguid]) VALUES( @HOTEN, @DIACHI, @CMND, @NGAYCAP,@MACN, NEWID())
END

go

-- Cập nhật thông tin khách hàng
-- Cập nhật thông tin khách hàng thông qua số CMND của khách hàng
CREATE PROC SP_UPDATECUSTOMER
@HOTEN NVARCHAR(50), @DIACHI NVARCHAR(100), @CMND NCHAR(9) , @NGAYCAP DATE
AS
BEGIN
	SET DATEFORMAT DMY
	UPDATE  [dbo].[KHACHHANG] SET [HOTEN] = @HOTEN, [DIACHI] = @DIACHI, [NGAYCAP] =@NGAYCAP WHERE [CMND]=@CMND
END


--Thêm nhân viên mới
-- Thêm nhân viên mới với thông tin Họ tên, địa chỉ, mã cn
CREATE PROC SP_ADDNEWSTAFF
@HOTEN NVARCHAR(50), @DIACHI NVARCHAR(100), @MACN NCHAR(9)
AS
BEGIN
	INSERT INTO [dbo].[GIAODICHVIEN] ([HOTEN] ,[DIACHI],[MACN],[rowguid]) VALUES (@HOTEN, @DIACHI, @MACN, NEWID())
END

--Thêm phiếu gửi
--Thêm phiếu gửi thông qua thông tin CMND, Mã dịch vụ, ngày gửi, lãi suất, kỳ hạn gửi, số tiền gửi, ngày đến hạn, mã GDV lập phiếu gửi
CREATE PROC SP_ADDPHIEUGUI
@CMND NCHAR(9), @MADV NCHAR(5), @NGAYGUI DATETIME, @LAISUAT REAL, @KYHAN INT, @SOTIEN_GUI MONEY, @NGAYDENHAN DATETIME, @MAGDV_LPG INT
AS
BEGIN	
	SET DATEFORMAT DMY
	
	INSERT INTO [dbo].[PHIEUGUI]
           ([CMND]
           ,[MADV]
           ,[NGAYGUI]
           ,[LAISUAT]
		   ,[KYHAN]
           ,[SOTIEN_GUI]
           ,[NGAYDENHAN]
           ,[MAGDV_LPG]
           ,[rowguid])
     VALUES
           (@CMND
           ,@MADV
           ,@NGAYGUI
           ,@LAISUAT
		   ,@KYHAN
           ,@SOTIEN_GUI
           ,@NGAYDENHAN
           ,@MAGDV_LPG
           ,NEWID())
END


