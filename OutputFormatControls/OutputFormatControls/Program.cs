// OutputFormatControls позволяет пользователю посмотреть,
// как влияют модификаторы форматирования на вывод чисел. 
// Модификаторы вводятся в программу так же, как и числа, 
// - в процессе работы программы 
namespace OutputFormatControls
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Бесконечный цикл для ввода чисел, пока пользователь
            // не введет вместо числа пустую строку, что является
            // сигналом к окончанию работы программы
            for (;;)
                {
                // Ввод числа и выход из цикла, если введена пустая
                // строка
                Console.WriteLine("Введите число с плавающей точкой ");
                string numberInput = Console.ReadLine();
                if (numberInput.Length == 0)
                {
                    break;
                }
                double numЬer = Double.Parse(numberInput);

                // Ввод модификаторов форматирования, разделенных
                // пробелами
                Console.WriteLine("Bвeдитe модификаторы " +
                    "форматирования, разделенные " +
                    "пробелами");
                Console.WriteLine("(Haпpимep: С Е F1 N0 0000000.00000)");
                char[] separator = { ' ' };
                string formatString = Console.ReadLine();
                string[] formats = formatString.Split(separator);

                // Цикл по введенным модификаторам
                foreach (string s in formats)
                {
                    if (s.Length != 0)
                    {
                        // Создание управляющего элемента форматирования
                        // из введенного модификатора
                        string formatCommand = "{0:" + s + "}";

                        // Вьrnод числа с применением созданного
                        // управляющего элемента форматирования
                        Console.Write(
                            "Модификатор {0} дает ", formatCommand);
                        try
                        {
                            Console.WriteLine(formatCommand, numЬer);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("<Heвepный модификатор>");
                        }
                        Console.WriteLine();
                    }
                }
            }
            // Ожидаем подтверждения пользователя
            Console.WriteLine("Haжмитe <Enter> для " +
                            "завершения программы . . . ");
            Console.Read();
        }
    }
}