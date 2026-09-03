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

            Console.WriteLine("Merhaba Artık C#'da UTF-8 ile Türkçe karakterleri sorunsuz bir şekilde kullanabilirsiniz.");
        }
    }
}