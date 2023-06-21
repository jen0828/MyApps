
using ATMapp;

public class Program
{
  static void Main(string[] args)
  {
    List<CardHolder> cardHolders = new List<CardHolder>
            {
                new CardHolder("1111222233334444", 1234, "John", "Doe", 5000.00),
                new CardHolder("5555666677778888", 5678, "Jane", "Smith", 8000.00),
                new CardHolder("9999000011112222", 9012, "Michael", "Johnson", 12000.00),
                new CardHolder("3333444455556666", 3456, "Emily", "Davis", 3000.00),
                new CardHolder("7777888899990000", 7890, "David", "Anderson", 15000.00),
                new CardHolder("1234123412341234", 5678, "Sarah", "Wilson", 1000.00)
            };

    Console.WriteLine("Welcome to ConsoleATM");
    Console.WriteLine("Please insert your debit card:");
    string debitCardNum = "";
    CardHolder currentUser;

    while (true)
    {
      try
      {
        debitCardNum = Console.ReadLine();
        currentUser = cardHolders.FirstOrDefault(a => a.CardNum == debitCardNum);
        if (currentUser != null)
        {
          break;
        }
        else
        {
          Console.WriteLine("Card not recognized. Please try again.");
        }
      }
      catch
      {
        Console.WriteLine("Card not recognized. Please try again.");
      }
    }

    Console.WriteLine("Please enter your PIN:");
    int userPin = 0;
    while (true)
    {
      try
      {
        userPin = int.Parse(Console.ReadLine());
        if (currentUser.Pin == userPin)
        {
          break;
        }
        else
        {
          Console.WriteLine("Incorrect PIN. Please try again.");
        }
      }
      catch
      {
        Console.WriteLine("Incorrect PIN. Please try again.");
      }
    }
    Console.WriteLine("Welcome, " + currentUser.FirstName + " :)");
    BankAccount account = new BankAccount(currentUser);
    int option = 0;

    do
    {
      PrintOptions();
      try
      {
        option = int.Parse(Console.ReadLine());
      }
      catch
      {
        option = 0;
      }

      if (option == 1)
      {
        account.Deposit();
      }
      else if (option == 2)
      {
        account.Withdraw();
      }
      else if (option == 3)
      {
        account.Balance();
      }
      else if (option == 4)
      {
        break;
      }
      else
      {
        option = 0;
      }
    }
    while (option != 4);

    Console.WriteLine("Thank you! Have a nice day :)");
  }

  static void PrintOptions()
  {
    Console.WriteLine("Please Choose One Of The Following Options...");
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Balance");
    Console.WriteLine("4. Exit");
  }

}