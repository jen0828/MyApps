namespace HRapp.HR
{
  internal class Employee
  {
    public string firstName;
    public string lastName;
    public string email;

    public int numberOfHoursWorked;
    public double wage;
    public double hourlyRate;

    public EmployeeType employeeType;

    public DateTime birthDay;

    const int minimalHoursWorkedUnit = 1;

    //Constructors

    //Constructor overloading
    public Employee(string first, string last, string em, DateTime bd, double rate, EmployeeType empType)
    {
      firstName = first;
      lastName = last;
      email = em;
      birthDay = bd;
      hourlyRate = rate;
      employeeType = empType;
    }

    public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0, EmployeeType.StoreManager)
    {
    }

    public void DisplayEmployeeDetails()
    {
      Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthDay.ToShortDateString()}\n");
    }

    public void PerformWork()
    {
      PerformWork(minimalHoursWorkedUnit);
    }

    public void PerformWork(int numberOfHours)
    {
      numberOfHoursWorked += numberOfHours;
      Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour");
    }

    public double ReceiveWage(bool resetHours = true)
    {
      wage = numberOfHoursWorked * hourlyRate;

      Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

      if (resetHours)
        numberOfHoursWorked = 0;

      return wage;
    }
  }
}
