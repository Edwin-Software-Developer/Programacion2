class Program
    {
        static void Main(string[] args)
        {
            
            Empleado docentePorHora = new DocentePorHora("María", 40); // 40 horas trabajadas
            Empleado docenteFijo = new DocenteFijo("Pedro", 30000, true); // Meta alcanzada
            Empleado empleadoAdministrativo = new EmpleadoAdministrativo("Ana", 25000, false); // Meta no alcanzada

           
            Console.WriteLine($"Docente por Hora - {docentePorHora.Nombre}: {docentePorHora.CalcularSalario()}");
            Console.WriteLine($"Docente Fijo - {docenteFijo.Nombre}: {docenteFijo.CalcularSalario()}");
            Console.WriteLine($"Empleado Administrativo - {empleadoAdministrativo.Nombre}: {empleadoAdministrativo.CalcularSalario()}");

            Console.ReadLine();
        }
    }

