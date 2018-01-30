using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnEmpleado_Salarios
{
    abstract class Empleado
    {
        public int Edad { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Genero Genero { get; set; }
        public string Indentificacion { get; set; }
        public string Nombre { get; set; }

        public abstract string TipoSalario { get; }

        public Empleado()
        {

        }

        public abstract double CalcularSalarioMensual();
        public abstract double CalcularSalarioQuisenal();
        public abstract double CalcularSalarioSemanal();



    }
}
