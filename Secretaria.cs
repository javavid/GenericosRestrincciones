using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Secretaria : IParaEmpleados
    {
        private double SalarioS;

        public double Getsalario()
        {
            return SalarioS;
        }
        public Secretaria(double salarios)
        {
            this.SalarioS = salarios;
        }
    }
}
