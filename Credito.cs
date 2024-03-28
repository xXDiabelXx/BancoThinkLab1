using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoThinkLab1
{
    internal class Credito
    {
        public string Rut { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string Telefono { get; set; }
        public string DireccionParticular { get; set; }
        public double Sueldo { get; set; }
        public string DireccionLaboral { get; set; }
        public double MontoCredito { get; set; }
        public int CantidadCuotas { get; set; }

        public Credito() 
        {
            this.Sueldo = 100000;
            this.MontoCredito = 100000;
            this.CantidadCuotas = 10;
        }
        public double calculaCredito() 
        {
            double maximoCredito = this.Sueldo * 1.5;
            float interesMensual = 0;
            double totalCredito = 0;

            if(maximoCredito >= this.MontoCredito) 
            {
                if(this.CantidadCuotas > 48) 
                {
                    interesMensual = 3f / 12f;
                   
                    //3%
                }else 
                {
                    interesMensual = 1.85f / 12f;
                    
                    //1.85%
                }
                totalCredito = this.MontoCredito * interesMensual * this.CantidadCuotas;
            }
            return Math.Round(totalCredito);
        }
    }
}
