using Clase9_Pilas.Clases.ExpresionesMatematica;
using Clase9_Pilas.Clases.listaPila_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clase9_Pilas.Clases
{
    class Metodo_Tarea
    {
        






        //USANDO LAS 3 ESTRUCTURAS INSERTAR NUMEROS -1
        public void NumerosConLas3Estructuras()
        {
            PilaLista_ConvertidaLista pilaArrays;
            //PilaLineal pila;
            int x;
            int clave = -1;
            Console.WriteLine("INGRESE OPCION 1 , 2 o 3");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numeros y para terminar -1");
            

            

            if (opcion ==1)//USANDO LAS LISTAS ENLAZADAS APILADAS
            {
                Console.WriteLine("USANDO LAS LISTAS ENLAZADAS APILADAS");
                pilaArrays = new PilaLista_ConvertidaLista();
               
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        pilaArrays.agregarPilaList(x);
                    }
                    int p;
                    p = 0;

                } while (x != clave);
                int pausa = 0;
                Console.WriteLine("Estos son los elementos de la pila");

                while (!pilaArrays.ListaVacia())
                {
                    x = (int)(pilaArrays.quitarchar());
                    Console.WriteLine($"ELEMENTOS USANDO PILA Y LISTA ENLAZADA: {x}");
                }
            }

            if( opcion == 2) //USANDO LA PILA LINEAL CON ARREGLOS
            {
                Console.WriteLine("USANDO LA PILA LINEAL CON ARREGLOS");
                PilaLineal pila;

                try
                {

                    pila = new PilaLineal();//crear la pila
                    do
                    {
                        x = Convert.ToInt32(Console.ReadLine());
                        if (x != -1)
                        {
                            //pilas_lista.insertar(x);
                            pila.insertar(x);
                        }


                    } while (x != clave);
                    int pausa = 0;
                    Console.WriteLine("Estos son los elementos de la pila");

                    while (!pila.pilavacia())
                    {
                        x = (int)(pila.quitarcharArreglo());
                        Console.WriteLine($"elemento: {x}");
                    }

                }
                catch (Exception error)
                {
                    Console.WriteLine("ERROR =" + error);
                }
            }

            if(opcion==3)//USANDO LA PILA LISTA USANDO LIST<OBJECT>
            {
                Console.WriteLine("USANDO LA PILA LISTA USANDO LIST<OBJECT>");
                PilaLista pil_Ls;
                try
                {
                    pil_Ls = new PilaLista();

                    do
                    {
                        x = Convert.ToInt32(Console.ReadLine());
                        if (x != -1)
                        {
                            //pilas_lista.insertar(x);
                            // pila.insertar(x);
                            pil_Ls.insertar(x);
                        }


                    } while (x != clave);
                    int pausa = 0;
                    Console.WriteLine("Estos son los elementos de la pila");

                    while (!pil_Ls.pilavacia())
                    {
                        x = (int)(pil_Ls.quitar());
                        Console.WriteLine($"elemento: {x}");
                    }

                }
                catch (Exception error)
                {
                    Console.WriteLine("ERROR =" + error);
                }
            }
        }

       
        //USANDO LAS 3 ESTRUCTURAS CON PALINDROMOS

         public void PalindromoConlas3Estructuras()
        {
            Console.WriteLine("INGRESE LA OPCIÓN 1 , 2 o 3");
            int option = int.Parse(Console.ReadLine());
            String pal;
            bool esPalindromo;

            Console.WriteLine("TECLE UNA PALABRA PARA VER SI ES PALINDROMA SI O NO ");
            pal = Console.ReadLine();

            string remplazada = Regex.Replace(pal, @"\s", "");
            string convertida = remplazada.ToLower();
            Regex reg = new Regex("[^a-zA-Z0-9 ]");
            string TextoSinEspacios = convertida.Normalize(NormalizationForm.FormD);
            string textaccent = reg.Replace(TextoSinEspacios, "");



            if(option == 1)//USANDO PALINDROMO CON LISTAS ENLAZADAS
            {
                Console.WriteLine("\nUSANDO PALINDROMO CON LISTAS ENLAZADAS\n");

                ListaEnlazada_Pila pilaList;
                
                pilaList = new ListaEnlazada_Pila();
                for (int i = 0; i < textaccent.Length;)
                {
                    Char c;
                    c = textaccent[i++];
                    pilaList.agregarAlInicio(c);
                }
                Console.WriteLine("IMPRIME INVERTIDA");
                pilaList.imprimeTodosLosNodos();

                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaList.ListaVacia();)
                {
                    Char c;
                    c = (Char)pilaList.quitarchar();
                    esPalindromo = textaccent[j++] == c; //evalua si la posicion es igual 
                }

                pilaList.limpiarLista();
                if (esPalindromo)
                {
                    Console.WriteLine($"LA PALABRA {textaccent} ES PALINDROMA");
                }
                else
                {
                    Console.WriteLine($"LA PALABRA {textaccent} NO ES PALINDROMA");
                }
            }



            if(option ==2)//USANDO PILA LINEAL ARREGLO TIPO OBJECT
            {
                Console.WriteLine("\nUSANDO PALINDROMO CON PILA LINEAL ARREGLO TIPO OBJECT\n");
                PilaLineal pilaChar;
                pilaChar = new PilaLineal();
                //creamos la pila con los chars 
                for (int i = 0; i < textaccent.Length;)
                {
                    Char c;
                    c = textaccent[i++];
                    pilaChar.insertar(c);
                }
                //comprueba si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilavacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarchar();
                    esPalindromo = textaccent[j++] == c; //evalua si la pos es igual 
                }
                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"LA PALABRA {textaccent} ES PALINDROMA");
                }
                else
                {
                    Console.WriteLine($"LA PALABRA {textaccent} NO ES PALINDROMA");
                }

            }



            if(option ==3) //USANDO PALINDROMO CON PILA LISTA LIST<OBJECT>
            {
                Console.WriteLine("\nUSANDO PALINDROMO CON PILA LISTA LIST<OBJECT>\n");
                PilaLista pila_Lc;
                pila_Lc = new PilaLista();

                //creamos la pila con los chars
                for (int i = 0; i < textaccent.Length;)
                {
                    Char c;
                    c = textaccent[i++];
                    pila_Lc.insertar(c);
                }
                //comprueba si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pila_Lc.pilavacia();)
                {
                    Char c;
                    c = (Char)pila_Lc.quitar();
                    esPalindromo = textaccent[j++] == c; //evalua si la pos es igual 
                }
                pila_Lc.limpiarpila();
                if (esPalindromo)
                {
                    Console.WriteLine($"LA PALABRA {textaccent} ES PALINDROMA");
                }
                else
                {
                    Console.WriteLine($"LA PALABRA {textaccent} NO ES PALINDROMA");
                }
            }
        }

        //USANDO LAS 3 ESTRUCTURAS INSERTANDO NUMEROS
        public void InsertarNumerosConsLas3Estructuras()
        {
            Console.WriteLine("INGRESE LA OPCIÓN 1  2  o 3");
            int option = int.Parse(Console.ReadLine());

            if(option ==1)//USANDO LA PILA LISTA LIST<OBJECT>
            {
                Console.WriteLine("\nUSANDO LA PILA LISTA LIST<OBJECT>\n");
                int x;
                PilaLista pl = new PilaLista();
                pl.insertar(1);
                pl.insertar(2);
                pl.insertar(3);
                pl.insertar(4);
                pl.insertar(5);
                pl.insertar(6);
                pl.insertar(7);

                var xx = pl.quitar();///eliminar cima
                while (!pl.pilavacia())
                {
                    x = (int)(pl.quitar());
                    Console.WriteLine($"ELEMENTOS DE LA PILA: {x}");
                }
               
                int pau;
                pau = 0;
                Console.ReadKey();
            }

            if(option ==2)//USANDO LA LISTA ENLAZADA APILADA
            {
                Console.WriteLine("\nUSANDO LA LISTA ENLAZADA APILADA\n");
                PilaLista_ConvertidaLista pl = new PilaLista_ConvertidaLista();
                pl.agregarPilaList(1);
                pl.agregarPilaList(2);
                pl.agregarPilaList(3);
                pl.agregarPilaList(4);
                pl.agregarPilaList(5);
                pl.agregarPilaList(6);
                pl.agregarPilaList(7);

                Console.WriteLine("IMPRIMIR DATOS AL INVERSO");
                pl.imprimirPila();

                var xx = pl.quitarchar();
                int pau;
                pau = 0;
            }

            if(option ==3)//USANDO PILA LINEAL AREGLOS [OBJECT]
            {
                Console.WriteLine("\nUSANDO PILA LINEAL AREGLOS [OBJECT]\n");
                int x;
                PilaLineal pl = new PilaLineal();
                pl.insertar2(1);
                pl.insertar2(2);
                pl.insertar2(3);
                pl.insertar2(4);
                pl.insertar2(5);
                pl.insertar2(6);
                pl.insertar2(7);

                while (!pl.pilavacia())
                {
                    x = (int)(pl.quitarcharArreglo());
                    Console.WriteLine($"elemento: {x}");
                }

                //var xx = pl.quitarcharArreglo();
                int pau;
                pau = 0;
            }

        }    
        

        //METODO  EVALUADOR DE EXPRESIONES MATEMATICAS CON PILA LINEAL
        public void expresionesPilas()
        {
            string infija;
            Console.WriteLine("INGRESE LA EXPRESION QUE DESEA EVALUAR");
            infija = Console.ReadLine();
            Console.WriteLine("EL RESULTADO ES " + Evaluar_Expresiones.evaluar(infija));
        }
        
    }
}
