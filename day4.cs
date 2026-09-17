using System;

internal class Program
{
    // BÀI 1: Kiểm tra loại tam giác (Equilateral, Isosceles, Scalene)
    static void Bai1()
    {
        Console.WriteLine("--- BÀI 1: KIỂM TRA TAM GIÁC ---");
        Console.Write("Nhập cạnh a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập cạnh b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập cạnh c: ");
        double c = double.Parse(Console.ReadLine());

        // Kiểm tra điều kiện tạo thành tam giác
        if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Đây là tam giác đều (Equilateral triangle).");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Đây là tam giác cân (Isosceles triangle).");
            }
            else
            {
                Console.WriteLine("Đây là tam giác thường (Scalene triangle).");
            }
        }
        else
        {
            Console.WriteLine("Ba cạnh trên không tạo thành tam giác hợp lệ!");
        }
    }

    // =========================================================================
    // BÀI 2: Nhập 10 số, tính tổng và trung bình cộng
    // =========================================================================
    static void Bai2()
    {
        Console.WriteLine("\n--- BÀI 2: TÍNH TỔNG VÀ TRUNG BÌNH 10 SỐ ---");
        int sum = 0;
        Console.WriteLine("Nhập vào 10 số nguyên:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Nhập số thứ {i}: ");
            int num = int.Parse(Console.ReadLine());
            sum += num;
        }

        double avg = (double)sum / 10;
        Console.WriteLine($"Tổng của 10 số là: {sum}");
        Console.WriteLine($"Trung bình cộng là: {avg}");
    }

    // =========================================================================
    // BÀI 3: In bảng cửu chương của một số nguyên
    // =========================================================================
    static void Bai3()
    {
        Console.WriteLine("\n--- BÀI 3: BẢNG CỬU CHƯƠNG ---");
        Console.Write("Nhập một số nguyên cần in bảng nhân: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Bảng cửu chương của {n}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }

    // =========================================================================
    // BÀI 4: In các mẫu tam giác số
    // =========================================================================
    static void Bai4()
    {
        Console.WriteLine("\n--- BÀI 4: IN CÁC MẪU TAM GIÁC SỐ ---");
        Console.Write("Nhập số dòng (ví dụ 4): ");
        int n = int.Parse(Console.ReadLine());

        // Pattern 1:
        // 1
        // 1 2
        // 1 2 3
        // 1 2 3 4
        Console.WriteLine("\nPattern 1:");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        // Pattern 2:
        // 1
        // 2 3
        // 4 5 6
        // 7 8 9 10
        Console.WriteLine("\nPattern 2:");
        int count2 = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(count2 + " ");
                count2++;
            }
            Console.WriteLine();
        }

        // Pattern 3 (Tam giác kim tự tháp):
        //    1
        //   2 3
        //  4 5 6
        // 7 8 9 10
        Console.WriteLine("\nPattern 3 (Pyramid):");
        int count3 = 1;
        for (int i = 1; i <= n; i++)
        {
            // In khoảng trắng căn lề
            for (int space = 1; space <= n - i; space++)
            {
                Console.Write(" ");
            }
            // In số
            for (int j = 1; j <= i; j++)
            {
                Console.Write(count3 + " ");
                count3++;
            }
            Console.WriteLine();
        }
    }

    // BÀI 5 (Slide 1): In n số hạng của chuỗi Harmonic và tính tổng
    // 1 + 1/2 + 1/3 + ... + 1/n
    static void Bai5()
    {
        Console.WriteLine("\n--- BÀI 5: DÃY SỐ HARMONIC ---");
        Console.Write("Nhập số lượng số hạng n: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0.0;
        Console.Write("Dãy số: ");
        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write($" + 1/{i}");
            }
            sum += 1.0 / i;
        }

        Console.WriteLine();
        Console.WriteLine($"Tổng của dãy số Harmonic với {n} số hạng là: {sum:F4}");
    }

    // =========================================================================
    // BÀI 6 (Slide 2): Tìm số hoàn hảo (Perfect numbers) trong một khoảng
    // =========================================================================
    static void Bai6()
    {
        Console.WriteLine("\n--- BÀI 6: TÌM SỐ HOÀN HẢO ---");
        Console.Write("Nhập giới hạn đầu (start): ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Nhập giới hạn cuối (end): ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine($"Các số hoàn hảo trong khoảng [{start}, {end}] là:");
        for (int num = start; num <= end; num++)
        {
            if (num <= 1) continue;

            int sumOfDivisors = 0;
            // Tìm các ước thực sự của num
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sumOfDivisors += i;
                }
            }

            // Nếu tổng ước bằng chính nó thì là số hoàn hảo
            if (sumOfDivisors == num)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }

    // =========================================================================
    // BÀI 7 (Slide 3): Kiểm tra số nguyên tố (Prime number)
    // =========================================================================
    static void Bai7()
    {
        Console.WriteLine("\n--- BÀI 7: KIỂM TRA SỐ NGUYÊN TỐ ---");
        Console.Write("Nhập một số nguyên: ");
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (n < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{n} là số nguyên tố (Prime number).");
        }
        else
        {
            Console.WriteLine($"{n} không phải là số nguyên tố.");
        }
    }

    // HÀM MAIN: Menu chọn bài tập để chạy thử
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("================ MENU BÀI TẬP ================");
        Console.WriteLine("1. Kiểm tra loại tam giác (Equilateral, Isosceles, Scalene)");
        Console.WriteLine("2. Tính tổng và trung bình 10 số");
        Console.WriteLine("3. Bảng cửu chương của một số");
        Console.WriteLine("4. Vẽ các mẫu tam giác số (Patterns)");
        Console.WriteLine("5. Tính tổng dãy số Harmonic (1 + 1/2 + ... + 1/n)");
        Console.WriteLine("6. Tìm số hoàn hảo trong khoảng");
        Console.WriteLine("7. Kiểm tra số nguyên tố");
        Console.WriteLine("==============================================");
        Console.Write("Nhập số thứ tự bài cần chạy (1-7): ");
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Bai1();
                break;
            case 2:
                Bai2();
                break;
            case 3:
                Bai3();
                break;
            case 4:
                Bai4();
                break;
            case 5:
                Bai5();
                break;
            case 6:
                Bai6();
                break;
            case 7:
                Bai7();
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }

        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
