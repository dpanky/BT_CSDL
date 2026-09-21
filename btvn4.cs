using System;
using System.Collections.Generic;
using System.Text;

namespace Baitap {
    internal class Functions_Exercises {

        public static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true) {
                Console.WriteLine("\n=================== MENU BÀI TẬP (BTVN 4) ===================");
                Console.WriteLine("1.  Bài 1: Tính tổng hai số nguyên");
                Console.WriteLine("2.  Bài 2: Kiểm tra số chẵn lẻ");
                Console.WriteLine("3.  Bài 3: Tìm số lớn nhất trong ba số");
                Console.WriteLine("4.  Bài 4: Tính giai thừa");
                Console.WriteLine("5.  Bài 5: Đảo ngược chuỗi");
                Console.WriteLine("6.  Bài 6: Kiểm tra số nguyên tố");
                Console.WriteLine("7.  Bài 7: In dãy Fibonacci");
                Console.WriteLine("8.  Bài 8: Đếm số nguyên âm trong chuỗi");
                Console.WriteLine("9.  Bài 9: Tính lũy thừa");
                Console.WriteLine("10. Bài 10: Tính trung bình mảng");
                Console.WriteLine("11. Bài 11: Kiểm tra chuỗi đối xứng");
                Console.WriteLine("12. Bài 12: Chuyển đổi Celsius sang Fahrenheit");
                Console.WriteLine("13. Bài 13: Tìm giá trị nhỏ nhất trong mảng");
                Console.WriteLine("14. Bài 14: Tính tổng các chữ số");
                Console.WriteLine("15. Bài 15: Sắp xếp mảng tăng dần");
                Console.WriteLine("16. Bài 16: Xóa ký tự trùng lặp trong chuỗi");
                Console.WriteLine("17. Bài 17: Tìm ước chung lớn nhất (UCLN)");
                Console.WriteLine("18. Bài 18: Chuyển đổi thập phân sang nhị phân");
                Console.WriteLine("19. Bài 19: Kiểm tra năm nhuận");
                Console.WriteLine("20. Bài 20: Đếm số từ trong câu");
                Console.WriteLine("0.  Thoát chương trình");
                Console.Write("👉 Nhập số bài bạn muốn chạy (0 - 20): ");

                string luaChon = Console.ReadLine()?.Trim() ?? "";
                if (luaChon == "0") {
                    Console.WriteLine("Đã thoát chương trình. Tạm biệt!");
                    break;
                }

                Console.WriteLine("-------------------------------------------------------------");
                switch (luaChon) {
                    case "1":
                        Console.Write("Nhập số thứ nhất (a): ");
                        int a1 = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Nhập số thứ hai (b): ");
                        int b1 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine($"=> Tổng {a1} + {b1} = {TinhTong(a1, b1)}");
                        break;

                    case "2":
                        Console.Write("Nhập số nguyên n: ");
                        int n2 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine(KiemTraChan(n2) ? $"=> {n2} là số CHẴN" : $"=> {n2} là số LẺ");
                        break;

                    case "3":
                        Console.Write("Nhập số thứ nhất (a): ");
                        int a3 = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Nhập số thứ hai (b): ");
                        int b3 = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Nhập số thứ ba (c): ");
                        int c3 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine($"=> Số lớn nhất là: {TimMax(a3, b3, c3)}");
                        break;

                    case "4":
                        Console.Write("Nhập số nguyên dương n: ");
                        int n4 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine($"=> {n4}! = {TinhGiaiThua(n4)}");
                        break;

                    case "5":
                        Console.Write("Nhập chuỗi cần đảo ngược: ");
                        string s5 = Console.ReadLine() ?? "";
                        Console.WriteLine($"=> Chuỗi sau khi đảo ngược: \"{DaoNguocChuoi(s5)}\"");
                        break;

                    case "6":
                        Console.Write("Nhập số nguyên n: ");
                        int n6 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine(KiemTraNguyenTo(n6) ? $"=> {n6} là số NGUYÊN TỐ" : $"=> {n6} KHÔNG PHẢI số nguyên tố");
                        break;

                    case "7":
                        Console.Write("Nhập số lượng số Fibonacci cần in (n): ");
                        int n7 = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write($"=> {n7} số Fibonacci đầu tiên: ");
                        InFibonacci(n7);
                        break;

                    case "8":
                        Console.Write("Nhập chuỗi: ");
                        string s8 = Console.ReadLine() ?? "";
                        Console.WriteLine($"=> Số lượng nguyên âm trong chuỗi: {DemNguyenAm(s8)}");
                        break;

                    case "9":
                        Console.Write("Nhập cơ số x: ");
                        double x9 = double.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Nhập số mũ y: ");
                        int y9 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine($"=> {x9}^{y9} = {TinhLuyThua(x9, y9)}");
                        break;

                    case "10":
                        Console.Write("Nhập các số nguyên của mảng (cách nhau bởi dấu cách, ví dụ: 4 5 6 7): ");
                        int[] arr10 = Array.ConvertAll((Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
                        Console.WriteLine($"=> Trung bình cộng: {TinhTrungBinh(arr10)}");
                        break;

                    case "11":
                        Console.Write("Nhập chuỗi cần kiểm tra: ");
                        string s11 = Console.ReadLine() ?? "";
                        Console.WriteLine(KiemTraDoiXung(s11) ? $"=> Chuỗi \"{s11}\" là chuỗi ĐỐI XỨNG (Palindrome)" : $"=> Chuỗi \"{s11}\" KHÔNG PHẢI chuỗi đối xứng");
                        break;

                    case "12":
                        Console.Write("Nhập nhiệt độ (°C): ");
                        double c12 = double.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine($"=> {c12}°C = {CelsiusToFahrenheit(c12)}°F");
                        break;

                    case "13":
                        Console.Write("Nhập các số nguyên của mảng (cách nhau bởi dấu cách, ví dụ: 10 5 8 2 9): ");
                        int[] arr13 = Array.ConvertAll((Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
                        Console.WriteLine($"=> Giá trị nhỏ nhất trong mảng: {TimMin(arr13)}");
                        break;

                    case "14":
                        Console.Write("Nhập số nguyên n: ");
                        int n14 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine($"=> Tổng các chữ số của {n14} là: {TongCacChuSo(n14)}");
                        break;

                    case "15":
                        Console.Write("Nhập các số nguyên của mảng (cách nhau bởi dấu cách, ví dụ: 3 1 4 2): ");
                        int[] arr15 = Array.ConvertAll((Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
                        Console.Write("=> Mảng sau khi sắp xếp tăng dần: ");
                        SapXepMang(arr15);
                        break;

                    case "16":
                        Console.Write("Nhập chuỗi: ");
                        string s16 = Console.ReadLine() ?? "";
                        Console.WriteLine($"=> Chuỗi sau khi xóa ký tự trùng lặp: \"{XoaTrungLap(s16)}\"");
                        break;

                    case "17":
                        Console.Write("Nhập số thứ nhất (a): ");
                        int a17 = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Nhập số thứ hai (b): ");
                        int b17 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine($"=> UCLN({a17}, {b17}) = {UCLN(a17, b17)}");
                        break;

                    case "18":
                        Console.Write("Nhập số nguyên dương thập phân (n): ");
                        int n18 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine($"=> Hệ nhị phân: {DecimalToBinary(n18)}");
                        break;

                    case "19":
                        Console.Write("Nhập năm cần kiểm tra: ");
                        int year19 = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine(KiemTraNamNhuan(year19) ? $"=> Năm {year19} là NĂM NHUẬN" : $"=> Năm {year19} KHÔNG PHẢI năm nhuận");
                        break;

                    case "20":
                        Console.Write("Nhập câu/đoạn văn: ");
                        string sentence20 = Console.ReadLine() ?? "";
                        Console.WriteLine($"=> Số từ trong câu: {DemSoTu(sentence20)}");
                        break;

                    default:
                        Console.WriteLine("⚠️ Lựa chọn không hợp lệ! Vui lòng chọn từ 0 đến 20.");
                        break;
                }
            }
        }

        // Bài 1: Tính tổng hai số nguyên
        public static int TinhTong(int a, int b) {
            return a + b;
        }

        // Bài 2: Kiểm tra số chẵn lẻ
        public static bool KiemTraChan(int n) {
            return n % 2 == 0;
        }

        // Bài 3: Tìm số lớn nhất trong ba số
        public static int TimMax(int a, int b, int c) {
            return Math.Max(Math.Max(a, b), c);
        }

        // Bài 4: Tính giai thừa
        public static long TinhGiaiThua(int n) {
            long ketQua = 1;
            for (int i = 1; i <= n; i++) {
                ketQua *= i;
            }
            return ketQua;
        }

        // Bài 5: Đảo ngược chuỗi
        public static string DaoNguocChuoi(string input) {
            char[] mang = input.ToCharArray();
            Array.Reverse(mang);
            return new string(mang);
        }

        // Bài 6: Kiểm tra số nguyên tố
        public static bool KiemTraNguyenTo(int n) {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++) {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Bài 7: In dãy Fibonacci
        public static void InFibonacci(int n) {
            int a = 0, b = 1;
            for (int i = 0; i < n; i++) {
                Console.Write(a + " ");
                int tam = a + b;
                a = b;
                b = tam;
            }
            Console.WriteLine();
        }

        // Bài 8: Đếm nguyên âm
        public static int DemNguyenAm(string s) {
            string nguyenAm = "aeiouAEIOU";
            int dem = 0;
            foreach (char c in s) {
                if (nguyenAm.Contains(c)) dem++;
            }
            return dem;
        }

        // Bài 9: Tính lũy thừa (không dùng Math.Pow)
        public static double TinhLuyThua(double x, int y) {
            double ketQua = 1;
            for (int i = 0; i < y; i++) {
                ketQua *= x;
            }
            return ketQua;
        }

        // Bài 10: Tính trung bình mảng
        public static double TinhTrungBinh(int[] arr) {
            int tong = 0;
            foreach (int x in arr) tong += x;
            return (double)tong / arr.Length;
        }

        // Bài 11: Kiểm tra chuỗi đối xứng
        public static bool KiemTraDoiXung(string s) {
            return s == DaoNguocChuoi(s);
        }

        // Bài 12: Chuyển đổi C sang F
        public static double CelsiusToFahrenheit(double c) {
            return c * 9 / 5 + 32;
        }

        // Bài 13: Tìm giá trị nhỏ nhất trong mảng
        public static int TimMin(int[] arr) {
            int min = arr[0];
            foreach (int x in arr) {
                if (x < min) min = x;
            }
            return min;
        }

        // Bài 14: Tổng các chữ số
        public static int TongCacChuSo(int n) {
            int tong = 0;
            while (n > 0) {
                tong += n % 10;
                n /= 10;
            }
            return tong;
        }

        // Bài 15: Sắp xếp mảng tăng dần và in ra
        public static void SapXepMang(int[] arr) {
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        // Bài 16: Xóa ký tự trùng lặp
        public static string XoaTrungLap(string s) {
            StringBuilder ketQua = new StringBuilder();
            HashSet<char> daXuatHien = new HashSet<char>();
            foreach (char c in s) {
                if (!daXuatHien.Contains(c)) {
                    daXuatHien.Add(c);
                    ketQua.Append(c);
                }
            }
            return ketQua.ToString();
        }

        // Bài 17: Tìm UCLN (thuật toán Euclid)
        public static int UCLN(int a, int b) {
            while (b != 0) {
                int tam = b;
                b = a % b;
                a = tam;
            }
            return a;
        }

        // Bài 18: Chuyển thập phân sang nhị phân
        public static string DecimalToBinary(int n) {
            if (n == 0) return "0";
            StringBuilder ketQua = new StringBuilder();
            while (n > 0) {
                ketQua.Insert(0, n % 2);
                n /= 2;
            }
            return ketQua.ToString();
        }

        // Bài 19: Kiểm tra năm nhuận
        public static bool KiemTraNamNhuan(int year) {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        // Bài 20: Đếm số từ trong câu
        public static int DemSoTu(string sentence) {
            string[] tuMang = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return tuMang.Length;
        }
    }
}