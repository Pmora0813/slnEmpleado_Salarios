using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnEmpleado_Salarios
{
    class Asalariado : Empleado
    {

        public double salarioPorMes { get; set; }
        public Asalariado(double salario)
        {
            this.salarioPorMes = salario;
        }

        public override string TipoSalario
        {
            get
            {
                return "Asalariado";
            }
        }

        public override double CalcularSalarioMensual()
        {
            return salarioPorMes;
        }

        public override double CalcularSalarioQuisenal()
        {
            return salarioPorMes / 2;
        }

        public override double CalcularSalarioSemanal()
        {
            return salarioPorMes / 4;
        }

    }
}
