namespace DataAccessLayer.Entity.Base
{
    public class EnumBase
    {
        public enum PaymentMethod
        {
            None,
            ChuyenKhoanNganHang, // Chuyển khoản ngân hàng
            TienMatKhiGiaoHang,  // Tiền mặt khi giao hàng
        }
        public enum ShippingMethod
        {
            None,
            GiaoHangTieuChuan,   // Giao hàng tiêu chuẩn
            GiaoHangNhanh,       // Giao hàng nhanh
            GiaoHangTrongNgay,   // Giao hàng trong ngày
            NhanTaiCuaHang,      // Nhận tại cửa hàng
            GiaoHangQuocTe       // Giao hàng quốc tế
        }
        public enum PaymentStatus
        {
            None,
            Unknown,   // Chưa thanh toán
            Success,     // Đã thanh toán
            Pending,        // Đang xử lý
            Failure,    // Lỗi thanh toán
        }
        public enum OrderStatus
        {
            None,
            Pending,        //Chưa giải quyết
            Processing,     //Xử lý
            Shipped,        //Đã vận chuyển
            Delivered,      //Đã giao hàng <=> success
            Cancelled,      //Đã hủy
            Returned,       //Trả lại
        }

    }
}
