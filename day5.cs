using System;
using System.Text;

namespace BaiTap
{
    class Program
    {
        public static float calcGPA(float toan, float ly, float hoa)
        {
            return toan * 2f + ly * 1.5f + hoa;
        }

        static bool isPrime(int so)
        {
            if (so < 2)
            {
                return false;
            }

            for (int i = 2; i <= so / 2; i++)
            {
                if (so % i == 0) //ton tai 1 uoc so khac 1 va chinh no --> so khong phai la so nguyen to
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("1. Tính GPA");
            Console.WriteLine("2. Kiểm tra số nguyên tố");
            Console.Write("Chọn bài: ");
            string luaChon = (Console.ReadLine() ?? string.Empty).Trim();

            if (luaChon == "1")
            {
                Console.Write("Nhập điểm Toán: ");
                float toan = float.Parse(Console.ReadLine() ?? "0");
                Console.Write("Nhập điểm Lý: ");
                float ly = float.Parse(Console.ReadLine() ?? "0");
                Console.Write("Nhập điểm Hóa: ");
                float hoa = float.Parse(Console.ReadLine() ?? "0");
                float gpa = calcGPA(toan, ly, hoa);
                Console.WriteLine("Điểm trung bình: " + gpa);
            }
            else if (luaChon == "2")
            {
                Console.Write("Nhập số cần kiểm tra : ");
                int so = int.Parse(Console.ReadLine());
                bool kq = isPrime(so);
                if (kq)
                {
                    Console.WriteLine($"so {so} là số nguyên tố.");
                }
                else
                {
                    Console.WriteLine($"so {so} không phải là số nguyên tố.");
                }
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
            }
        }
    }
}

