using MyTinyBank;

var account = new BankAccount("Jenny", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");