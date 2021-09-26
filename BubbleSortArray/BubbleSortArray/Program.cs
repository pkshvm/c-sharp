// BubbleSortArray - сортирует список планет по именам :
// 1. В алфавитном порядке
// 2. По дпине имен от коротких к длинным
// 3. По дпине имен от длинных к коротким
// Использованы два алгоритма сортировки :
// 1. Алгоритм Sort использован методом Sort ()
// 2. Классический алгоритм пузырьковой сортировки
using System;
namespace BubbleSortArray
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("5 ближайших к Солнцу планет: ");
            string[] planets = new string[]
            {"Mercury", "Venus", "Earth", "Mars", "Jupiter"};
            // { "Меркурий", "Венера", "Земля",
            // "Марс ", "Юпитер" }
            foreach (string planet in planets)
            {
                // Символ \t вставляет табуляцию при выводе
                Console.WriteLine("\t" + planet);
            }

            Console.WriteLine("\nB алфавитном порядке: ");
            // Array.Sort () - метод класса Array
            // Array.Sort () работает в пределах массива, не
            // оставляя исходной копии. Решение состоит в
            // копировании старого массива и работе с копией
            string[] sortedNames = planets;
            Array.Sort(sortedNames);

            // Показываем, что sortedNames содержит те же
            // планеты, но отсортированные
            foreach (string planet in sortedNames)
            {
                Console.WriteLine("\t" + planet);
            }

            Console.WriteLine("\nCopтиpoвкa по дпине имени: ");
            // Алгоритм пузырьковой сортировки - самый простой и
            // неэффективньм. Метод Array.Sort () сушественно
            // эффективнее, но здесь он неприемпем, так как
            // сравниваются не строки, а их длины
            int outer; // Индекс внешнего цикла
            int inner; // Индекс внутреннего цикла
                       // Цикл от последнего индекса к первому
            for (outer = planets.Length - 1; outer >= 0; outer--)
            {
                // На каждом цикле проходим по всем элементам
                // ниже текушего . Этот цикл проходит в восходяшем
                // порядке . Цикл for позволяет обход в любом
                // направлении
                for (inner = 1; inner <= outer; inner++)
                {
                    // Сравниваем соседние элементы. Если ранний более
                    // длинный, обмениваем их местами
                    if (planets[inner - 1].Length > planets[inner].Length)
                    {
                        string temp = planets[inner - 1];
                        planets[inner - 1] = planets[inner];
                        planets[inner] = temp;
                    }
                }
            }
            foreach (string planet in planets)
            {
                Console.WriteLine("\t" + planet);
            }
            Console.WriteLine("\nB обратном порядке: ");
            // Цикл в обратном порядке
            for (int i = planets.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("\t" + planets[i]);
            }
            // Ожидаем подтверждения пользователя
            Console.WriteLine("Haжмитe <Enter> для завершения программы ... ");
            Console.Read();
        }
    }
}
