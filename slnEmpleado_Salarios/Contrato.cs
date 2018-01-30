using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnEmpleado_Salarios
{

    class Contrato : Empleado
    {
        private int horasPorMes { get; set; }
        private double precioPorHora { get; set; }

        public override string TipoSalario
        {
            get
            {
                return "Contrato";
            }
        }

        public Contrato(int horas, double precio)
        {
            this.horasPorMes = horas;
            this.precioPorHora = precio;
        }

        public override double CalcularSalarioMensual()
        {
            return horasPorMes * precioPorHora;
        }

        public override double CalcularSalarioQuisenal()
        {
            return (horasPorMes * precioPorHora) / 2;
        }

        public override double CalcularSalarioSemanal()
        {
            return (horasPorMes * precioPorHora) / 4;
        }
    }
}
