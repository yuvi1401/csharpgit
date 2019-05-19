using System;

public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;
    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}

public class PartTimeEmployee : Employee
{
    public float HourlySalary;
}

public class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Yuvi";
        FTE.LastName = "cad";
        FTE.YearlySalary = 30000;
        FTE.PrintFullName();
        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Jack";
        PTE.LastName = "Cloud";
        PTE.HourlySalary = 300;
        PTE.PrintFullName();
    }
}
