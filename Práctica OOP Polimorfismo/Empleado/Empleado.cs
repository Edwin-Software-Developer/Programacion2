using System;

    abstract class Empleado
    {
        public string Nombre { get; set; }
        public bool MetaAlcanzada { get; set; }

        public Empleado(string nombre, bool metaAlcanzada)
        {
            Nombre = nombre;
            MetaAlcanzada = metaAlcanzada;
        }

        
        public abstract double CalcularSalario();
    

    }
  