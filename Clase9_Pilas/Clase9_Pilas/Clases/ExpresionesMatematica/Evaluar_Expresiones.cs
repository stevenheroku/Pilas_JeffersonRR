using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_Pilas.Clases.ExpresionesMatematica
{
    class Evaluar_Expresiones
    {
        public static double evaluar(string infija)//metodo que utilizo para evaluar mi expresion matematica
        {
            String posfija = convertir(infija);//convierto antes mi expresión de infija a posfija para poder evaluar usando una pila
            Console.WriteLine("La expresion posfija es: " + posfija);
            return evaluarPosfija(posfija);
        }
        //2-5*8
        //


        //convierto expresion a profija
        private static string convertir(string infija)
        {
            string posfija = "";
            Pila_Expresiones pila = new Pila_Expresiones(49);//cantidad de caracteres que permite nuestr expresión
            for(int i=0;i<infija.Length;i++)
            {
                //2-1
                char caracter = infija[i];
                if (esOperador(caracter))
                {

                    //2-1*2

                    if(pila.pilavacia())
                    {
                        pila.insertarPila(caracter);
                    }
                    else
                    {
                        //int pe = prioridadExpresion(caracter);
                        //int pp = prioridadPila((char)pila.cimaPila());


                        if (prioridadExpresion(caracter) > prioridadPila((char)pila.cimaPila()))
                        {
                            pila.insertarPila(caracter);

                        }
                        else
                        {
                            //porfijo =21-2*
                            //pila//-*2
                            posfija += pila.quitarchar();
                            pila.insertarPila(caracter);
                        }
                        


                    }
                }
                else
                {
                    posfija += caracter;
                }
            }
            //2-
            while(!pila.pilavacia())
            {
                posfija += pila.quitarchar();
            }
            return posfija;

        }


        //evaluar prioridades
        private static int prioridadExpresion(char operador)
        {
            if (operador == '^') return 4;
            if (operador == '*' || operador == '/') return 2;
            if (operador == '+' || operador == '-') return 1;
            if (operador == '(') return 5;
            return 0;
        }

        //dependiendo la prioridad de la pila asi me va retornar
        private static int prioridadPila(char operador)
        {
            if (operador == '^') return 3;
            if (operador == '*' || operador == '/') return 2;
            if (operador == '+' || operador == '-') return 1;
            if (operador == '(') return 0;
            return 0;
        }


        //evaluo expresión prosfija, y me retorna el los dos numeros que estan en la cima de la pila para poder operarlos
        private static double evaluarPosfija(string posfija)
        {
            Pila_Expresiones pila = new Pila_Expresiones(100);

            for(int i=0;i<posfija.Length;i++)
            {
                char valor = posfija[i];//2-1=1
                if(!esOperador(valor))
                {
                    double num = Convert.ToDouble(valor + "");
                    pila.insertarPila(num);
                }
                else
                {
                    double num2 = (double)pila.quitarchar();
                    double num1 = (double)pila.quitarchar();
                    double num3 = operacion(valor, num1, num2);
                    pila.insertarPila(num3);
                }
            }

            return (double)pila.cimaPila();
        }


        //realiazo la operación dependendiendo la expresión que ingres
        private static double operacion(char letras, double num1, double num2)
        {
            if (letras == '*') return num1 * num2;
            if (letras == '/') return num1 / num2;
            if (letras == '+') return num1 + num2;
            if (letras == '-') return num1 - num2; 
            if (letras == '^') return Math.Pow( num1 , num2);

            return 0;
        }


        //verifico si el que voy a insertar a la pila es un operador y retorno un true si no retorna un false caso que sea un numero
        private static bool esOperador(char caracter)
        {
            if(caracter == '*'|| caracter == '/'|| caracter == '+'|| caracter == '-'|| caracter == '('|| caracter == ')'|| caracter == '^')
            {
                return true;
            }
            
                return false;
            
        }

    }
}
