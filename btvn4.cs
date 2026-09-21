using System;

namespace Baitap {
    internal class Functions_Exercises 
    {
        public static void Main(string[] args)
         
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