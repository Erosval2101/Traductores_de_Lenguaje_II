using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizadorLexico
{

    class AnalizadorLexico
    {
        //Símbolos
        public const int ERROR = -1;
        public const int INICIAL = 0;
        public const int IDENTIFICADOR = 1;
        public const int REAL = 2;


        List<String> listaErrores;
        List<String> listaTokens;

        public AnalizadorLexico()
        {
            listaErrores = new List<String>();
            listaTokens = new List<String>();


        }

        public void agregaToken(String lexema, int tipo)
        {
            //Añade nuevo token
            String nuevoToken;
            switch (tipo)
            {
                case IDENTIFICADOR:
                    nuevoToken = lexema + " es un identificador" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case REAL:
                    nuevoToken = lexema + " es un número real" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                default:
                    break;
            }
        }

        public void agregaError(String lexema)
        {
            //Añade un error
            String nuevoError;
            nuevoError = lexema + " es un carácter no admitido" + "\n";
            listaErrores.Add(nuevoError);
        }


        public void Analizador(String texto)
        {
            int estado = 0; //Identifica el estado actual del analizador
            String lexema = "";
            Char c;
            bool hayPunto = false; //Bandera para verificar si la expresión es un número y si tiene un punto
            texto = texto + " ";

            //Inicia el automata del analizador
            for (int i = 0; i < texto.Length; i++)
            {
                c = texto[i];
                switch (estado)
                {
                    case INICIAL:
                        if (Char.IsLetter(c) || c == '_') { //Verifica si es letra o empieza con un "_"
                            estado = IDENTIFICADOR;
                            lexema += c;
                        }
                        else if (Char.IsDigit(c)) { //Verifica si es digito
                            estado = REAL;
                            lexema += c;
                        }
                        else if (c == '-') //Verifica si tiene un "-" para números reales
                        {
                            estado = REAL;
                            lexema += c;
                        } else {
                            lexema += c;
                            agregaError(lexema);

                            estado = INICIAL; //Vuelve al estado inicial
                            lexema = "";
                        }
                        break;
                    case IDENTIFICADOR:
                        if (Char.IsLetterOrDigit(c) || c == '_') {
                            estado = IDENTIFICADOR;
                            lexema += c;
                        }
                        else {
                            agregaToken(lexema, IDENTIFICADOR);
                            estado = INICIAL;
                            lexema = "";
                        }
                        break;
                    case REAL:
                        if (Char.IsDigit(c)) {
                            estado = REAL;
                            lexema += c;
                        }
                        else if (c == '.') {
                            if (!hayPunto)
                            {
                                estado = REAL;
                                lexema += c;
                                hayPunto = true;

                            } else {
                                lexema += c;
                                agregaError(lexema);

                                estado = INICIAL;
                                lexema = "";
                            }   
                        }
                        else {
                            agregaToken(lexema, REAL);
                            estado = INICIAL;
                            lexema = "";
                        }
                        break;
                    default:
                        break;
                }
            }
            //Termina el automata
        }

        public String dameListaToken()
        {
            String lista = String.Join(Environment.NewLine, listaTokens.ToArray());
            return lista;

        }

        public String dameListaErrores()
        {
            String lista = String.Join(Environment.NewLine, listaErrores.ToArray());
            return lista;
        }

    }
}
