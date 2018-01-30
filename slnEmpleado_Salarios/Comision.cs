using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnEmpleado_Salarios
{
    class Comision : Empleado
    {
        private int porcentajeComisicon { get; set; }
        private double ventasPorMes { get; set; }

        public override string TipoSalario
        {
            get
            {
                return "Comision";
            }
        }

        public Comision(int porcentaje, double ventas)
        {
            this.porcentajeComisicon = porcentaje;
            this.ventasPorMes = ventas;
        }

        public override double CalcularSalarioMensual()
        {
            return ventasPorMes * porcentajeComisicon;
        }

        public override double CalcularSalarioQuisenal()
        {
            return (ventasPorMes * porcentajeComisicon)/2;
        }

        public override double CalcularSalarioSemanal()
        {
            return (ventasPorMes * porcentajeComisicon) / 4;
        }
    }
}
