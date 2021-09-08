// CalculateinterestWithEmЬeddedTest 
// Вычисление величины начисленных процентов для данного 
//вклада. Если процентная ставка или вклад отрицательный,
// генерируется сообщение об ошибке и вычесления не 
// вьmолняются. 
using System;
namespace CalculateinterestWithEmЬeddedTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Определяем максимально возможное значение
            // процентной ставки
            int maximuminterest = 50;
            // Приглашение пользователю ввести величину исходного
            // вклада
            Console.Write("B вeдитe сумму вклада: ");
            string principalInput = Console.ReadLine();
            decimal principal = Convert.ToDecimal(principalInput);
            // Если исходньм вклад отрицателен. . .
            if (principal < 0)
            {
                // . . .генерируем сообщение об ошибке. . .
                Console.WriteLine("Bклaд не может быть отрицательным");
            }
            else
            // Сюда попадаем, только если principal >= О
            {
                // . . .в противном случае просим ввести процентную
                // ставку
                Console.Write("Bвeдитe процентную ставку: ");
                string interestInput = Console.ReadLine();
                decimal interest = Convert.ToDecimal(interestInput);
                // Если процентная ставка отрицательна или слишком
                // велика. . .
                if (interest < 0 || interest > maximuminterest)
                {
                    // . . .генерируем сообщение об ошибке
                    Console.WriteLine("Пpoцeнтнaя ставка не может " +
                        "быть отрицательной " +
                        "или превышать "
                        + maximuminterest);
                    interest = 0;
                }
                else
                // Сюда мы попадаем, только если все в порядке
                {
                    // И величина вклада, и процентная ставка
                    // корректны - можно приступить к вычислению
                    // вклада с начисленными процентами
                    decimal interestPaid;
                    interestPaid = principal * (interest / 100);

                    // Вычисляем общую сумму
                    decimal total = principal + interestPaid;

                    // Выводим результат
                    Console.WriteLine(); // skip а line
                    Console.WriteLine("Bклaд = " + principal);
                    Console.WriteLine("Пpoцeнты = "
                    + interest + " % ");
                    Console.WriteLine();
                    Console.WriteLine("Haчиcлeнныe проценты = "
                    + interestPaid);
                    Console.WriteLine("Общая сумма " + total);
                    // Ожидаем подтверждения пользователя 
                    Console.WriteLine("Haжмитe <Enter> для" +
                    " завершения программы . . . ");
                    Console.Read();
                }
            }
        }
    }
}

                   