using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_Pilas.Clases
{
    class PilaLista
    {

        private int cima;
        public Object nombre;
        private List<Object> listaPila;


        public PilaLista()
        {
            cima = -1;//condicion de pila vacia
            listaPila = new List<Object>();
        }


        public void insertar(Object elemento)
        {
            cima++;
            listaPila.Add(elemento);

        }

        public Object quitar()
        {
            Object aux;
            if(pilavacia())
            {
                throw new Exception("PILA VACIA");
            }

            aux = listaPila.ElementAt(cima);
            listaPila.RemoveAt(cima);
            cima--;
            return aux;
        }

        public Object cimaPila()
        {
            if(pilavacia())
            {
                throw new Exception("PILA VACIA");
            }
            return listaPila.ElementAt(cima);
        }

        public bool pilavacia()
        {
            return cima == -1;
        }

        public void limpiarpila()
        {
            while(!pilavacia())
            {
                quitar();
            }

        }

    }
}
