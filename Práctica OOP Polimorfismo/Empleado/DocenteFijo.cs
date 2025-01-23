

  class DocenteFijo : Empleado
    {
        public double SalarioBase { get; set; }

        public DocenteFijo(string nombre, double salarioBase, bool metaAlcanzada) : base(nombre, metaAlcanzada)
        {
            SalarioBase = salarioBase;
        }

        public override double CalcularSalario()
        {
            return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
        }
    }

