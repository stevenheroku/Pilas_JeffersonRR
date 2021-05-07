using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Clase9_Pilas.Clases
{
    class ListaEnlazada_Pila
    {
        public Nodo primero;
        public Nodo ultimo;
        public int cima;

        public ListaEnlazada_Pila()
        {
            primero = null;
            ultimo = null;
            cima = 0;

        }
        public bool listallena()
        {
            return primero == null;
        }

        public bool ListaVacia()
        {
            if(primero == null)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public  void insertar(Object entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            if (primero == null)
            {
               
                primero = nuevo;
                primero.siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                primero.siguiente = nuevo;
                nuevo.siguiente = null;
                ultimo = nuevo;
            }
            this.cima++;
            
        }

        public void insertarprimero(object dato)
        {
            Nodo aux = new Nodo(dato);
            aux.siguiente = primero;
            primero = aux;
            cima++;
        }

        public void agregarAlInicio(object valor)
        {
            // Define un nuevo nodo.
            Nodo nuevo = new Nodo(valor);
            // Agrega al valor al nodo.
              // Consulta si la lista esta vacia.
            if (ListaVacia())
            {
                // Inicializa la lista agregando como inicio al nuevo nodo.
                primero = nuevo;
                // Caso contrario va agregando los nodos al inicio de la lista.
            }
            else
            {
                // Une el nuevo nodo con la lista existente.
                nuevo.siguiente=primero;
                primero = nuevo;
            }
            // Incrementa el contador de tamaño de la lista.
            cima++;
        }

        public Object eliminarN()
        {
            Nodo aux;
            if(ListaVacia())
            {
                throw new Exception("LISTA VACIA NO HAY DATA");
            }
            aux = (Nodo)primero;
            cima--;
            return aux;
        }

        public object quitarchar()
        {
            char aux;
            if (ListaVacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (char)primero.elemento;
            primero = primero.siguiente;
            cima--;
            return aux;
        }

        public void imprimeTodosLosNodos()
        {
            Nodo aux = primero;
            while (aux != null)
            {
                Console.WriteLine(aux.elemento);
                aux = aux.siguiente;
            }
        }

       


        public object retornaprimero()
        {
            return primero.elemento;
        }

        public void borrarprimero()
        {
            primero = primero.siguiente;
        }

        public void imprimir()
        {
            if(this.cima!=0)
            {
                Nodo aux = this.primero;
                string str = "";
                for(int i=0;i<this.cima;i++)
                {
                    str = str + aux.elemento + " ";
                    aux = aux.siguiente;
                    Console.WriteLine(str + "");
                }
                
            }
        }

        //public void imprimirInvertida()
        //{
        //    int k = -1;
        //    Nodo aux = this.primero;
        //    while (k<0)
        //    {
        //        aux = primero;
        //        for (int i=0;i>k;i++)
        //        {
        //            aux = aux.siguiente;
        //            Console.WriteLine("LISTA INVERTIDA" + aux.elemento);
        //        }
                
        //        k--;
        //    }
        //}
        //public void reverse2()
        //{
        //    Nodo aux = primero;
        //    while (aux != null)
        //    { //2,4,5,7
        //        aux = aux.siguiente;
        //        if (aux.siguiente == null)
        //        {
        //            aux = primero;
        //        }
        //        else
        //        {
        //            aux = aux.siguiente;
        //        }
        //        Console.WriteLine(aux.elemento);
        //        aux = aux.siguiente;
        //    }
        //    Console.WriteLine(aux.elemento);
        //}
        //public int longitud()
        //{
        //    Nodo actual = this.primero;
        //    int lon = 0;
        //    while (actual != null)
        //    {
        //        lon++;
        //        actual = actual.siguiente;
        //    }
        //    return lon;
        //}


        //imprime lista invertida accediendo del ultimo Nodo
        //public void reverse()
        //{

        //    int cont = this.longitud();
        //    while (cont > 0)
        //    {
        //        Nodo actual = this.primero;

        //        while (actual.siguiente != null)
        //        {

        //            if (actual.siguiente.siguiente == null)
        //            {
        //                Console.WriteLine(actual.siguiente.elemento + " ");
        //                actual.siguiente = null;
        //            }
        //            else
        //            {
        //                actual = actual.siguiente;

        //            }
        //        }
        //        cont--;
        //    }
        //    Console.WriteLine(primero.elemento);
        //}


        public void limpiarLista()
        {
            cima = -1;
        }
    }
}
