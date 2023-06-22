#nullable disable

using ATMapp;

public class Program
{
  private static readonly List<CardHolder> cardHolders = new List<CardHolder>
        {
            new CardHolder("1111222233334444", 1234, "John", "Doe", 5000.00),
            new CardHolder("5555666677778888", 5678, "Jane", "Smith", 8000.00),
            new CardHolder("9999000011112222", 9012, "Michael", "Johnson", 12000.00),
            new CardHolder("3333444455556666", 3456, "Emily", "Davis", 3000.00),
            new CardHolder("7777888899990000", 7890, "David", "Anderson", 15000.00),
            new CardHolder("1234123412341234", 5678, "Sarah", "Wilson", 1000.00)
        };

  private static CardHolder currentUser;

  public static void Main(string[] args)
  {
    Console.WriteLine("Welcome to ConsoleATM");
    Console.WriteLine("Please insert your debit card:");
    string debitCardNum = GetValidDebitCardNumber();

    Console.WriteLine("Please enter your PIN:");
    int userPin = GetValidPin();

    currentUser = cardHolders.FirstOrDefault(a => a.CardNum == debitCardNum && a.Pin == userPin);

    if (currentUser != null)
    {
      Console.WriteLine("Welcome, " + currentUser.FirstName + " :)");
      BankAccount account = new BankAccount(currentUser);
      int option;

      do
      {
        PrintOptions();
        option = GetValidOption();

        switch (option)
        {
          case 1:
            account.Deposit();
            break;
          case 2:
            account.Withdraw();
            break;
          case 3:
            account.Balance();
            break;
          case 4:
            break;
          default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
        }
      } while (option != 4);

      Console.WriteLine("Thank you! Have a nice day :)");
    }
    else
    {
      Console.WriteLine("Card not recognized. Exiting...");
    }
  }

  private static string GetValidDebitCardNumber()
  {
    string debitCardNum;

    while (true)
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

    return debitCardNum;
  }

  private static int GetValidPin()
  {
    int userPin;

    while (true)
    {
      try
      {
        userPin = int.Parse(Console.ReadLine());

        if (currentUser != null && currentUser.Pin == userPin)
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

    return userPin;
  }

  private static int GetValidOption()
  {
    int option;

    while (true)
    {
      try
      {
        option = int.Parse(Console.ReadLine());

        if (option >= 1 && option <= 4)
        {
          break;
        }
        else
        {
          Console.WriteLine("Invalid option. Please try again.");
        }
      }
      catch
      {
        Console.WriteLine("Invalid option. Please try again.");
      }
    }

    return option;
  }

  private static void PrintOptions()
  {
    Console.WriteLine("Please Choose One Of The Following Options...");
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Balance");
    Console.WriteLine("4. Exit");
  }
}
