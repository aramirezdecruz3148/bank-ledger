﻿using System;

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
        public void SigninUser() {
            Console.WriteLine("Welcome to deCruz Bank, to sign-in, please enter your username: ");
            var enteredName = Console.ReadLine();
            Console.WriteLine("Please enter your pin number: ");
            string pass = "";
            ConsoleKeyInfo enteredPin;
            do {
                enteredPin = Console.ReadKey(true);
                pass += enteredPin.KeyChar;
                Console.Write("*");
            } while (enteredPin.Key != ConsoleKey.Enter);
            //will need to add logic here to ensure username and password match created user
            //once I have employed my file-writing database
            Console.WriteLine("Welcome back, {0}", Username);
        }
        public void CheckBalance() {
            Console.WriteLine("The balance for {0}, is ${1}", Username, InitialBalance);
        }
        public void Deposit() {
            Console.WriteLine("Please enter the amount you wish to deposit: ");
            var deposit = Decimal.Parse(Console.ReadLine());
            InitialBalance += deposit;
            Console.WriteLine("Thank you, after your deposit you have ${0} in your account.", InitialBalance);
        }
        public void Withdrawl() {
            Console.WriteLine("Please enter the amount you would like to withdraw: ");
            var withdrawl = Decimal.Parse(Console.ReadLine());
            if(withdrawl > InitialBalance) {
                Console.WriteLine("I'm sorry, you have insufficient funds for that transaction.");
            } else {
                InitialBalance -= withdrawl;
                Console.WriteLine("Thank you, after your withdrawl you have ${0} in your account.", InitialBalance);
            }
        }
        public void SignOut() {
            Console.WriteLine("Thank you for choosing deCruz Bank, we hope to see you soon!");
        }
    }
    public class EntryMenu {
        User user = new User();
    }
    class Program {
        static void Main(string[] args) {
        }
    }
}
