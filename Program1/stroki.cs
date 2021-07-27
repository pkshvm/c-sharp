using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя");

            string name = Console.ReadLine();

            Console.WriteLine("Привет, " + name);

            //Ожидание реакции пользователя
            Console.WriteLine("нажмите <ENTER> для выхода......");
            Console.Read();
        }
    }
}