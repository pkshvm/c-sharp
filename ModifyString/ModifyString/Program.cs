using System;

namespace ModifyString
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Создаём объек Student
            Student s1 = new Student();
            s1.Name = "Jenny";
            // Создаём новый объект с тем же именем
            Student s2 = new Student();
            s2.Name = s1.Name;
            // "Изменение"  имени  объекта  sl  не  изменяет  сам 
            // объект, поскольку ToUpper() возвращает новую
            // строку, не влияя на оригинал s2 
            s2.Name = s1.Name.ToUpper();
            Console.WriteLine("s1 - " + s1.Name +
                                ", s2 - " + s2.Name);

            // Ожидаем подтверждения пользователя Console
            Console.WriteLine("нажмите <Enter> для " +
                                "завершения програмы...");
            Console.Read();
        }
    }
    //   Student  - простейший класс, содержащий  строку
    class Student
    {
        public String Name;
    }

}