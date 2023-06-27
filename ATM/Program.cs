using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    decimal balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, decimal balance)
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
            Console.WriteLine();
        }

        void Deposit(cardHolder CurrentUser)
        {
            Console.WriteLine("Depositing");
            Console.WriteLine("**************");
            Console.WriteLine("How much would you like to deposit? ");
            decimal deposit = Decimal.Parse(Console.ReadLine());
            CurrentUser.SetBalance(deposit + CurrentUser.GetBalance());
        }

        void Withdraw(cardHolder CurrentUser)
        {
            Console.WriteLine("Withdrawing");
            Console.WriteLine("**************");
            Console.WriteLine("How much would you like to withdraw? ");
            decimal withdraw = Decimal.Parse(Console.ReadLine());
            if (CurrentUser.GetBalance() < withdraw)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                CurrentUser.SetBalance(CurrentUser.GetBalance() - withdraw);
                Console.WriteLine($"You've successfully withdrawn: {withdraw}, New Balance is: {CurrentUser.GetBalance()}");
            }
        }

        void Balance(cardHolder CurrentUser)
        {
            Console.WriteLine("Current Balance: " + CurrentUser.GetBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("4003830171874018", 5456, "Anne", "Jessop", 1000m));
        cardHolders.Add(new cardHolder("8936474640510142", 7216, "Terry", "Banks", 62.34m));
        cardHolders.Add(new cardHolder("6013585142342681", 4563, "Sean", "Deacon", 5478.87m));
        cardHolders.Add(new cardHolder("0730898193825365", 2488, "Ben", "King", 780.55m));

        //Prompt 
        Console.WriteLine("Welcome to the SimpleATM");
        Console.WriteLine("Please enter your debit card number:");
        string debitCardNum;
        int userPin;
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                //check against the database for the debit card number
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Card is not recognised. Please try again.");
                }
            }
            catch
            {
                Console.WriteLine("Card is not recognised. Please try again.");

            }
        }

        Console.WriteLine("Please enter your pin: ");
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                //check for a matching pin
                if (currentUser.GetPin() == userPin)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Pin, Please try again");
                }
            }
            catch
            {
                Console.WriteLine("Incorrect Pin, Please try again");

            }

        }

        Console.WriteLine("Welcome " + currentUser.GetFirstName() + " " + currentUser.GetLastName());
        int option = 0;

        do
        {
            printOptions();
            while (true)
            {
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Balance(currentUser);
                        break;
                    case 2:
                        Deposit(currentUser);
                        break;
                    case 3:
                        Withdraw(currentUser);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the Simple ATM, Have a great day!");
                        break;
                }
                }
            }
        }

    }

}


