using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* si yo meto la clase Estudiantes, entre parentesis angulares <Estudiantes> 
             va a dar error  ya que esta no tiene implementada la interface generica. */
            AlmacenEmpleados<Director> empleados1 = new AlmacenEmpleados<Director> (3);
            empleados1.agregar(new Director(500));
            empleados1.agregar(new Director(1000));
            empleados1.agregar(new Director(1500));
        }
    }
}
