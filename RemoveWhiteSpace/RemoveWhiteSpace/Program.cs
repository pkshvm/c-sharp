using System;
// RemoveWhiteSpace - удаление символов из предопределенного 
// множества из заданной строки. 
namespace RemoveWhiteSpace
{
    public class Program
    { public static void Main(string[] args)
        {
            // Определение множества пробельных символов
            char[] whiteSpace = {' ', '\n', '\t' };
            // Начинаем работу со строкой, в которой имеются
            // пробельные символы
            string s = "  this is a\nstring";
            Console.WriteLine("Дo:" + s);
            // Вьrеодим строку с удаленными пробель н ыми символами
            Console.Write("После:");
            // Поиск пробельных символов
            for (; ; )
            {
                // Ищем позиции искомых символов; если таковых в
                // строке больше нет, выходим из цикла
                int offset = s.IndexOfAny(whiteSpace);

                if (offset == -1)
                {
                    break;
                }
                // Разбиваем строку на, две части - до найденного
                // символа и поспе него.
                string Ьefore = s.Substring(0, offset);
                string after = s.Substring(offset + 1);
                // Объединяем эти части, но уже без найденного символа.
                s = String.Concat(Ьefore, after);
                // Циклически ищеы спедущий пробельный символ
                // в модифицировакиой строке s
            }
                Console.WriteLine(s);
                // Ожидаем подтверждения пользователя
                Console.WriteLine("Haжмитe <Enter> для " +
               "завершения программы . . . ");
                Console.Read();
        }
    }
}
