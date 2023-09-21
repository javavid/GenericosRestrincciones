using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Estudiante
    {
        private double Edad;
        
        public Estudiante(double edad)
        {
            this.Edad = edad;
        }

        public double GetEdad()
        {
            return Edad;
        }
    }
}
