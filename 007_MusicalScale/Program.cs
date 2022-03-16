using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_MusicalScale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(523, 500); // До
            Console.Beep(587, 500); // Ре
            Console.Beep(659, 500); // Ми
            Console.Beep(698, 500); // Фа
            Console.Beep(784, 500); // Соль
            Console.Beep(880, 500); // Ля
            Console.Beep(988, 500); // Си
            // Console.Beep(1500, 1050);
            Console.ReadKey();
        }
    }
}
