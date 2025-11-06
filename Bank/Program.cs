using System;
using System.Reflection.Metadata;

namespace Bank
{
    class Program
    {
        public static void Main(string[] args)
        {
            BankAccount Person1 = new BankAccount("12344321", "Artsiom", 1000);
            BankAccount Person2 = new BankAccount("12387983", "Igor", 100000);

            List<BankAccount> Users = new List<BankAccount>();
            Users.Add(Person1);
            Users.Add(Person2);
            string text = $@"Hello {Person2._name}, Balance: {Person2._balance}";
            Console.WriteLine(text);
            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) View all users");
                Console.WriteLine("2) Transfer money");
                Console.WriteLine("3) View my account");
                Console.WriteLine("4) Deposit");
                Console.WriteLine("5) Withdraw");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        foreach (BankAccount user in Users)
                        {
                            Console.WriteLine(user._name);
                        };
                        break;
                    case "2":
                        Console.WriteLine("Choose options:");
                        Console.WriteLine($"1) Transfer to {Person1._name}");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            Console.WriteLine("Enter amount:");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            if (amount > Person2._balance)
                            {
                                Console.WriteLine("Not enough balance");
                            }
                            else
                            {
                                Person2.Withdraw(amount);
                                Person1.Deposit(amount);
                                Console.WriteLine($"Transfered {amount} to {Person1._name}");
                            }
                        }
                        break;
                    case "3":
                        Person2.GetAccountInfo();
                        break;
                    case "4":
                        Console.WriteLine("Enter amount to deposit:");
                        int depositAmount = Convert.ToInt32(Console.ReadLine());
                        Person2.Deposit(depositAmount);
                        Console.WriteLine($"Deposited {depositAmount}");
                        break;
                    case "5":
                        Console.WriteLine("Enter amount to withdraw:");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        if (withdrawAmount > Person2._balance)
                        {
                            Console.WriteLine("Not enough balance");
                        }
                        else
                        {
                            Person2.Withdraw(withdrawAmount);
                            Console.WriteLine($"Withdrew {withdrawAmount}");
                        }
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
