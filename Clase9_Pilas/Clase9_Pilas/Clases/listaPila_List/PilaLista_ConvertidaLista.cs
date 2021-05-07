using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_Pilas.Clases.listaPila_List
{
    class PilaLista_ConvertidaLista
    {

        public Nodos first;
        public Nodos last;
        public int cima;

        public PilaLista_ConvertidaLista()
        {
            first = null;
            last = null;
            cima = 0;

        }


        public bool listallena()
        {
            return first == null;
        }
        public bool ListaVacia()
        {
            if (first == null)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public void agregarPilaList(object valor)
        {
            // Define un nuevo nodo.
            Nodos nuevo = new Nodos(valor);
            // Agrega al valor al nodo.
            // Consulta si la lista esta vacia.
            if (ListaVacia())
            {
                // Inicializa la lista agregando como inicio al nuevo nodo.
                first = nuevo;
                // Caso contrario va agregando los nodos al inicio de la lista.
            }
            else
            {
                // Une el nuevo nodo con la lista existente.
                nuevo.enlace = first;
                first = nuevo;
            }
            // Incrementa el contador de tamaño de la lista.
            cima++;
        }

        public object quitarchar()
        {
            int aux;
            if (ListaVacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (int)first.dato;
            first = first.enlace;
            cima--;
            return aux;
        }

        public void imprimirPila()
        {
            Nodos actual = first;
            while (actual != null)
            {
                Console.WriteLine(actual.dato);
                actual = actual.enlace;
            }
        }

    }
}
