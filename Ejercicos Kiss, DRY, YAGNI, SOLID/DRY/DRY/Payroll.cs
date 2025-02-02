namespace DRY
{
public class Payroll
{
    public decimal CalculateSalary(decimal baseSalary, int employeeType, int hoursWorked = 0)
    {
        decimal tax = baseSalary * 0.18m;
        decimal bonus = baseSalary * 0.05m;

        if (employeeType == 1) // Tiempo completo
        {
            return baseSalary - tax + bonus;
        }
        else if (employeeType == 2) // Medio tiempo
        {
            decimal hourlyRate = baseSalary / 160; // Suponiendo 160 horas mensuales
            decimal salary = hourlyRate * hoursWorked;
            return salary - (salary * 0.18m) + (salary * 0.05m);
        }
        else
        {
            throw new ArgumentException("Tipo de empleado inválido");
        }
    }
}

}
