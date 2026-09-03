using System;

using System.Text;

namespace Lesson
{
    internal class Lesson
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8; // Kullanıcı girişini UTF-8 olarak ayarlıyoruz
            Console.OutputEncoding = Encoding.UTF8; // Konsol çıktısını UTF-8 olarak ayarlıyoruz

            Console.Write("Enter the total number of tickets sold: ");
            int totalTickets = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the total earnings: ");
            float totalEarnings = Convert.ToSingle(Console.ReadLine());

            Console.Write($"The price of an average ticket is: {totalEarnings / totalTickets}");
        }
    }
}