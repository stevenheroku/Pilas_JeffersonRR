using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_Pilas.Clases.ExpresionesMatematica
{
    class ListaOperaciones
    {
        Nodo primero;
        public String preparaCadena(String ExpreAr)
        {
            String x = "";
            char a = ' ';
            char b = ' ';


            for (int i = 0; i < ExpreAr.Length - 1; i++)
            {
                a = (char)ExpreAr[i];
                b = ExpreAr[i + 1];

                if ((a == '(' && b == '-'))
                {
                    Console.WriteLine("en x " + x);
                    x += a;
                    x += '0';
                }
                else
                {
                    if (a == '-' && i == 0)
                    {
                        x += '0';
                    }
                    x += a;
                }
            }
            x += b;
            Console.WriteLine(x);
            return x;
        }

        //public bool valida()
        //{
        //    Nodo q = getp();
        //    int tamaño = contar();
        //    String it;
        //    bool sw = true;
        //    for (int i = 1; i <= tamaño; i++)
        //    {
        //       // it = q.getNum();
        //        Console.WriteLine(it);
        //        String it2 = enviaKaesimo(i + 1);
        //        if (esSigno(it) && esSigno(it2))
        //        {
        //            Console.WriteLine("operación no valida");
        //            sw = false;
        //        }
        //        if (it.Equals("(") && it2.Equals("("))
        //        {
        //            Console.WriteLine("operación no valida");
        //            sw = false;
        //        }
        //        if (esSigno(it) && i == tamaño)
        //        {
        //            Console.WriteLine("operación no valida");
        //            sw = false;
        //        }
        //        if (!it.Equals("(") && !it.Equals(")") && !esSigno(it))
        //        {
        //            if (puntosDob(it) == false)
        //            {
        //                sw = false;
        //                Console.WriteLine("operacion no valida");
        //            }
        //        }
        //        if (tamaño == 1)
        //            sw = false;


        //        q = q.siguiente;
        //    }
        //    return sw;
        //}

        public bool puntosDob(String it)
		{
			char a = ' ';
			int cont = 0;
			bool aux = true;
			for (int i = 0; i < it.Length - 1; i++)
			{
				a = it[i];
				if (a == '.')
				{
					cont++;
				}
			}
			if (cont > 1)
				aux = false;
			return aux;
		}

		bool esNumero(String x)//compara si es numero
		{
			bool k = false;
			if (x.Equals("0") || x.Equals("1") || x.Equals("2") || x.Equals("3") || x.Equals("4") || x.Equals("5") || x.Equals("6") || x.Equals("7") || x.Equals("8") || x.Equals("9") || x.Equals("."))
			{
				k = true;
			}
			return k;
		}


		void llenaLista(String expreAr)
		{
			String x;
			String insert = "";

			expreAr = expreAr + " ";

			for (int i = 0; i < expreAr.Length - 1; i++)
			{
				x = expreAr.Substring(i + 1, i + 2);                            //recupera los datos siguientes de la cadena
				if (esNumero(x) && (esNumero(expreAr.Substring(i, i + 1)))) //si es numero se concatena
					insert += expreAr.Substring(i, i + 1);
				else                                                    //si no es numero no se concatena
				{
					insert += expreAr.Substring(i, i + 1);
                    Console.WriteLine("en el se " +insert);
					//adiultimoEA(insert);                                //el numero o el simbolo se agrega a la lista
					insert = "";                                            //reiniciamos la cadena
				}
			}
		}

        void limpiar()
        {
            primero = null;
        }

        public String enviaKaesimo(int k)
        {       //metodo parecido a elimina kaesimo
            int conta = 1;
            String it = "";
            Nodo q = new Nodo(k) ;
            bool sw = true;
            while (q != null && sw == true)
            {
                if (k == conta)
                {
                   // it =  q.elemento;
                    sw = false;
                    q = q.siguiente;
                }
                else
                {
                    conta++;
                    q = q.siguiente;
                }
            }
            return (it);
        }

        //public ListaEnlazada_Pila aLista(PilaLineal p)
        //{   //paso los datos de una pila a una lista
        //	PilaLineal aux = new PilaLineal();
        //	ListaEnlazada_Pila l = new ListaEnlazada_Pila();
        //	while (!p.pilavacia())
        //	{
        //		aux.insertar(p.eliminar());
        //	}
        //	while (!aux.pilavacia())
        //	{
        //		l.adiultimoEA(aux.eliminar());
        //	}
        //	return l;
        //}
        bool esSigno(String x)
        {
            bool k = false;
            if (x.Equals("+") || x.Equals("-") || x.Equals("*") || x.Equals("/"))
            {
                k = true;
            }
            return k;
        }
        //String operacionP(ListaEnlazada_Pila p)    //hace la operacion
        //{
        //	String k = "";
        //	PilaLineal total = new PilaLineal();
        //	float a = 1;
        //	float b = 1;
        //	int tamaño = p.contar();
        //	Nodo q = getp();
        //	for (int i = 1; i <= tamaño; i++)
        //	{
        //		b = 1;
        //		if (esSigno(p.enviaKaesimo(i)))
        //		{
        //			k = p.enviaKaesimo(i + 1);
        //			if (p.enviaKaesimo(i).equals("-"))
        //			{
        //				b = -1;
        //			}
        //			a = Float.parseFloat(total.eliminar()) + (Float.parseFloat(k) * b);
        //			i = i + 1;
        //		}
        //		else
        //		{
        //			a = float.Parse(p.enviaKaesimo(i));
        //		}
        //		total.insertar(float.TryParse.ToString(a));
        //		q = q.getSig();
        //	}
        //	k = total.eliminar();
        //	return k;
        //}



        //String operacionl(ListaEnlazada_Pila l)
        //{       //realiza las operaciones en los parentesis
        //	PilaLineal p = new PilaLineal();
        //	ListaEnlazada_Pila w = new ListaEnlazada_Pila();
        //	String k = "";
        //	String s = "";
        //	float a;
        //	float b = 1;
        //	int tamaño = l.contar();
        //	nodoExpN q = l.getp();
        //	for (int i = 1; i <= tamaño; i++)
        //	{
        //		k = l.enviaKaesimo(i);
        //		if (k.equals("*") || k.equals("/"))
        //		{
        //			b = 1;
        //			a = Float.parseFloat(p.eliminar());
        //			s = l.enviaKaesimo(i + 1);
        //			if (s.equals("-"))
        //			{
        //				b = -1;
        //				s = l.enviaKaesimo(i + 2);
        //				i = i + 2;
        //			}
        //			else
        //			{
        //				i++;
        //			}
        //			if (k.equals("*"))
        //			{
        //				a *= (Float.parseFloat(s) * b);
        //			}
        //			else
        //			{
        //				a /= (Float.parseFloat(s) * b);
        //			}
        //			k = Float.toString(a);
        //		}
        //		q = q.getSig();
        //		p.insertar(k);
        //	}
        //	w = aLista(p);      //envia la suboperacion () y final y convierte de pila a lista
        //	s = operacionP(w);  //opera si existe una suboperacion
        //	return s;
        //}


        //Object resolver(bool a)  //separa por operaciones, envi a operacionl y muestra el resultado
        //{
        //    Object resultado;
        //    Object it = "";
        //    Nodo q = getp();
        //    int tamaño;
        //    PilaLineal pila = new PilaLineal();
        //    PilaLineal pila2 = new PilaLineal();
        //    ListaEnlazada_Pila p = new ListaEnlazada_Pila();
        //    p.limpiarLista();
        //    if (a == true)
        //    {
        //        for (int i = 1; i <= p.cima; i++)
        //        {
        //            it = enviaKaesimo(i);
        //            if (it.Equals(")"))
        //            {
        //                p.limpiarLista();
        //                it = pila.eliminar();
        //                while (!it.Equals("("))
        //                {
        //                    pila2.insertar(it);
        //                    it = pila.eliminar();
        //                }
        //                while (!pila2.pilavacia())
        //                {
        //                    p.adiultimoEA(pila2.eliminar());
        //                }
        //                it = operacionl(p);
        //                pila.insertar(it);
        //                p.limpiarLista();
        //            }
        //            else
        //            {
        //                pila.insertar(it);
        //            }
        //            q = q.siguiente;
        //        }
        //    }   //fin de la validacion
        //    while (!pila.pilavacia())
        //    {
        //        pila2.insertar(pila.eliminar());
        //    }
        //    while (!pila2.pilavacia())
        //    {
        //        p.adiultimoEA(pila2.eliminar());
        //    }
        //    //System.out.println(operacionl(p));
        //    resultado = operacionl(p);
        //    return resultado;
        //}
    }
}
