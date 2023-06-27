using HRapp;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Manager);

george.DisplayEmployeeDetails();

george.PerformWork();
george.PerformWork(5);
george.PerformWork();

double receivedWageGeorge = george.ReceiveWage(true);
Console.WriteLine($"Wage paid: {receivedWageGeorge}");

WorkTask task;
task.description = "Bake delicious pies";
task.hours = 3;
task.PerformWorkTask();
