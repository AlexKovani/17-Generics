using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Bank_account<T>
    {
        string name;
        public string Name { get; set; }
        string surname;
        public string Surname { get; set; }
        string otchestvo;
        public string Otchestvo { get; set; }
        T number;
        public T Number { get; set; }
        uint balance;
        public uint Balance { get; set; }

        public void Startup(string name, string surname, string otchestvo, T number, uint balance = 0)
        {
            Name = name;
            Surname = surname;
            Otchestvo = otchestvo;
            Number = number;
            Balance = balance;
        }

        public string Read()
        {
            return $"Клиент: {Name} {Surname} {Otchestvo}\r\nНомер счета:{Number}\r\nБаланс:{Balance}";
        }

     
        Random _random = new Random(); 
        public string RandomString(int length)
        {
            string chars = "0123456789abcdefghijklmnopqrstuvwxyz";
            StringBuilder builder = new StringBuilder(length);

            for (int i = 0; i < length; ++i)
                builder.Append(chars[_random.Next(chars.Length)]);


            return builder.ToString();
        }

    }
}
