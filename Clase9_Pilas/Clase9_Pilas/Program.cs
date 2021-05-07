using Clase9_Pilas.Clases;
using Clase9_Pilas.Clases.listaPila_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clase9_Pilas
{
    class Program
    {

       
        static void Main(string[] args)
        {
            
            int opcion;
            Metodo_Tarea ejercicios = new Metodo_Tarea();
            
            do
            {

                Console.WriteLine("\t\t-----ESTRUCUTURAS DE DATOS {LISTA ENLAZADA} {PILA CON ARREGLO} {PILA CON LIST}----------\n");
                Console.WriteLine("1. INSERTAR NUMEROS CON LAS 3 ESTRUCTURAS\n");
                Console.WriteLine("2. PALINDROMO USADO CON LASS 3 ESTRUCUTRAS\n");
                Console.WriteLine("3. INSERTAR DATOS NUMERICOS CON LAS 3 ESTRUCTURAS\n");
                Console.WriteLine("4. RESOLVER EXPRESIONES MATEMATICAS CON PILAS USANDO ARREGLO PILA LINEAL\n");
                Console.WriteLine("5.SALIR\n");
               

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ejercicios.NumerosConLas3Estructuras();
                        break;

                    case 2:
                        ejercicios.PalindromoConlas3Estructuras();
                        break;
                    case 3:
                        ejercicios.InsertarNumerosConsLas3Estructuras();
                        break;
                    case 4:
                        ejercicios.expresionesPilas();
                        break;
                      
                }
                
                Console.ReadLine();

                Console.Clear();
            } while (opcion != 5);
   
            Console.ReadKey();
        }
    }
}
