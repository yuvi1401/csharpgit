using System;
// class Inheritance 

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

// polymorphism

    public class CompanyEmployee
{
    public string EmployeeFirstName = "FN";
    public string EmployeeLastName = "LN";

    public virtual void PrintEmployeeName()
    {
        Console.WriteLine(EmployeeFirstName + " " + EmployeeLastName);
    }
}

public class CompanyFullTimeEmployee : CompanyEmployee
{
    public override void PrintEmployeeName()
    {
        Console.WriteLine(EmployeeFirstName + " " + EmployeeLastName + " - FTime");
    }

}

public class CompanyPartTimeEmployee : CompanyEmployee
{
    public override void PrintEmployeeName()
    {
        Console.WriteLine(EmployeeFirstName + " " + EmployeeLastName + " - PTime");
    }
}



public class Program
{
    public static void Main()
    {
        //class Inheritance
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

        //polymorphism

        CompanyEmployee[] employee = new CompanyEmployee[3];

        employee[0] = new CompanyEmployee();

        employee[1] = new CompanyFullTimeEmployee();
        employee[2] = new CompanyPartTimeEmployee();

        foreach (CompanyEmployee e in employee)
        {
            e.PrintEmployeeName();
        }
    }
}
