using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoThinkLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Inicializado");
            Credito c1= new Credito();
            Console.WriteLine(c1.calculaCredito());
            
            Console.WriteLine("El total del credito va ser : " +  c1.calculaCredito() );
            Console.WriteLine("Valor mensual : " + (c1.calculaCredito() / c1.CantidadCuotas));


        }
    }
}
