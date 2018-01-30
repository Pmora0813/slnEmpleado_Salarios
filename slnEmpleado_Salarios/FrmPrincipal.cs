using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnEmpleado_Salarios
{
    public partial class FrmPrincipal : Form
    {

        private Empleado emp;
        List<Empleado> lista;
        public FrmPrincipal()
        {
            InitializeComponent();
            llenarTipoEmpleado();
            llenarEstadoCivil();
            lista = new List<Empleado>();
        }

        private void llenarEstadoCivil()
        {
            cmbEstadoCivil.Items.Add(EstadoCivil.Soltero);
            cmbEstadoCivil.Items.Add(EstadoCivil.Casado);
            cmbEstadoCivil.Items.Add(EstadoCivil.Divorciado);
            cmbEstadoCivil.Items.Add(EstadoCivil.Viudo);
        }

        private void llenarTipoEmpleado()
        {
            //Empleado[] empl = new Empleado[3];

            //empl[0] = new Asalariado(5000);
            //empl[0] = new Contrato(10,1000);
            //empl[0] = new Comision(13,5000000);

            //cmbTipoEmpleado.DataSource = empl;

            //cmbTipoEmpleado.DisplayMember = "TipoSalario";

            cmbTipoEmpleado.Items.Add("Asalariado");
            cmbTipoEmpleado.Items.Add("Comision");
            cmbTipoEmpleado.Items.Add("Contrato");




        }

        private void mostrarCampos()
        {
            if (cmbTipoEmpleado.SelectedIndex == 0)
            {
                lblSalPorMes.Visible = true;
                mskSalPorMes.Visible = true;
            }
            else
            {
                lblSalPorMes.Visible = false;
                mskSalPorMes.Visible = false;
            }

            if (cmbTipoEmpleado.SelectedIndex == 1)
            {
                lblVentasPorMes.Visible = true;
                lblPorcComicion.Visible = true;
                mskVentasporMes.Visible = true;
                mskPorcComision.Visible = true;
            }
            else
            {
                lblVentasPorMes.Visible = false;
                lblPorcComicion.Visible = false;
                mskVentasporMes.Visible = false;
                mskPorcComision.Visible = false;
            }

            if (cmbTipoEmpleado.SelectedIndex == 2)
            {
                lblHorasPormes.Visible = true;
                lblPrecioPorHora.Visible = true;
                mskHorasPorMes.Visible = true;
                mskPrecioPorHora.Visible = true;
            }
            else
            {
                lblHorasPormes.Visible = false;
                lblPrecioPorHora.Visible = false;
                mskHorasPorMes.Visible = false;
                mskPrecioPorHora.Visible = false;
            }

        }

        private void cmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            guardarEmpleados();

        }

        private void guardarEmpleados()
        {

            int mensual = 0;
            int quisena = 0;
            int semanal = 0;

            if (cmbTipoEmpleado.SelectedIndex == 0)
            {
                emp = new Asalariado(Convert.ToInt32(mskSalPorMes.Text));
                emp.Indentificacion = mskCedula.Text;
                emp.Nombre = txtNombre.Text;
                if (rbtnmasculino.Checked)
                {
                    emp.Genero = Genero.Masculino;
                }
                else
                {
                    if (rbtnFemenino.Checked)
                    {
                        emp.Genero = Genero.Femenino;
                    }
                }
                emp.EstadoCivil = (EstadoCivil)cmbEstadoCivil.SelectedItem;
                emp.Edad = calcularEdad();


                mensual = (int)emp.CalcularSalarioMensual();
                quisena = (int)emp.CalcularSalarioQuisenal();
                semanal = (int)emp.CalcularSalarioSemanal();
                lista.Add(emp);


            }
            else
            {
                if (cmbTipoEmpleado.SelectedIndex == 1)
                {
                    emp = new Comision(Convert.ToInt32(mskPorcComision.Text), Convert.ToInt32(mskVentasporMes.Text));
                    emp.Indentificacion = mskCedula.Text;
                    emp.Nombre = txtNombre.Text;
                    if (rbtnmasculino.Checked)
                    {
                        emp.Genero = Genero.Masculino;
                    }
                    else
                    {
                        if (rbtnFemenino.Checked)
                        {
                            emp.Genero = Genero.Femenino;
                        }
                    }
                    emp.EstadoCivil = (EstadoCivil)cmbEstadoCivil.SelectedItem;
                    emp.Edad = calcularEdad();


                    mensual = (int)emp.CalcularSalarioMensual();
                    quisena = (int)emp.CalcularSalarioQuisenal();
                    semanal = (int)emp.CalcularSalarioSemanal();
                    lista.Add(emp);


                }
                else
                {
                    if (cmbTipoEmpleado.SelectedIndex == 2)
                    {
                        emp = new Contrato(Convert.ToInt32(mskHorasPorMes.Text), Convert.ToInt32(mskPrecioPorHora.Text));
                        emp.Indentificacion = mskCedula.Text;
                        emp.Nombre = txtNombre.Text;
                        if (rbtnmasculino.Checked)
                        {
                            emp.Genero = Genero.Masculino;
                        }
                        else
                        {
                            if (rbtnFemenino.Checked)
                            {
                                emp.Genero = Genero.Femenino;
                            }
                        }
                        emp.EstadoCivil = (EstadoCivil)cmbEstadoCivil.SelectedItem;
                        emp.Edad = calcularEdad();


                        mensual = (int)emp.CalcularSalarioMensual();
                        quisena = (int)emp.CalcularSalarioQuisenal();
                        semanal = (int)emp.CalcularSalarioSemanal();
                        lista.Add(emp);


                    }
                }

            }


            dgvEmpleados.DataSource = lista;
        }

        private int calcularEdad()
        {
            int edad = 0;

            int dia = 0;
            int mes = 0;
            int annos = 0;



            int diae = 0;
            int mese = 0;
            int annose = 0;

            DateTime fecha = DateTime.Now;

            dia = fecha.Day;
            mes = fecha.Month;
            annos = fecha.Year;

            DateTime fechaE = dtpFechaNacimiento.Value;
            emp.FechaNacimiento = fechaE;

            diae = fechaE.Day;
            mese = fechaE.Month;
            annose = fechaE.Year;
            edad = annos - annose;
            if (mes < mese)
            {
                if (dia > diae)
                {
                    edad -= 1;
                }
            }
            else
            {

            }
            return edad;
        }
    }

}
