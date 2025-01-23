


class DocentePorHora : Empleado
    {
        public int HorasTrabajadas { get; set; }
        private const double TarifaPorHora = 800;

        public DocentePorHora(string nombre, int horasTrabajadas) : base(nombre, true) 
        {
            HorasTrabajadas = horasTrabajadas;
        }

        public override double CalcularSalario()
        {
            return HorasTrabajadas * TarifaPorHora;
        }
    }

