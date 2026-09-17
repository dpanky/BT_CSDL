
using System;

internal class Program
{
    /// <summary>
            /// kelvin = celsius + 273
            /// fahrenheit = celsius * 18 / 10 + 32
            /// </summary>
            static void ex01()
            {
                Console.WriteLine("Nhập vào độ Celcius: ");
                float celcius = float.Parse(Console.ReadLine());
                float kelvin = celcius + 273;
                float fahrenheit = celcius * 18 / 10 + 32;

                Console.WriteLine($"{celcius} °C = {kelvin} K");
                Console.WriteLine($"{celcius} °C = {fahrenheit} °F");
            }
    private static void Main(string[] args)
    {
        ex01();
        
    }
}
