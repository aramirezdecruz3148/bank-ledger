using System;

namespace bank_ledger {
    public class User {
        public string Username { get; private set; }
        public string Nickname { get; private set; }
        public int PinNumber { get; private set; }
        public decimal InitialBalance { get; private set; }
        public void CreateUser() {
            Console.WriteLine("To begin banking please create an account...");
            Console.WriteLine("Enter a username: ");
            Username = Console.ReadLine();
            Console.WriteLine("Enter a 4 digit pin number: ");
            PinNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your initial deposit amount for your new account: ");
            InitialBalance = Decimal.Parse(Console.ReadLine());
            Console.Clear();
        }
    }
    class Program {
        static void Main(string[] args) {
        }
    }
}
