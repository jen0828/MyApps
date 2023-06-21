#nullable disable

namespace MyTinyBank;

public class BankAccount
{
  public string Number { get; }
  public string Owner { get; set; }
  public decimal Balance
{
    get
    {
        decimal balance = 0;
        foreach (var item in allTransactions)
        {
            balance += item.Amount;
        }

        return balance;
    }
}

  private static int accountNumberSeed = 1234567890;
  private List<Transaction> allTransactions = new List<Transaction>();

  public BankAccount(string name, decimal initialBalance)
  {
    Number = accountNumberSeed.ToString();
    accountNumberSeed++;

    Owner = name;
  }

  public void MakeDeposit(decimal amount, DateTime date, string note)
  {
  }

  public void MakeWithdrawal(decimal amount, DateTime date, string note)
  {
  }
}