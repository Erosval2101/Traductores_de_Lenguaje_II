using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizadorLexico
{
    class ElementoPila
    {
        public const int ERROR = -1;
        public const int IDENTIFICADOR = 0;
        public const int SIMBOLO = 1;
        public const int SIGNOPESO = 2;
        public const int E = 3;
        public const int INICIAL = 5;

        public int tipo;
        public String simbolo;

        public ElementoPila()
        {
            tipo = 5;
        }

        public String ToString()
        {
            return simbolo;
        }
    }

    class Terminal : ElementoPila
    {
        public Terminal(int id)
        {
            tipo = id;
            if (id == SIGNOPESO)
            {
                simbolo = "$";
            }
        }

        public Terminal(int id, String sim)
        {
            tipo = id;
            simbolo = sim;
        }
    }

    class NoTerminal : ElementoPila
    {
        public NoTerminal(int id, String sim)
        {
            tipo = id;
            simbolo = sim;
        }
    }

    class Estado : ElementoPila
    {
        public Estado(int id, String estado)
        {
            tipo = id;
            simbolo = estado;
        }
    }


    class Pila
    {
        public LinkedList<ElementoPila> listaPila = new LinkedList<ElementoPila>();

        public Pila()
        {

        }

        public void push(ElementoPila x)
        {
            listaPila.AddLast(x);
        }

        public ElementoPila top()
        {
            return listaPila.First.Value;
        }

        public ElementoPila pop()
        {
            ElementoPila x = listaPila.First.Value;
            listaPila.Remove(x);

            return x;
        }

        public void vaciarPila()
        {
            listaPila.Clear();
        }

        public void mostrarPila()
        {
            foreach (ElementoPila dato in listaPila)
            {
                Console.Write(dato.simbolo+dato.tipo);
            }
            Console.WriteLine("\n");
        }
    }
}
