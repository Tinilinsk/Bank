using System;

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
            string text = $@"Hello {Person2.getName()}, Balance: {Person2.getBalance()}";
            Console.WriteLine(text);
        }
    }
}
