using System;

namespace Char
{
    class Program
    {
        static void Main()
        {
            char a = 'A';      // Символ
            char b = '\x3D'; // Значение в 16-ричном формате '\x0039' - также можно
            char c = '\u0039'; // Значение в формате unicode

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
