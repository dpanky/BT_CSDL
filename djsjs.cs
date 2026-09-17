using System;
using System.Text;

namespace BaiTap
{
    class Program
    {
        public static void Main(string[] args)
        {
            public static float calcGPA(float toan, float ly, float hoa)
            {
                return toan * 2f + ly * 1.5f + hoa;
            }

            public static bool isPrime(int so)
            {
                if (so < 2)
                {
                    return false;
                }

                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0) // ton tai 1 uoc so khac 1 va chinh no --> so khong phai la so nguyen to
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}