using System;
using System.Collections.Generic;
// AlignOutput - выравнивание множества строк 
// для улучшения внешнего вида вывода программы 
namespace AlignOutput
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string> {"Christa ",
            " Sarah",
            " Jonathan",
            "Samн",
            " Schmekowitz "
            };
            // Выводим имена. 
            Console.WriteLine("Следующие имена имеют разные длины:");

            foreach (string s in names)
            {
                Console.WriteLine("Имя ' " + s + " ' до обработки");
            }
            Console.WriteLine();
            // Делаем строки выровненными влево, одинаковой длины
            // Сначала копируем исходньм массив 
            List<string> stringsToAlign = new List<string>();

            // Удаляем лишние пробелы с обоих концов
            for (int i = 0; i < names.Count; i++)
            {
                string trimmedName = names[i].Trim();
                stringsToAlign.Add(trimmedName);
            }
            // Находим длину самой длинной строки
            int maxLength = 0;

            foreach (string s in stringsToAlign)
            {
                if (s.Length > maxLength)
                {
                    maxLength = s.Length;
                }
            }

            // Выравниваем все строки, приводя их
            // к максимальной длине
            for (int i = 0; i < stringsToAlign.Count; i++)
            {
                stringsToAlign[i] =
                stringsToAlign[i].PadRight(maxLength + 1);
            }
            // Выводим получившиеся строки
            Console.WriteLine("Te же имена выровнены и " +
                " и меют одинаковую длину : ");
            foreach (string s in stringsToAlign)
            {
                Console.WriteLine("Имя '" + s + "' после обработки");
            }
            // Ожидаем подтверждения пользователя
            Console.WriteLine(" Haжмитe <Enter> для " +
          " завершения программы . . .  ");
            Console.Read();
        }
    }
}