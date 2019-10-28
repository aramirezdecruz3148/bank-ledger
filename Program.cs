using System;

namespace bank_ledger {
    public class User {
        public string Username { get; private set; }
        public string Nickname { get; private set; }
        public int PinNumber { get; private set; }
        public double InitialDeposit { get; private set; }
        public User(string username, string nickname, int pinNumber, double initialDeposit) {
            Username = username;
            Nickname = nickname;
            PinNumber = pinNumber;
            InitialDeposit = initialDeposit;
        }
        public void GreetingUser() {
            Console.WriteLine("Welcome to deCruz Bank, {0}!", Nickname);
        }
        
    }
    class Program {
        static void Main(string[] args) {
        User test = new User("aramirez", "alex", 1234, 500.00);
            Console.WriteLine("Hello World!");
            test.GreetingUser();
        }
    }
}
