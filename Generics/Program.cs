using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        //Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
        //Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета.
        //Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
        //Создать  несколько экземпляров класса, параметризированного различными типам.
        //Заполнить его поля и вывести информацию об экземпляре класса на печать.
        static void Main(string[] args)
        {
            Bank_account<int> account1 = new Bank_account<int>();
            Console.WriteLine("Введите Ваше фамилию, имя и отчество через Enter:");
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string otchestvo = Console.ReadLine();
            Random rand = new Random();
            int number = rand.Next(0, 999999999);
            Console.WriteLine($"Ваш номер счета:{number}");
            Console.WriteLine($"Баланс = {account1.Balance}");
            Console.WriteLine("На какую сумму пополнить баланс?");
            uint balance = Convert.ToUInt32(Console.ReadLine());
            account1.Startup(name, surname, otchestvo, number, balance);
            Console.WriteLine(account1.Read());
            Console.WriteLine();
            Bank_account<string> account2 = new Bank_account<string>();
            Console.WriteLine("Введите Ваше фамилию, имя и отчество через Enter:");
            name = Console.ReadLine();
            surname = Console.ReadLine();
            otchestvo = Console.ReadLine();
            string number1 = account2.RandomString(10);
            Console.WriteLine($"Ваш номер счета:{number1}");
            Console.WriteLine($"Баланс = {account2.Balance}");
            Console.WriteLine("На какую сумму пополнить баланс?");
            balance = Convert.ToUInt32(Console.ReadLine());
            account2.Startup(name, surname, otchestvo, number1, balance);
            Console.WriteLine(account2.Read());
            Console.ReadKey();

        }
    }
}
