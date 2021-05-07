using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_Pilas.Clases.listaPila_List
{
    class Nodos
    {
        public Object dato;
        public Nodos enlace;


        public Nodos(Object entrada)
        {
            this.dato = entrada;
            this.enlace = null;

        }

    }
}
