using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_Pilas.Clases
{
    class PilaLineal
    {
        private static int Tampila = 49;
        private int cima;
        private Object[] listaPila;


        public PilaLineal()
        {
            cima = -1;//condicion de pila vacia
            listaPila = new Object[Tampila];
        }


        public bool pilallena()
        {
            return cima == Tampila - 1;
        }


        //operciones aue modifica la pila
        public void insertar(Object elemento)
        {
            if(pilallena())
            {
                throw new Exception("Desbordamiento de pila");
            }
            //incrementar puntero cima y vamos insertar el elemento
            cima++;
            listaPila[cima] = elemento;

        }

        public void insertar2(Object elemento)
        {
            if(!pilallena())
            {
                cima++;
                listaPila[cima] = elemento;
            }

        }



        //extraer elemento de la pila(pop)
        public bool pilavacia()
        {
            if(cima==-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Object eliminar()
        {
            int aux;
            if(pilavacia())
            {
                throw new Exception("La pila esta vacia, no se puede sacar");
            }
            //guarda el elemento en la cima

            aux = (int)listaPila[cima];
            //decrementar el valor de la cima y retornar elemento
            cima--;
            return aux;
        }

        public void limpiarPila()
        {
            cima = -1;
        }

        //retorna un tipo char

        public object quitarchar()
        {
            char aux;
                if(pilavacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (char)listaPila[cima];
            cima--;
            return aux;
        }

        public object quitarcharArreglo()
        {
            int aux;
            if (pilavacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (int)listaPila[cima];
            cima--;
            return aux;
        }





        //operación de acceso a la pila

        public Object cimaPila()
        {
            if(pilavacia())
            {
                throw new Exception("Pila vacia");
            }
            return listaPila[cima];
        }

        public ListaEnlazada_Pila converToLista()
        {
            ListaEnlazada_Pila mylista = new ListaEnlazada_Pila();
            int x;
            while (!pilavacia())
            {
                x = (int)quitarchar();
                mylista.insertar(x);
            }
            return mylista;
        }



    }
}
