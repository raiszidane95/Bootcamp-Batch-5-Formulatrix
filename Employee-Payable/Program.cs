using Employee_Payable;
public class Program
{
    public static void Main()
    {
        Invoice item1 = new Invoice();
        item1.partNumber = "INV2023001";
        item1.partDescription = "Office Desk";
        item1.quantity = 5;
        item1.pricePerItem = 500000.0F;

        HourlyEmployee employee1 = new HourlyEmployee();
        employee1.firstName = "alucard";
        employee1.lastName = "junaidi";
        employee1.socialSecurityNumber = "A01";
        employee1.wage = 4000000F;

        HourlyEmployee employee2 = new HourlyEmployee();
        employee2.firstName = "Miya";
        employee2.lastName = "Sari";
        employee2.socialSecurityNumber = "A02";
        employee2.wage = 3500000F;

        SalariedEmployee employee3 = new SalariedEmployee();
        employee3.firstName = "Chou";
        employee3.lastName = "Siregar";
        employee3.socialSecurityNumber = "A03";
        employee3.weeklySalary = 700000F;

        CommisionEmployee commisionEmployee1 = new CommisionEmployee();
        commisionEmployee1.grossSales = 20.0F;
        commisionEmployee1.commisionRate = 10.0F;


        Console.WriteLine($"Employee Information\n");

        Console.WriteLine($"Employee list");
        Console.WriteLine($"Name : {employee1.firstName} {employee1.lastName}");
        Console.WriteLine($"Empoyee ID : {employee1.socialSecurityNumber}");
        Console.WriteLine($"Salary : {employee1.wage} \n");

        Console.WriteLine($"Name : {employee2.firstName} {employee2.lastName}");
        Console.WriteLine($"Empoyee ID : {employee2.socialSecurityNumber}");
        Console.WriteLine($"Salary : {employee2.wage} \n");

        Console.WriteLine($"Name : {employee3.firstName} {employee3.lastName}");
        Console.WriteLine($"Empoyee ID : {employee3.socialSecurityNumber}");
        Console.WriteLine($"Salary : {employee3.weeklySalary} \n");

    }
}