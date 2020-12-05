using System;
using System.Collections;
using System.Collections.Generic;

namespace analizadorSintactico
{
    class Program
    {
        public const int ERROR = -1;
        public const int IDENTIFICADOR = 0;
        public const int SIMBOLO = 1;
        public const int SIGNOPESO = 2;
        public const int E = 3;
        public const int INICIAL = 5;

        static void Main(string[] args)
        {
            Console.WriteLine("Primer ejercicio: ");
            primerEjercicio("hola+mundo$");

            Console.WriteLine("Segundo ejercicio: ");
            segundoEjercicio("a+b+c+d+e+f$");
        }


        static void primerEjercicio(string texto)
        {
            Pila pila = new Pila();
            pila.push(new NoTerminal(ElementoPila.SIMBOLO, "$0"));
            pila.mostrarPila();

            int estado = INICIAL; //Identifica el estado actual del analizador
            int d = 2;
            String lexema = "";
            Char c;

            //Inicia el automata del analizador
            for (int i = 0; i < texto.Length; i++)
            {
                c = texto[i];
                switch (estado)
                {
                    case INICIAL:
                        if (Char.IsLetter(c) || c == '_')
                        { //Verifica si es letra o empieza con un "_"
                            estado = IDENTIFICADOR;
                            lexema += c;
                        }
                        else if (c == '+')
                        {
                            lexema += c;

                            pila.push(new Terminal(SIMBOLO, lexema + d));
                            d++;
                            estado = INICIAL;
                            lexema = "";

                            pila.mostrarPila();
                        }
                        else if(c == '$')
                        {
                            pila.vaciarPila();

                            Pila nuevaPila = new Pila();
                            nuevaPila.push(new Estado(E, "$0E1"));
                            nuevaPila.mostrarPila();
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                            return;
                        }
                        break;
                    case IDENTIFICADOR:
                        if (Char.IsLetterOrDigit(c) || c == '_')
                        {
                            estado = IDENTIFICADOR;
                            lexema += c;
                        }
                        else
                        {
                            pila.push(new Terminal(IDENTIFICADOR, lexema + d));
                            d++;
                            estado = INICIAL;
                            lexema = "";
                            i--;

                            pila.mostrarPila();
                        }
                        break;
                    default:
                        break;
                }
            }
            //Termina el automata
        }

        static void segundoEjercicio(string texto)
        {
            Pila pila = new Pila();
            pila.push(new NoTerminal(ElementoPila.SIMBOLO, "$0"));
            pila.mostrarPila();

            int estado = INICIAL; //Identifica el estado actual del analizador
            int d2 = 2, d3 = 3;
            String lexema = "";
            Char c;

            //Inicia el automata del analizador
            for (int i = 0; i < texto.Length; i++)
            {
                c = texto[i];
                switch (estado)
                {
                    case INICIAL:
                        if (Char.IsLetter(c) || c == '_')
                        { //Verifica si es letra o empieza con un "_"
                            estado = IDENTIFICADOR;
                            lexema += c;
                        }
                        else if (c == '+')
                        {
                            lexema += c;
                            pila.push(new Terminal(SIMBOLO, lexema + d3));
                            estado = INICIAL;
                            lexema = "";

                            pila.mostrarPila();
                        }
                        else if (c == '$')
                        {
                            pila.vaciarPila();

                            Pila nuevaPila = new Pila();
                            nuevaPila.push(new Estado(E, "$0E1"));
                            nuevaPila.mostrarPila();
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                            return;
                        }
                        break;
                    case IDENTIFICADOR:
                        if (Char.IsLetterOrDigit(c) || c == '_')
                        {
                            estado = IDENTIFICADOR;
                            lexema += c;
                        }
                        else
                        {
                            pila.push(new Terminal(IDENTIFICADOR, lexema + d2));
                            estado = INICIAL;
                            lexema = "";
                            i--;

                            pila.mostrarPila();
                        }
                        break;
                    default:
                        break;
                }
            }
            //Termina el automata
        }
    }
}
