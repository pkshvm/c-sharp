// BuildASentence - данная программа конструирует 
// предложение путем конкатенации пользовательского ввода 
// до тех пор, пока пользователь не введет команду 
// завершения . Эта программа демонстрирует использование 
// проверки равенства строк 
using System;
namespace BuildASentence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Каждая введённая вами строка " +
              "будет добавляться в предложение, " +
              "пока вы не введете EXIT или QUIT");
            // Запрашиваем пользовательский ввод и соединяем
            // вводимые пользователем фразы в единое целое, пока
            // не будет введена команда завершения работы
            string sentence = "";
            for (;;)
            {
                // Получение очередной строки 
                Console.WriteLine("Bвeдитe строку");
                string line = Console.ReadLine();
                // Выход при вводе команды завершения

                string[] terms = { "EXIT", "exit", "QUIT", "quit" };
                // Сравниваем введенную строку с командами вывода
                bool quitting = false;
                foreach (string term in terms)
                {
                    // Прекращение цикла при совпадении
                    if (String.Compare(line, term) == 0)
                    {
                        quitting = true;
                    }
                }
                    if (quitting == true)
                    {
                        break;
                    }

                    // В противном случае добавление введенного к строке
                    sentence = String.Concat(sentence, line);
                    // Обратная связь 
                    Console.WriteLine("\nBы ввели: " + sentence);
                
            }
                Console.WriteLine("\nПолучилось:\n" + sentence);
                // Ожидаем подтверждения пользователя
                Console.WriteLine("Haжмитe <Enter> для " +
                "завершения программы...");
                Console.Read();
            
        }
    }
}