using System;
using System.Reflection.Metadata;

namespace Bank
{
    class Program
    {
        public static void Main(string[] args)
        {
            Konto Person1 = new Konto("12344321", "Artsiom", 1000);
            Konto Person2 = new Konto("12387983", "Igor", 100000);

            List<Konto> Users = new List<Konto>();
            Users.Add(Person1);
            Users.Add(Person2);
            string text = $@"Hello {Person2.getName()}, Balance: {Person2.getBalance()}";
            Console.WriteLine(text);
            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) View all users");
                Console.WriteLine("2) Transfer money");
                Console.WriteLine("3) View my account");
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
                        Console.WriteLine($"1) Transfer to {Person1.getName()}");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            Console.WriteLine("Enter amount:");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            if (amount > Person2.getBalance())
                            {
                                Console.WriteLine("Not enough balance");
                            }
                            else
                            {
                                Person2.setBalance(Person2.getBalance() - amount);
                                Person1.setBalance(Person1.getBalance() + amount);
                                Console.WriteLine($"Transfered {amount} to {Person1.getName()}");
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine($"Name: {Person2.getName()}, Balance: {Person2.getBalance()}, ID:{Person2.getId()}");
                        break;
                    default:
                        Console.WriteLine(text);
                        break;
                }
                
            }
            while (true);
        }
    }
}
