using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Presentacion : Form
    {
        ClaseNegocio claseNegocio = new ClaseNegocio();

        public Presentacion()

        {
            InitializeComponent();
        }
       

        private void Presentacion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            cbox1.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt1.Focus();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsueldo_Click(object sender, EventArgs e)
        {
            string nombre = txt1.Text;
            string sexo = txt2.Text;
            string estadoCivil = cbox1.Text;
            int edad = Int32.Parse(txt3.Text);
            string hijos = txt4.Text;

            decimal salarioCalculado = claseNegocio.CalcularSalario(nombre, sexo, estadoCivil, edad, hijos);

            txt5.Text = $"El sueldo del trabajador: {txt1.Text}  es:  {salarioCalculado:C}";
            
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
