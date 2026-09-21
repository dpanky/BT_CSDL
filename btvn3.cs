using System;

namespace BaiTap
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
        }

        /// <summary>
        /// Gieo 2 con súc sắc rồi tính tổng giá trị 2 mặt
        /// nếu lớn hơn 6 thì gọi là tài, nhỏ hơn 6 thì gọi là xỉu, bằng 6 thì gọi là đặc biệt
        /// đầu tiên,máy sẽ gieo súc sắc, sau đó người chơi sẽ đặt cược tài hoặc xỉu, 
        /// nếu kết quả của máy và người chơi trùng nhau thì người chơi thắng, ngược lại thì thua
        /// trong trường hợp đoán đúng số 6 thì người chơi sẽ được thưởng 3 lần số tiền đặt cược
        /// sau mỗi lần chơi, máy sẽ hỏi người chơi có muốn chơi tiếp không, 
        /// nếu người chơi đồng ý thì quay lại gieo súc sắc, ngược lại thì kết thúc trò chơi.
        /// Khi kết thúc trò chơi, máy sẽ thông báo tổng số tiền thắng hoặc thua của người chơi.
        /// </summary>
        public static void dice_game()
        {
            long tien = 1000_000;
            int soLanChoi = 0;
            int soLanThua = 0;
            int soLanDacBiet = 0;
            bool continuePlaying = true;
            do
            {
                soLanChoi++;
                Console.Write($"Bạn có {tien} đồng. Bạn đặt bao nhiêu? ");
                long tienDatCuoc = 0;
                do
                {
                    bool ok = long.TryParse(Console.ReadLine(), out long result);
                    if (ok && result <= tien && result > 1000)
                    {
                        tienDatCuoc = result;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Vui lòng nhập một số hợp lệ hoặc số tiền đặt " +
                            $"cược không được vượt quá số tiền hiện có {tien}. Hoặc trên 1000 đồng");
                        Console.Write("Bạn đặt bao nhiêu? ");
                    }
                } while (true);

                Random rand = new Random();
                int dice1 = rand.Next(1, 7);
                int dice2 = rand.Next(1, 7);
                int sum = dice1 + dice2;

                string guess;
                do
                {
                    Console.Write("Bạn đoán tài (T), xỉu (X) hay lục (L)? ");
                    guess = Console.ReadLine().ToLower();
                    if (guess != "t" && guess != "x" && guess != "l")
                    {
                        Console.WriteLine("Vui lòng nhập T, X hoặc L.");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                // Kiểm tra 
                bool isWin = false;
                bool isSpecial = false;
                if (guess == "t" && sum > 6)
                {
                    isWin = true;
                }
                else if (guess == "x" && sum < 6)
                {
                    isWin = true;
                }
                else if (guess == "l" && sum == 6)
                {
                    isWin = true;
                    isSpecial = true; // là đặc biệt
                }
                Console.WriteLine($"Kết quả gieo súc sắc: {dice1} + {dice2} = {sum}");
                if (isWin)
                {
                    if (isSpecial)
                    {
                        soLanDacBiet++;
                        tien += tienDatCuoc * 3;
                        Console.WriteLine($"Bạn thắng đặc biệt! Tổng số tiền hiện tại: {tien} đồng.");
                    }
                    else
                    {
                        tien += tienDatCuoc;
                        Console.WriteLine($"Bạn thắng! Tổng số tiền hiện tại: {tien} đồng.");
                    }
                }
                else
                {
                    tien -= tienDatCuoc;
                    soLanThua++;
                    Console.WriteLine($"Bạn thua! Tổng số tiền hiện tại: {tien} đồng.");
                }

                Console.Write("\nBạn có muốn chơi tiếp không? (C/K): ");
                string input = Console.ReadLine(); // C
                if (input.ToLower() == "k")
                {
                    continuePlaying = false;
                }
            } while (continuePlaying);

            Console.WriteLine($"\nTrò chơi kết thúc!");
            Console.WriteLine($"Tổng số lần chơi: {soLanChoi}");
            Console.WriteLine($"Tổng số lần thắng: {soLanChoi - soLanThua - soLanDacBiet}");
            Console.WriteLine($"Tổng số lần thua: {soLanThua}");
            Console.WriteLine($"Tổng số lần thắng đặc biệt: {soLanDacBiet}");
        }

        // Máy tính nghĩ ra ngẫu nhiên 1 số từ 1 đến 100, cho người dùng đoán.
        // Game có 3 levels dễ/trung bình/khó tương ứng với được gieo 9/6/4 lần gieo.
        // nếu mức dễ thì tiền cược được 1/2 lần tiền đặt, 
        // trung bình thì được 1 lần đặt, khó thì thắng 3 lần đặt.
        // Trò chơi sẽ kết thúc khi người chơi chọn không chơi nữa hoặc số tiền còn lại 0 đồng.
        public static void Bai2()
        {
            long tien = 1000_000;
            Random rand = new Random();
            bool continuePlaying = true;
            do
            {
                Console.Write("\nChọn độ khó (1-Dễ/9 lần, 2-TB/6 lần, 3-Khó/4 lần): ");
                int level;
                while (!int.TryParse(Console.ReadLine(), out level) || level < 1 || level > 3)
                    Console.Write("Chọn 1, 2 hoặc 3: ");

                int soLan = level == 1 ? 9 : level == 2 ? 6 : 4;
                double heSo = level == 1 ? 0.5 : level == 2 ? 1 : 3;

                Console.Write($"Bạn có {tien} đồng. Đặt cược: ");
                long cuoc;
                while (!long.TryParse(Console.ReadLine(), out cuoc) || cuoc <= 1000 || cuoc > tien)
                    Console.Write("Số tiền không hợp lệ, nhập lại: ");

                int soCanTim = rand.Next(1, 101);
                bool thang = false;

                for (int luot = 1; luot <= soLan; luot++)
                {
                    Console.Write($"Lượt {luot}/{soLan} - Đoán (1-100): ");
                    if (!int.TryParse(Console.ReadLine(), out int doan)) { luot--; continue; }
                    if (doan == soCanTim) { thang = true; break; }
                    Console.WriteLine(doan < soCanTim ? "Số cần tìm lớn hơn!" : "Số cần tìm nhỏ hơn!");
                }

                if (thang)
                {
                    long thuong = (long)(cuoc * heSo);
                    tien += thuong;
                    Console.WriteLine($"Đúng rồi! Số là {soCanTim}. Thắng {thuong} đồng. Còn {tien} đồng.");
                }
                else
                {
                    tien -= cuoc;
                    Console.WriteLine($"Sai rồi! Số là {soCanTim}. Thua {cuoc} đồng. Còn {tien} đồng.");
                }

                if (tien <= 0) { Console.WriteLine("Hết tiền! Kết thúc."); break; }

                Console.Write("Chơi tiếp? (C/K): ");
                if (Console.ReadLine().ToLower() == "k") continuePlaying = false;

            } while (continuePlaying);

            Console.WriteLine($"Kết thúc! Còn lại: {tien} đồng.");
        }

        // Write a program to display the n terms of harmonic series and their
        // sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
        public static void Bai6()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
                Console.WriteLine($"1/{i} = {1.0 / i:F4}");
            }
            Console.WriteLine($"Tổng: {sum:F4}");
        }

        // Write a program to find the perfect numbers within a given number range.
        public static void Bai7()
        {
            Console.Write("Từ: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Đến: ");
            int end = int.Parse(Console.ReadLine());
            for (int n = start; n <= end; n++)
            {
                if (n < 2) continue;
                int tong = 0;
                for (int i = 1; i <= n / 2; i++)
                {
                    if (n % i == 0) tong += i;
                }
                if (tong == n) Console.WriteLine(n);
            }
        }
    }
}
