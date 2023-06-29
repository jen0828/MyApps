using HRapp.HR;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

// Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Manager);

// george.DisplayEmployeeDetails();

// george.PerformWork();
// george.PerformWork(5);
// george.PerformWork();

Employee jake = new Employee("Jake", "Nicols", "jake@snowball.be", new DateTime(1995, 8, 16), 25, "New street", "123", "123456", "Pie Ville");
string streetName = jake.Address.Street;
Console.WriteLine($"{jake.FirstName} lives on {jake.Address.Street}");

Address newAddress = new Address("Another street", "444", "999999", "Donut town");
jake.Address = newAddress;
Console.WriteLine($"{jake.FirstName} moved to {jake.Address.Street} in {jake.Address.City}");