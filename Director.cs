using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Director : IParaEmpleados
    {
        private double SalarioD;

        public double Getsalario()
        {
            return SalarioD;
        }
        public Director(double salariod) 
        {
         this.SalarioD = salariod;
        }
    }
}
