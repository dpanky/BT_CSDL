using System;

namespace BTVN
{
    class Program
    {
        static void Main(string[] args)
        {
            Bai2();
        }
        // Bài 2: Phân quyền truy cập hệ thống (Role Authorization)
        static void Bai2()
        {
        Console.Write("Nhập vai trò: ");
        string role = Console.ReadLine();

        switch (role)
        {
            case "ADMIN":
            Console.WriteLine("Toàn quyền quản trị hệ thống.");
            break;

            case "MANAGER":
            Console.WriteLine("Quyền quản lý nhân sự và xem báo cáo.");
            break;

            case "EMPLOYEE":
            Console.WriteLine("Quyền tạo và chỉnh sửa hồ sơ cá nhân.");
            break;

            case "GUEST":
            Console.WriteLine("Chỉ có quyền xem thông tin công khai.");
            break;

            default:
            Console.WriteLine("Mã vai trò không hợp lệ!");
            break;
        }
        }
    }
    {
        Bai3();
    }
    // Bài 3: Xử lý giao dịch rút tiền ATM
    static void Bai3()
    {
        Console.Write(" Nhập số dư: ");
        double balance = double.Parse(Console.ReadLine());

        Console.Write("Nhập số tiền rút: ");
        double amount = double.Parse(Console.ReadLine());

        if (amount <= 0)
        {
            Console.WriteLine("Giao dịch thất bại: Số tiền rút phải lớn hơn 0.");
        }
        else if (amount % 50000 != 0)
        {
            Console.WriteLine("Giao dịch thất bại: Số tiền rút phải là bội số của 50,000 VNĐ.");
        }
        else if (amount > 5000000)
        {
            Console.WriteLine("Giao dịch thất bại: Hạn mức rút tối đa là 5,000,000 VNĐ / lần.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Giao dịch thất bại: Số dư tài khoản không đủ để thực hiện giao dịch.");
        }
        else
    {
        double remainingBalance = balance - amount;
        Console.WriteLine($"Giao dịch thành công. Số dư còn lại: {remainingBalance:N0} VNĐ");
    }
    {
        Bai4();
    }
    // Bài 4: Tổng đài chăm sóc khách hàng tự động (IVR Menu)
    static void Bai4()
    {
        Console.Write("Khách hàng bấm phím từ 0 đến 4: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            Console.WriteLine("Gặp tổng đài viên tư vấn thẻ.");
            break;

            case 2:
            Console.WriteLine("Tra cứu số dư tài khoản");
            break;

            case 3:
            Console.WriteLine("Báo khóa thẻ khẩn cấp.");
            break;

            case 4:
            Console.WriteLine("Tra cứu tỷ giá ngoại tệ.");
            break;

            case 0:
            Console.WriteLine("Quay lại menu chính.");
            break;

            default:
            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
            break;
        }
    }
    {
        Bai6();
    }
    // Bài 6: Cập nhật trạng thái đơn hàng E-Commerce
    static void Bai6()
    {
        Console.Write(" Nhập mã trạng thái đơn hàng (1: Pending, 2: Processing, 3: Shipped, 4: Delivered, 5: Cancelled): ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            Console.WriteLine("Chờ xác nhận thanh toán.");
            break;

            case 2:
            Console.WriteLine("Đang đóng gói và bàn giao đơn vị vận chuyển.");
            break;

            case 3:
            Console.WriteLine("Đơn hàng đang trên đường giao đến bạn.");
            break;

            case 4:
            Console.WriteLine("Đơn hàng đã hoàn thành. Cảm ơn bạn!");
            break;

            case 5:
            Console.WriteLine("Đơn hàng đã hủy. Xuất phiếu hoàn tiền");
            break;
        }
    }
    {
        Bai10();
    }
    // Bài 10: Quy đổi ngoại tệ cơ bản (Currency Converter)
    static void Bai10()
    {
    Console.Write("Nhập số tiền VNĐ: ");
        decimal số tiền VND = decimal.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhập mã ngoại tệ ("USD", "EUR", "JPY":");
        int chon = int.Parse(Console.ReadLine() ?? "1");
        CurrencyType loại tiền = (CurrencyType)chon;

        decimal tỷ giá = 0;
        string tên ngoại tệ = "";

        switch (loại tiền)
        {
            case CurrencyType.USD:
                tỷ giá = 25400m;
                tên ngoại tệ = "USD";
                break;
            case CurrencyType.EUR:
                tỷ giá = 27200m;
                tên ngoại tệ = "EUR";
                break;
            case CurrencyType.JPY:
                tỷ giá = 165m;
                tên ngoại tệ = "JPY";
                break;
            default:
                Console.WriteLine("Lựa chọn loại ngoại tệ không hợp lệ!");
                return;
        }

        decimal tiền ngoại tệ = số tiền VND / tỷ giá;
        Console.WriteLine($"Số tiền sau quy đổi: {tiền ngoại tệ:F2} {tên ngoại tệ}");
    }
    {
        Bai19();
    }
    // Bài 19: Máy tính các phép toán đơn giản (Console Calculator)
    static void Bai19()
    {
    Console.Write(" Nhập hai số thực A, B và một toán tử ('+', '-', '*', '/').");
    string input = Console.ReadLine();  
    string[] parts = input.Split();
    if (parts.Length != 3)
    switch (op)
    {
        case "+":
            result = A + B;
            break;
        case "-":
            result = A - B;
            break;
        case "*":
            result = A * B;
            break;
        case "/":
            if (B == 0)
            {
                Console.WriteLine("Lỗi: Không thể chia cho 0!");
                return;
            }
            result = A / B;
            break;
        default:
            Console.WriteLine("Lỗi: Toán tử không hợp lệ!");
            return;
    }
    Console.WriteLine($"Kết quả: {A} {op} {B} = {result}");
}
    {
        Bai20();
    }
    // Bài 20: Kiểm tra sự tương thích khi truyền máu
    static void Bai20()
    {
        Console.WriteLine("Nhập Nhóm máu người nhận");
        string nhóm máu người nhận = Console.ReadLine().ToUpper();

        switch (nhóm máu người nhận)
        {
            case "O":
            string tên nhóm máu người nhận = "O";
            if (nhóm máu được hiến == "O") compatible = true;
            break;

            case "A":
            string tên nhóm máu người nhận = "A";
            if (nhóm máu được hiến == "A" || nhóm máu được hiến == "O") compatible = true;
            break;

            case "B":
            string tên nhóm máu người nhận = "B";
            if (nhóm máu được hiến == "B" || nhóm máu được hiến == "O") compatible = true;
            break;

            case "AB":
            string tên nhóm máu người nhận = "AB (Nhận mọi nhóm)";
            compatible = true; 
            break;

            default:
            Console.WriteLine("Nhóm máu người nhận không hợp lệ!");
            return;
        }
        
        if (compatible)
        {
            Console.WriteLine($"Người có nhóm máu {nhóm máu người nhận} có thể nhận máu từ {nhóm máu được hiến}.");
        }
        else
        {
            Console.WriteLine($"Người có nhóm máu {nhóm máu người nhận} không thể nhận máu từ {nhóm máu được hiến}.");
        }
    }
}

    

            

        
        