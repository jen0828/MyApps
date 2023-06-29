// namespace HRapp.Tests;

// public class UnitTest1
// {
//     [Fact]
//     public void Test1()
//     {

//     }
// }

using HRapp.HR;

namespace HRapp.Tests
{
  public class EmployeeTests
  {
    [Fact]
    public void PerformWork_Adds_NumberOfHours()
    {
      //Arrange
      Employee employee = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

      int numberOfHours = 3;
      //Act
      employee.PerformWork(numberOfHours);

      //Assert
      Assert.Equal(numberOfHours, employee.NumberOfHoursWorked);
    }

    [Fact]
    public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified()
    {
      Employee employee = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

      employee.PerformWork();

      Assert.Equal(1, employee.NumberOfHoursWorked);
    }
  }
}
