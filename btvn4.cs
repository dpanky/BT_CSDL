using System;

namespace BaiTap
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
        }
        // Bai 1: Tinh tong 2 so nguyen
        public static void Bai1()
        {
         Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());
 
            Console.WriteLine($"Tổng = {TinhTong(a, b)}");
        }
 
        static int TinhTong(int a, int b) {
            return a + b;
        }

        // Bai 2: Kiem tra chan le
        public static void Bai2()
        {
            Console.Write("Nhập số: ");
            int n = int.Parse(Console.ReadLine());
 
            Console.WriteLine(KiemTraChan(n) ? "n là số chẵn" : "n là số lẻ");
        }
 
        static bool KiemTraChan(int n) {
            return n % 2 == 0;
        }

        // Bai 3: Tim so lon nhat trong 3 so
        public static void Bai3()
        {
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập số c: ");
            int c = int.Parse(Console.ReadLine());
 
            Console.WriteLine($"Số lớn nhất là: {TimSoLonNhat(a, b, c)}");
        }
        static int TimSoLonNhat(int a, int b, int c) {
            int max = a;
            if (b > max) {
                max = b;
            }
            if (c > max) {
                max = c;
            }
            return max;
        }

        // Bai 4: Tinh giai thua cua 1 so
        public static void Bai4()
        {
             Console.Write("Nhập số n: ");
            int n = int.Parse(Console.ReadLine());
 
            Console.WriteLine($"{n}! = {TinhGiaiThua(n)}");
        }
        static long TinhGiaiThua(int n) {
            long ketQua = 1;
            for (int i = 1; i <= n; i++) {
                ketQua *= i;
            }
            return ketQua;
        }

        // Bai 6: Kiem tra so nguyen to
        public static void Bai6()
        {
            Console.Write("Nhập số: ");
            int n = int.Parse(Console.ReadLine());
 
            Console.WriteLine(KiemTraNguyenTo(n) ? "n là số nguyên tố" : "n không phải là số nguyên tố");
        }
        static bool KiemTraNguyenTo(int n) {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++) {
                if (n % i == 0) return false;
            }
            return true;
        }
        // Bai 8: Dem so nguyen am cua chuoi
        public static void Bai8()
        {
              Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine();
 
            Console.WriteLine($"Số lượng nguyên âm: {DemNguyenAm(s)}");
        }
 
        static int DemNguyenAm(string s) {
            string nguyenAm = "aeiouAEIOU";
            int dem = 0;
            foreach (char c in s) {
                if (nguyenAm.Contains(c)) dem++;
            }
            return dem;
        }
        // Bai 9: Tinh luy thua
        public static void Bai9()
        {
            Console.Write("Nhập x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhập y (số mũ): ");
            int y = int.Parse(Console.ReadLine());
 
            Console.WriteLine($"{x}^{y} = {TinhLuyThua(x, y)}");
        }
 
        static double TinhLuyThua(double x, int y) {
            double ketQua = 1;
            for (int i = 0; i < y; i++) {
                ketQua *= x;
            }
            return ketQua;
        }
        // Bai 10: Tinh diem TB cua mang 
        public static void Bai10()
        {
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());
            double[] mang = new double[n];
 
            for (int i = 0; i < n; i++) {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                mang[i] = double.Parse(Console.ReadLine());
            }
 
            Console.WriteLine($"Điểm trung bình: {TinhDiemTB(mang)}");
        }
        static double TinhDiemTB(double[] mang) {
            double tong = 0;
            foreach (double diem in mang) {
                tong += diem;
            }
            return tong / mang.Length;
        }

        // Bai 12: Chuyen do C -> F
        public static void Bai12()
        {
            Console.Write("Nhập nhiệt độ C: ");
            double c = double.Parse(Console.ReadLine());
 
            Console.WriteLine($"{c} độ C = {CelsiusToFahrenheit(c)} độ F");
        }
 
        static double CelsiusToFahrenheit(double c) {
            return c * 9 / 5 + 32;
        }

        // Bai 13: Tim GTNN trong mang
        public static void Bai13()
        {
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < n; i++) {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Giá trị nhỏ nhất trong mảng: {TimGTNN(mang)}");
        }
        static int TimGTNN(int[] mang) {
            int min = mang[0];
            foreach (int so in mang) {
                if (so < min) min = so;
            }
            return min;
        }
    }
}