using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{

    public class ClaseNegocio
    {
        public decimal CalcularSalario(string nombre, string sexo, string estadoCivil, int edad, string hijos) 
        {
            decimal salario = 0;

            decimal sueldoBase = (sexo == "Hombre") ? 5000 : 4000;

            switch (estadoCivil)
            {
                case "CASADO":
                    salario = sueldoBase - (sueldoBase * 0.20m);
                    break;

                case "SOLTERO":
                    salario = sueldoBase - (sueldoBase * 0.10m);
                    break;

                case "DIVORCIADO":
                    salario = sueldoBase - (sueldoBase * 0.15m);
                    break;

                case "VIUDO":
                    salario = sueldoBase - (sueldoBase * 0.05m);
                    break;

                default:
                    salario = sueldoBase;
                    break;

            }

            salario -= sueldoBase * 0.13m;

            if (sexo == "Mujer" && estadoCivil == "SOLTERO")
            {
                salario += sueldoBase * 0.20m;
            }

            if (edad >= 18 && edad <= 25) 
            {
                salario += sueldoBase * 0.20m;
            }

            if (edad >= 30 && edad <= 35)
            {
                salario += sueldoBase * 0.10m;
            }

            return salario;
        }
    }
}
