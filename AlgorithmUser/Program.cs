using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithm
{
    internal class Program
    {
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        static void Main(string[] args)
        {
            User[] userList = new User[] {
                new User { Login = "kapitane", Name = "Миша", IsPremium = false },
            new User { Login = "cat", Name = "Дина", IsPremium = true },
            new User { Login = "bumbum", Name = "Валя", IsPremium = false },
            new User { Login = "black", Name = "Сергей", IsPremium = true }};

            foreach (var user in userList)
            {
                Run(user);
            }
            Console.ReadKey();

        }

        public static void Run(User _user)
        {
            Console.WriteLine($"Пользователь: {_user.Login} - Hello: {_user.Name}! ");
            Thread.Sleep(1000);
            if (_user.IsPremium)
            {
                Console.WriteLine("У вас премиум подписка!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("У вас нет подписки!");
                ShowAds();
            }
            Console.WriteLine("");
            Thread.Sleep(1000);
        }
    }
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
}
