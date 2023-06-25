using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Program
    {
        string cardNum;
        int pin;
        string firstName;
        string lastName;
        double balance;

        public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string GetNum()
        {
            return cardNum;
        }

        public int GetPin()
        {
            return pin;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void SetNum(string newCardNum)
        {
            cardNum = newCardNum;
        }

        public void SetPin(int newPin)
        {
            pin = newPin;
        }

        public void SetFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        public void SetLastName(string newLastName)
        {
            lastName = newLastName;
        }


        public void SetBalance(int newBalance)
        {
            balance = newBalance;
        }

        public static void Main(String[] args)
        {
            void printOptions()
            {
                Console.WriteLine("Please choose from the following options:");
                Console.WriteLine("1: Show Balance");
                Console.WriteLine("2: Deposit");
                Console.WriteLine("3: Withdraw");
                Console.WriteLine("4: Exit");


            }

        }

    }
}
