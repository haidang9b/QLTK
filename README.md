# Quản lý tài khoản và phân tán cơ sở dữ liệu
Ứng dụng Desktop Quản lý tài khoản với hệ cơ sở dữ liệu phân tán SQL được viết bằng C#

Giả sử 1 ngân hàng có 2 chi nhánh 1 và 2
Phân tán cơ sở dữ liệu QLTK làm 2 điều kiện sau:
 - QLTK1 đặt trên server 1: chứa thông tin của chi nhánh 1
 - QLTK1 đặt trên server 2: chứa thông tin của chi nhánh 2 
 
Phân quyền:
 - Admin : có thể đăng nhập bất cứ chi nhánh nào 
 - CN_X: thì đăng nhạp và làm việc trên chi nhánh đó, nếu chọn sai CN sẽ không đăng nhập được.
 - User (nhân viên): chỉ cho phép cập nhật dữ diệu, không được tạo tài khoản trên chi nhánh đang làm việc nếu chọn sai CN sẽ không đăng nhập được.

Các chức năng chính :
 - Danh sách khách hàng.
 - Lập phiếu gửi tiền.
 - Lập phiếu rút tiền.
 - Lập báo cáo.
