using System;
using System.Reflection.Metadata;

namespace Bank
{
    class Program
    {
        public static void Main(string[] args)
        {
            Konto Person1 = new Konto("12344321", "Artsiom", 100000);
            Konto Person2 = new Konto("12387983", "Igor", 1000);

            List<Konto> Users = new List<Konto>();
            Users.Add(Person1);
            Users.Add(Person2);
            string text = $@"Hello {Person2.getName()}, Balance: {Person2.getBalance()}
1)Users
2)Transfer";
            Console.WriteLine(text);
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    foreach (Konto user in Users)
                    {
                        Console.WriteLine(user.getName());
                    };
                    break;
                case "2":
                    Console.WriteLine("Choose options:");

                    break;
                default:
                    Console.WriteLine(text);
                    break;
            }
        }
    }
}
