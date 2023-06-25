using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    decimal balance;

    public CardHolder(string cardNum, int pin, string firstName, string lastName, decimal balance)
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

    public decimal GetBalance()
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


    public void SetBalance(decimal newBalance)
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

        void Deposit(CardHolder CurrentUser)
        {
            Console.WriteLine("Depositing");
            Console.WriteLine("**************");
            Console.WriteLine("How much would you like to deposit? ");
            decimal deposit = Decimal.Parse(Console.ReadLine());
            CurrentUser.SetBalance(deposit + CurrentUser.GetBalance());
        }

        void Withdraw(CardHolder CurrentUser)
        {
            Console.WriteLine("Withdrawing");
            Console.WriteLine("**************");
            Console.WriteLine("How much would you like to withdraw? ");
            decimal withdraw = Decimal.Parse(Console.ReadLine());
            if(CurrentUser.GetBalance() > withdraw)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                CurrentUser.SetBalance(CurrentUser.GetBalance() - withdraw);
                Console.WriteLine($"You've successfully withdrawn: {withdraw}, New Balance is: {CurrentUser.GetBalance()}");
            }    
        }

        void balance(CardHolder currentUser)
        {
            Console.WriteLine("Current Balance: " + currentUser.GetBalance());
        }
    }

}
