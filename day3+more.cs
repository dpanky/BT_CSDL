using System;

namespace StringExercise
{
    class Program
    {
        // Bài 1: In ký tự tại vị trí k
        static void Bai1()
        {
            Console.Write("Nhập vào chuỗi: ");
            string s = Console.ReadLine();
            Console.Write("Nhập vào vị trí: ");
            int k = int.Parse(Console.ReadLine());
            
            if (k >= 1 && k <= s.Length)
            {
                Console.WriteLine($"Ký tự ở vị trí {k} là: {s[k - 1]}");
            }
            else
            {
                Console.WriteLine("Vị trí không hợp lệ!");
            }
        }

        // Bài 2: Đếm số lần xuất hiện của ký tự c trong chuỗi s
        static void Bai2()
        {
            Console.Write("Nhập vào chuỗi: ");
            string s = Console.ReadLine();
            Console.Write("Nhập vào ký tự cần đếm: ");
            char c = char.Parse(Console.ReadLine());

            int answer = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    answer++;
                }
            }
            Console.WriteLine(answer);
        }

        // Bài 3
        static void Bai3()
        { 
		string s = Console.ReadLine();
			char c = char.Parse(Console.ReadLine());
			int answer = -1;
			for (int i = 0; i < s.Length; i++) {
				if (s[i] == c) {
					/*
					 * Gọi lệnh break để dừng vòng lặp do đã tìm thấy 
                     * vị trí đầu tiên mà ký tự c
					 * xuất hiện. Nếu không có lệnh break thì kết quả 
                     * của chương trình sẽ là vị trí
					 * cuối cùng mà ký tự c xuất hiện.
					 */
					answer = i;
					break;
				}
            else
            {
                Console.WriteLine(answer);
            }
        }
		}
    }