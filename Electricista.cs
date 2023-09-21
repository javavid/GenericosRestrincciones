using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Electricista : IParaEmpleados
    {
        private double SalarioE;

        public double Getsalario()
        {
            return SalarioE;
        }
        public Electricista(double salarioe)
        {
            this.SalarioE = salarioe;
        }
    }
}
