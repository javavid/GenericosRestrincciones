using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AlmacenEmpleados<T> where T : IParaEmpleados //de esta manera se crea un generico con restrinccion.
    {
        private int j = 0;
        private T[] DtosEmpleados;
        public AlmacenEmpleados(int e)
        {
            DtosEmpleados = new T[e];
        }
        public void agregar(T obj)
        {
            DtosEmpleados[j] = obj;
            j++;
        }

        public T GetEmpleado() 
        {
         return DtosEmpleados[j];
        }
    }
}
