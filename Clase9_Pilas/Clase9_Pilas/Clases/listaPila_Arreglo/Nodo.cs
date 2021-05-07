using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_Pilas.Clases
{
    class Nodo
    {
        public Object elemento;
        public Nodo siguiente;


        public Nodo(Object entrada)
        {
            this.elemento = entrada;
            this.siguiente = null;

        }

    }
}
