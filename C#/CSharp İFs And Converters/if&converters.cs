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

            Console.Write("Enter your first number: ");
            float fn = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter your second number: ");
            float sn = Convert.ToSingle(Console.ReadLine());

            if (fn > sn)
            {
                Console.WriteLine("The first number is greater than the second number.");
            }
            else if (fn < sn)
            {
                Console.WriteLine("The first number is less than the second number.");
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }
        }
    }
}