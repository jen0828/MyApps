namespace ATMapp;

public class BankAccount
{
  private CardHolder currentUser;

  public BankAccount(CardHolder user)
  {
    currentUser = user;
  }

  public void Balance()
  {
    Console.WriteLine("Current balance: " + currentUser.Balance);
  }

  public void Deposit()
  {
    Console.WriteLine("How much money do you want to deposit?");
    double deposit = double.Parse(Console.ReadLine());
    currentUser.Balance += deposit;
    Console.WriteLine("Thank you for depositing your money. Your current balance is: " + currentUser.Balance);
  }

  public void Withdraw()
  {
    Console.WriteLine("How much money do you want to withdraw?");
    double withdrawal = double.Parse(Console.ReadLine());
    if (withdrawal > currentUser.Balance)
    {
      Console.WriteLine("Insufficient balance :(");
    }
    else
    {
      currentUser.Balance -= withdrawal;
      Console.WriteLine("You're good to go! Thank you :)");
    }
  }


}