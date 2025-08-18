using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorio.Clases
{
    public class Marcador
    {
        private double costoHora { get; set; }  
        private double horasTrabajadas { get; set; }  
        private double salario { get; set; }

        public Marcador()
        {
            this.costoHora = 50;
        }

        public double getSalario (double p_horasTrabajadas)
        {
            this.horasTrabajadas = p_horasTrabajadas;
            this.salario = this.costoHora * this.horasTrabajadas;
            return this.salario;
        }
    }
}
