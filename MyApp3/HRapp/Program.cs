﻿using HRapp.HR;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

// Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Manager);

// george.DisplayEmployeeDetails();

// george.PerformWork();
// george.PerformWork(5);
// george.PerformWork();

// Employee jake = new Employee("Jake", "Nicols", "jake@snowball.be", new DateTime(1995, 8, 16), 25, "New street", "123", "123456", "Pie Ville");
// string streetName = jake.Address.Street;
// Console.WriteLine($"{jake.FirstName} lives on {jake.Address.Street}");

// Address newAddress = new Address("Another street", "444", "999999", "Donut town");
// jake.Address = newAddress;
// Console.WriteLine($"{jake.FirstName} moved to {jake.Address.Street} in {jake.Address.City}");

// Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
// Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);

// bethany.DisplayEmployeeDetails();
// bethany.PerformWork();
// bethany.PerformWork(5);
// bethany.PerformWork();
// bethany.ReceiveWage();

// mary.DisplayEmployeeDetails();
// mary.PerformWork();
// mary.PerformWork(11);
// mary.PerformWork();
// mary.ReceiveWage();

// mary.AttendManagementMeeting();


IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
IEmployee mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
IEmployee kevin = new StoreManager("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
IEmployee kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);

List<IEmployee> employees = new List<IEmployee>();
employees.Add(bethany);
employees.Add(mary);
employees.Add(kevin);
employees.Add(kate);

foreach (var employee in employees)
{
  employee.PerformWork();
  employee.ReceiveWage();
  employee.DisplayEmployeeDetails();
  employee.GiveBonus();
  //employee.AttendManagementMeeting();
}

Console.ReadLine();