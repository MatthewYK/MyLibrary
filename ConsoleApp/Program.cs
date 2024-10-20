using MyLibrary;

Secretary Maria = new Secretary();
Maria.Name = "Maria";
Manager Pedro = new Manager();
Maria.Name = "Pedro";
Employee Miguel = new Employee();

WriteEmployeeInfo(Maria);
WriteEmployeeInfo(Pedro);
WriteEmployeeInfo(Miguel);

void WriteEmployeeInfo(Employee employee)
{
    Console.WriteLine($"{employee.Name}: {employee.CalculateMonthlyPayment()}");
    Console.WriteLine($"Days{employee.GetPaymentDays()}");
}