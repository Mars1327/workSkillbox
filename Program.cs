using System;
using System.Text;
using System.Collections;



namespace homeWorkC_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Sinitsyn Anatoliy Aleksandrovich";
            byte age = 40;
            string email = "sin1094606@yandex.ru";
            byte scoreProgram = 87;
            byte scoreMathem = 92;
            byte scorePhysics = 82;

            string pattern = "ФИО: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5} ";
            Console.WriteLine(pattern,
                              fullName,
                              age,
                              email,
                              scoreProgram,
                              scoreMathem,
                              scorePhysics);

            Console.ReadLine();

            int sumAllScore = scoreProgram + scoreMathem + scorePhysics;
            double averageScore = sumAllScore / 3;

            Console.WriteLine($"Сумма баллов: {sumAllScore} \nСредний балл: {averageScore}");
            
            Console.ReadLine();

        }

    }
}
