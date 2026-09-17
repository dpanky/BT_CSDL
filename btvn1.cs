using System;
using System.Globalization;
using System.Text;

// Enum định nghĩa các loại ngoại tệ cho Bài 3
enum CurrencyType
{
    USD = 1,
    EUR = 2,
    JPY = 3,
    GBP = 4
}

internal class BTVN1
{
    private static void Main(string[] args)
    {
        // Thiết lập bảng mã UTF-8 để hiển thị tiếng Việt không bị lỗi font
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // ==================== BÀI 1 ====================
        Console.WriteLine("=== BÀI 1: TÍNH TIỀN ĐIỆN SINH HOẠT BẬC THANG (EVN) ===");
        Console.Write("Nhập chỉ số điện cũ (kWh): ");
        int chiSoCu = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhập chỉ số điện mới (kWh): ");
        int chiSoMoi = int.Parse(Console.ReadLine() ?? "0");

        if (chiSoMoi < chiSoCu)
        {
            Console.WriteLine("Lỗi: Chỉ số điện mới phải lớn hơn hoặc bằng chỉ số cũ!");
            return;
        }

        int soKwh = chiSoMoi - chiSoCu;
        decimal tienChuaThue = 0;

        if (soKwh <= 50)
        {
            // Bậc 1: 0 - 50 kWh (1.806 VNĐ/kWh)
            tienChuaThue = soKwh * 1806m;
        }
        else if (soKwh <= 100)
        {
            // Bậc 2: 51 - 100 kWh (1.866 VNĐ/kWh)
            tienChuaThue = (50 * 1806m) + ((soKwh - 50) * 1866m);
        }
        else if (soKwh <= 200)
        {
            // Bậc 3: 101 - 200 kWh (2.167 VNĐ/kWh)
            tienChuaThue = (50 * 1806m) + (50 * 1866m) + ((soKwh - 100) * 2167m);
        }
        else if (soKwh <= 300)
        {
            // Bậc 4: 201 - 300 kWh (2.729 VNĐ/kWh)
            tienChuaThue = (50 * 1806m) + (50 * 1866m) + (100 * 2167m) + ((soKwh - 200) * 2729m);
        }
        else
        {
            // Bậc 5: Từ 301 kWh trở lên (3.050 VNĐ/kWh)
            tienChuaThue = (50 * 1806m) + (50 * 1866m) + (100 * 2167m) + (100 * 2729m) + ((soKwh - 300) * 3050m);
        }

        // Cộng thêm 8% thuế VAT
        decimal thueVAT = tienChuaThue * 0.08m;
        decimal tongThanhToan = tienChuaThue + thueVAT;

        // In kết quả hóa đơn
        Console.WriteLine("\n--- HÓA ĐƠN TIỀN ĐIỆN CHI TIẾT ---");
        Console.WriteLine($"Số điện tiêu thụ    : {soKwh} kWh");
        Console.WriteLine($"Tiền điện chưa thuế : {tienChuaThue:#,##0} VNĐ");
        Console.WriteLine($"Thuế VAT (8%)       : {thueVAT:#,##0} VNĐ");
        Console.WriteLine($"Tổng thanh toán     : {tongThanhToan:#,##0} VNĐ");


        // ==================== BÀI 2 ====================
        Console.WriteLine("\n=======================================================");
        Console.WriteLine("=== BÀI 2: HỆ THỐNG THEO DÕI CHỈ SỐ BMI & SỨC KHỎE ===");
        
        Console.Write("Chiều cao (m): ");
        string rawHeight = (Console.ReadLine() ?? "0").Replace(',', '.');
        double chieuCao = double.Parse(rawHeight, CultureInfo.InvariantCulture);

        Console.Write("Cân nặng (kg): ");
        string rawWeight = (Console.ReadLine() ?? "0").Replace(',', '.');
        double canNang = double.Parse(rawWeight, CultureInfo.InvariantCulture);

        // Kiểm tra điều kiện
        if (chieuCao <= 0 || canNang <= 0)
        {
            Console.WriteLine("Lỗi: Chiều cao và cân nặng phải lớn hơn 0!");
            return;
        }

        // Chỉ số BMI
        double bmi = canNang / Math.Pow(chieuCao, 2);

        // Phân loại sức khỏe theo chuẩn WHO châu Á
        string phanLoai = "";
        if (bmi < 18.5)
        {
            phanLoai = "Gầy (Thiếu cân)";
        }
        else if (bmi < 23.0)
        {
            phanLoai = "Bình thường (Lý tưởng)";
        }
        else if (bmi < 25.0)
        {
            phanLoai = "Thừa cân (Tiền béo phì)";
        }
        else
        {
            phanLoai = "Béo phì";
        }

        // Dải cân nặng lý tưởng
        double canNangMin = 18.5 * Math.Pow(chieuCao, 2);
        double canNangMax = 22.9 * Math.Pow(chieuCao, 2);

        // Kết quả
        Console.WriteLine("\n--- KẾT QUẢ ĐÁNH GIÁ SỨC KHỎE ---");
        Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2}");
        Console.WriteLine($"Phân loại sức khỏe: {phanLoai}");
        Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {canNangMin:F2} kg đến {canNangMax:F2} kg.");


        // ==================== BÀI 3 ====================
        Console.WriteLine("\n=======================================================");
        Console.WriteLine("=== BÀI 3: QUY ĐỔI TIỀN TỆ NGOẠI TỆ ĐA TỶ GIÁ ===");

        Console.Write("Nhập số tiền VNĐ: ");
        decimal soTienVND = decimal.Parse(Console.ReadLine() ?? "0");

        if (soTienVND <= 0)
        {
            Console.WriteLine("Lỗi: Số tiền VNĐ cần đổi phải lớn hơn 0!");
            return;
        }

        Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
        int chon = int.Parse(Console.ReadLine() ?? "1");
        CurrencyType loaiTien = (CurrencyType)chon;

        // Phí dịch vụ (0.5%) và tiền tính đổi
        decimal phiDichVu = soTienVND * 0.005m;
        decimal tienTinhDoi = soTienVND - phiDichVu;

        // Tỷ giá
        decimal tyGia = 0;
        string tenNgoaiTe = "";

        switch (loaiTien)
        {
            case CurrencyType.USD:
                tyGia = 25400m;
                tenNgoaiTe = "USD";
                break;
            case CurrencyType.EUR:
                tyGia = 27200m;
                tenNgoaiTe = "EUR";
                break;
            case CurrencyType.JPY:
                tyGia = 165m;
                tenNgoaiTe = "JPY";
                break;
            case CurrencyType.GBP:
                tyGia = 32100m;
                tenNgoaiTe = "GBP";
                break;
            default:
                Console.WriteLine("Lựa chọn loại ngoại tệ không hợp lệ!");
                return;
        }

        decimal tienNgoaiTe = tienTinhDoi / tyGia;

        // Kết quả quy đổi
        Console.WriteLine("\n--- KẾT QUẢ QUY ĐỔI ---");
        Console.WriteLine($"Phí dịch vụ (0.5%)   : {phiDichVu:#,##0} VNĐ");
        Console.WriteLine($"Số tiền VNĐ tính đổi : {tienTinhDoi:#,##0} VNĐ");
        Console.WriteLine($"Số tiền {tenNgoaiTe} nhận được: {tienNgoaiTe:F2} {tenNgoaiTe}");


        // ==================== BÀI 4 ====================
        Console.WriteLine("\n=======================================================");
        Console.WriteLine("=== BÀI 4: TÍNH TUỔI VÀ ĐẾM NGƯỢC NGÀY SINH NHẬT ===");
        
        Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
        DateTime ngaySinh = DateTime.ParseExact(Console.ReadLine() ?? "01/01/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture);
        
        DateTime homNay = DateTime.Today;

        // Tính tuổi
        int tuoi = homNay.Year - ngaySinh.Year;
        DateTime sinhNhatNamNay = new DateTime(homNay.Year, ngaySinh.Month, ngaySinh.Day);
        if (homNay < sinhNhatNamNay)
        {
            tuoi = tuoi - 1;
        }

        // Tổng số ngày đã sống
        TimeSpan daSong = homNay - ngaySinh;
        int tongNgaySong = (int)daSong.TotalDays;

        // Số ngày còn lại đến sinh nhật kế tiếp
        DateTime sinhNhatTiepTheo;
        if (homNay <= sinhNhatNamNay)
        {
            sinhNhatTiepTheo = sinhNhatNamNay;
        }
        else
        {
            sinhNhatTiepTheo = new DateTime(homNay.Year + 1, ngaySinh.Month, ngaySinh.Day);
        }

        int ngayConLai = (sinhNhatTiepTheo - homNay).Days;

        // Kết quả
        Console.WriteLine("\n--- OUTPUT ---");
        Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
        Console.WriteLine($"Bạn đã sống tổng cộng: {tongNgaySong:#,##0} ngày");
        Console.WriteLine($"Sinh nhật tiếp theo còn: {ngayConLai} ngày nữa");


        // ==================== BÀI 5 ====================
        Console.WriteLine("\n=======================================================");
        Console.WriteLine("=== BÀI 5: TÍNH ĐIỂM TRUNG BÌNH & QUY ĐỔI GPA ===");

        Console.Write("Nhập điểm C#: ");
        double diemC = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Số tín chỉ C#: ");
        int tcC = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhập điểm Toán: ");
        double diemToan = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Số tín chỉ Toán: ");
        int tcToan = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhập điểm Tiếng Anh: ");
        double diemAnh = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Số tín chỉ Tiếng Anh: ");
        int tcAnh = int.Parse(Console.ReadLine() ?? "0");

        // Điểm trung bình theo trọng số tín chỉ
        int tongTC = tcC + tcToan + tcAnh;
        double dtb = (diemC * tcC + diemToan * tcToan + diemAnh * tcAnh) / tongTC;

        // Quy đổi thang điểm bằng if - else if đơn giản
        string diemChu = "";
        double gpa4 = 0.0;
        string xepLoai = "";

        if (dtb >= 8.5)
        {
            diemChu = "A";
            gpa4 = 4.0;
            xepLoai = "Xuất sắc / Giỏi";
        }
        else if (dtb >= 7.0)
        {
            diemChu = "B";
            gpa4 = 3.0;
            xepLoai = "Khá";
        }
        else if (dtb >= 5.5)
        {
            diemChu = "C";
            gpa4 = 2.0;
            xepLoai = "Trung bình";
        }
        else if (dtb >= 4.0)
        {
            diemChu = "D";
            gpa4 = 1.0;
            xepLoai = "Yếu";
        }
        else
        {
            diemChu = "F";
            gpa4 = 0.0;
            xepLoai = "Kém (Trượt)";
        }

        // In kết quả
        Console.WriteLine("\n--- BẢNG ĐIỂM QUY ĐỔI ---");
        Console.WriteLine($"Điểm TB Thang 10: {dtb:F2}");
        Console.WriteLine($"Điểm Chữ Quy Đổi: {diemChu}");
        Console.WriteLine($"Điểm GPA Thang 4: {gpa4:F1}");
        Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");


        // ==================== BÀI 6 ====================
        Console.WriteLine("\n=======================================================");
        Console.WriteLine("=== BÀI 6: CHUẨN HÓA HỌ TÊN & TẠO EMAIL ===");

        Console.Write("Nhập họ tên thô: ");
        string hoTen = Console.ReadLine() ?? "";

        // Xóa khoảng trắng thừa
        hoTen = hoTen.Trim();
        while (hoTen.Contains("  "))
        {
            hoTen = hoTen.Replace("  ", " ");
        }

        // Cắt từ và viết hoa chữ đầu
        string[] tu = hoTen.Split(' ');
        string hoTenChuan = "";
        for (int i = 0; i < tu.Length; i++)
        {
            string t = tu[i].ToLower();
            tu[i] = char.ToUpper(t[0]) + t.Substring(1);
            hoTenChuan += tu[i] + " ";
        }
        hoTenChuan = hoTenChuan.Trim();

        // Tách Họ, Tên Đệm và Tên
        string ho = tu[0];
        string ten = tu[tu.Length - 1];
        string tenDem = "";
        for (int i = 1; i < tu.Length - 1; i++)
        {
            tenDem += tu[i] + " ";
        }
        tenDem = tenDem.Trim();

        // Tạo username và email
        string hoVaDemLien = "";
        for (int i = 0; i < tu.Length - 1; i++)
        {
            hoVaDemLien += tu[i].ToLower();
        }
        string username = ten.ToLower() + "." + hoVaDemLien;
        string email = username + "@company.edu.vn";

        Console.WriteLine("\n--- OUTPUT ---");
        Console.WriteLine($"Họ tên chuẩn hóa: {hoTenChuan}");
        Console.WriteLine($"Họ: {ho} | Tên đệm: {tenDem} | Tên: {ten}");
        Console.WriteLine($"Username tạo tự động: {username}");
        Console.WriteLine($"Email cấp phát: {email}");


        // ==================== BÀI 7 ====================
        Console.WriteLine("\n=======================================================");
        Console.WriteLine("=== BÀI 7: TÍNH CHI PHÍ NHIÊN LIỆU (CAR-POOLING) ===");

        Console.Write("Quãng đường (km): ");
        double quangDuong = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Mức tiêu hao (L/100km): ");
        double mucTieuHao = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Giá xăng (VNĐ/Lít): ");
        decimal giaXang = decimal.Parse(Console.ReadLine() ?? "0");

        Console.Write("Số người đi: ");
        int soNguoi = int.Parse(Console.ReadLine() ?? "1");

        // Tính tổng lít xăng và tổng tiền
        double tongLit = (quangDuong / 100.0) * mucTieuHao;
        decimal tongTien = (decimal)tongLit * giaXang;

        // Tiền mỗi người (làm tròn lên hàng nghìn)
        decimal tienMoiNguoi = Math.Ceiling(tongTien / soNguoi / 1000m) * 1000m;

        Console.WriteLine("\n--- OUTPUT ---");
        Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {tongLit:F2} Lít");
        Console.WriteLine($"Tổng chi phí xăng dầu: {tongTien:#,##0} VNĐ");
        Console.WriteLine($"Chi phí mỗi người: {tienMoiNguoi:#,##0} VNĐ");


        // ==================== BÀI 8 ====================
        Console.WriteLine("\n=======================================================");
        Console.WriteLine("=== BÀI 8: KIỂM TRA MÃ XÁC THỰC OTP ===");

        string otpDung = "839201";

        Console.Write("Mã OTP nhận được: ");
        string otpNhap = Console.ReadLine() ?? "";

        Console.Write("Nhập số phút đã trôi qua: ");
        int phut = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhập số giây đã trôi qua: ");
        int giay = int.Parse(Console.ReadLine() ?? "0");

        int tongGiay = phut * 60 + giay;

        Console.WriteLine("\n--- OUTPUT ---");
        if (otpNhap.Length != 6)
        {
            Console.WriteLine("Trạng thái xác thực: THẤT BẠI - Mã OTP phải có đúng 6 ký tự!");
        }
        else if (otpNhap != otpDung)
        {
            Console.WriteLine("Trạng thái xác thực: THẤT BẠI - Mã OTP không chính xác!");
        }
        else if (tongGiay > 300)
        {
            Console.WriteLine("Trạng thái xác thực: THẤT BẠI - Mã OTP đã hết hạn (quá 5 phút)!");
        }
        else
        {
            Console.WriteLine("Trạng thái xác thực: THÀNH CÔNG - Giao dịch đã được phê duyệt.");
        }


        // ==================== BÀI 9 ====================
        Console.WriteLine("\n=======================================================");
        Console.WriteLine("=== BÀI 9: TÍNH LƯƠNG GROSS - NET & THUẾ TNCN ===");

        Console.Write("Lương Gross (VNĐ): ");
        decimal gross = decimal.Parse(Console.ReadLine() ?? "0");

        Console.Write("Số người phụ thuộc: ");
        int soNguoiPhuThuoc = int.Parse(Console.ReadLine() ?? "0");

        // Bảo hiểm 10.5%
        decimal baoHiem = gross * 0.105m;

        // Giảm trừ và thu nhập chịu thuế
        decimal giamTruBanThan = 11000000m;
        decimal giamTruPhuThuoc = soNguoiPhuThuoc * 4400000m;
        decimal thuNhapChiuThue = gross - baoHiem - giamTruBanThan - giamTruPhuThuoc;

        if (thuNhapChiuThue < 0)
        {
            thuNhapChiuThue = 0;
        }

        // Tính thuế TNCN theo bậc lũy tiến
        decimal thueTNCN = 0;

        if (thuNhapChiuThue <= 5000000m)
        {
            thueTNCN = thuNhapChiuThue * 0.05m;
        }
        else if (thuNhapChiuThue <= 10000000m)
        {
            thueTNCN = (5000000m * 0.05m) 
                     + ((thuNhapChiuThue - 5000000m) * 0.10m);
        }
        else if (thuNhapChiuThue <= 18000000m)
        {
            thueTNCN = (5000000m * 0.05m) 
                     + (5000000m * 0.10m) 
                     + ((thuNhapChiuThue - 10000000m) * 0.15m);
        }
        else
        {
            thueTNCN = (5000000m * 0.05m) 
                     + (5000000m * 0.10m) 
                     + (8000000m * 0.15m) 
                     + ((thuNhapChiuThue - 18000000m) * 0.20m);
        }

        decimal luongNet = gross - baoHiem - thueTNCN;

        Console.WriteLine("\n--- OUTPUT ---");
        Console.WriteLine($"Giảm trừ Bảo hiểm (10.5%): {baoHiem:#,##0} VNĐ");
        Console.WriteLine($"Thu nhập chịu thuế: {thuNhapChiuThue:#,##0} VNĐ");
        Console.WriteLine($"Thuế TNCN phải nộp: {thueTNCN:#,##0} VNĐ");
        Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {luongNet:#,##0} VNĐ");


        // ==================== BÀI 10 ====================
        Console.WriteLine("\n=======================================================");
        Console.WriteLine("=== BÀI 10: QUẢN LÝ TỒN KHO (NULLABLE TYPES) ===");

        string maSP = "KB-09";
        string tenSP = "Bàn phím Cơ Akko";
        int? soLuongTonKho = null;
        int nguongToiThieu = 10;
        DateTime? ngayNhapHang = null;

        int soLuongHienThi = soLuongTonKho ?? 0;

        string trangThaiKho = "";
        if (soLuongTonKho == null || soLuongTonKho == 0)
        {
            trangThaiKho = "OutOfStock (Hết hàng)";
        }
        else if (soLuongTonKho < nguongToiThieu)
        {
            trangThaiKho = "LowStock (Sắp hết hàng)";
        }
        else
        {
            trangThaiKho = "InStock (Còn hàng)";
        }

        string duKienNhapHang = "";
        if (ngayNhapHang == null)
        {
            duKienNhapHang = "Chưa có lịch nhập hàng";
        }
        else
        {
            duKienNhapHang = ngayNhapHang.Value.ToString("dd/MM/yyyy");
        }

        Console.WriteLine("\n--- INPUT / DATA ---");
        Console.WriteLine($"Sản phẩm: {tenSP} (Mã: {maSP})");
        Console.WriteLine("Số lượng tồn kho: null (Chưa kiểm kê)");
        Console.WriteLine("Restock Date: null");

        Console.WriteLine("\n--- OUTPUT ---");
        Console.WriteLine($"Số lượng hiển thị: {soLuongHienThi} (Cảnh báo: Dữ liệu trống)");
        Console.WriteLine($"Trạng thái kho: {trangThaiKho}");
        Console.WriteLine($"Dự kiến nhập hàng: {duKienNhapHang}");
    }
}