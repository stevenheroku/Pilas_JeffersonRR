using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_Pilas.Clases.ExpresionesMatematica
{
    class Pila_Expresiones
    {

        private  int tamaño;
        private int cima;
        private Object[] Pila;


        public Pila_Expresiones(int n)
        {
            this.tamaño = n;
            cima = 0;
            Pila = new Object[tamaño];
        }

        public bool pilavacia()
        {
            return cima == 0;
        }

        public bool pilallena()
        {
            return cima == tamaño;
        }


        public void insertarPila(Object elemento)
        {
            if (!pilallena())
            {
                cima++;
                Pila[cima] = elemento;
            }

        }


        public void limpiarPila()
        {
            cima = 0;
        }

        //retorna un tipo char

        public object quitarchar()
        {
            Object aux;
            if (pilavacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (Object)Pila[cima];
            cima--;
            return aux;
        }


        //operación de acceso a la pila

        public Object cimaPila()
        {
            if (pilavacia())
            {
                throw new Exception("Pila vacia");
            }
            return Pila[cima];
        }


    }
}
