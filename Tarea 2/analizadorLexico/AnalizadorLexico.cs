using System;
using System.Collections.Generic;

namespace analizadorLexico
{

    class AnalizadorLexico
    {
        //Símbolos
        public const int ERROR = -1;
        public const int INICIAL = 0;
        public const int IDENTIFICADOR = 1;
        public const int ENTERO = 2;
        public const int REAL = 3;
        public const int CADENA = 4;
        public const int TIPO =  5;
        public const int OPSUMA = 6;
        public const int OPMUL = 7;
        public const int OPRELAC = 8;
        public const int OPOR = 9;
        public const int OPAND = 10;
        public const int OPNOT = 11;
        public const int OPIGUALDAD = 12;
        public const int PUNTOCOMA = 13;
        public const int COMA = 14;
        public const int ABREPARENTESIS= 15;
        public const int CIERRAPARENTESIS = 16;
        public const int ABRELLAVE = 17;
        public const int CIERRALLAVE = 18;
        public const int IGUAL = 19;
        public const int IF = 20;
        public const int WHILE = 21;
        public const int RETURN = 22;
        public const int ELSE = 23;
        public const int SIGNOPESOS = 24;

        public String[] tipoDatos = new String[] { "int", "float", "void" };
        public String[] reservadas = new String[] { "if", "while", "return", "else" };


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
                case ENTERO:
                    nuevoToken = lexema + " es un entero" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case REAL:
                    nuevoToken = lexema + " es un número real" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case CADENA:
                    nuevoToken = lexema + " es una cadena" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case TIPO:
                    nuevoToken = lexema + " es un tipo de dato" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case OPSUMA:
                    if (lexema == "+")
                    {
                        nuevoToken = lexema + " es un operador de suma" + "\n";
                        listaTokens.Add(nuevoToken);
                    }
                    else if (lexema == "-")
                    {
                        nuevoToken = lexema + " es un operador de resta" + "\n";
                        listaTokens.Add(nuevoToken);
                    }
                    break;
                case OPMUL:
                    if (lexema == "*")
                    {
                        nuevoToken = lexema + " es un operador de multiplicación" + "\n";
                        listaTokens.Add(nuevoToken);
                    }
                    else if (lexema == "/")
                    {
                        nuevoToken = lexema + " es un operador de división" + "\n";
                        listaTokens.Add(nuevoToken);
                    }
                    break;
                case OPRELAC:
                    nuevoToken = lexema + " es un operador relacional" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case OPOR:
                    nuevoToken = lexema + " es un operador " + "OR" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case OPAND:
                    nuevoToken = lexema + " es un operador AND" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case OPNOT:
                    nuevoToken = lexema + " es un operador de negación" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case OPIGUALDAD:
                    nuevoToken = lexema + " es un operador de igualdad" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case PUNTOCOMA:
                    nuevoToken = lexema + " es un punto y coma (;)" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case COMA:
                    nuevoToken = lexema + " es una coma (,)" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case ABREPARENTESIS:
                    nuevoToken = lexema + " abre paréntesis" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case CIERRAPARENTESIS:
                    nuevoToken = lexema + " cierra paréntesis" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case ABRELLAVE:
                    nuevoToken = lexema + " abre llave" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case CIERRALLAVE:
                    nuevoToken = lexema + " cierra llave" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case IGUAL:
                    nuevoToken = lexema + " es un operador de igual (=)" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case IF:
                case WHILE:
                case RETURN:
                case ELSE:
                    nuevoToken = lexema + " es una palabra reservada" + "\n";
                    listaTokens.Add(nuevoToken);
                    break;
                case SIGNOPESOS:
                    nuevoToken = lexema + " es el signo $" + "\n";
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
                        if (Char.IsLetter(c) || c == '_')
                        { //Verifica si es letra o empieza con un "_"
                            estado = IDENTIFICADOR;
                            lexema += c;
                        }
                        else if (Char.IsDigit(c))
                        { //Verifica si es digito
                            estado = ENTERO;
                            lexema += c;
                        }
                        else if (c == '"')
                        {
                            estado = CADENA;
                            lexema += c;
                        } 
                        else if(c == '+' || c == '-')
                        {
                            lexema += c;

                            agregaToken(lexema, OPSUMA);
                            estado = INICIAL;
                            lexema = "";
                        }
                        else if (c == '*' || c == '/')
                        {
                            lexema += c;

                            agregaToken(lexema, OPMUL);
                            estado = INICIAL;
                            lexema = "";
                        }
                        else if (c == '<' || c == '>')
                        {
                            estado = OPRELAC;
                            lexema += c;
                        }
                        else if (c == '|')
                        {
                            estado = OPOR;
                            lexema += c;
                        }
                        else if (c == '&')
                        {
                            estado = OPAND;
                            lexema += c;
                        }
                        else if (c == '='|| c == '!')
                        {
                            if (texto[i + 1] != '=')
                            {
                                if (c == '=')
                                {
                                    lexema += c;

                                    agregaToken(lexema, IGUAL);
                                    lexema = "";
                                    estado = INICIAL;
                                }
                                else if (c == '!')
                                {
                                    lexema += c;

                                    agregaToken(lexema, OPNOT);
                                    estado = INICIAL;
                                    lexema = "";
                                }
                            }
                            else
                            {
                                estado = OPIGUALDAD;
                                lexema += c;
                            }
                        }
                        else if (c == ';')
                        {
                            lexema += c;

                            agregaToken(lexema, PUNTOCOMA);
                            estado = INICIAL;
                            lexema = "";
                        }
                        else if (c == ',')
                        {
                            lexema += c;

                            agregaToken(lexema, COMA);
                            estado = INICIAL;
                            lexema = "";
                        }
                        else if (c == '(')
                        {
                            lexema += c;

                            agregaToken(lexema, ABREPARENTESIS);
                            estado = INICIAL;
                            lexema = "";
                        }
                        else if (c == ')')
                        {
                            lexema += c;

                            agregaToken(lexema, CIERRAPARENTESIS);
                            estado = INICIAL;
                            lexema = "";
                        }
                        else if (c == '{')
                        {
                            lexema += c;

                            agregaToken(lexema, ABRELLAVE);
                            estado = INICIAL;
                            lexema = "";
                        }
                        else if (c == '}')
                        {
                            lexema += c;

                            agregaToken(lexema, CIERRALLAVE);
                            estado = INICIAL;
                            lexema = "";
                        }
                        else if (c == '$')
                        {
                            lexema += c;

                            agregaToken(lexema, SIGNOPESOS);
                            estado = INICIAL;
                            lexema = "";
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
                            if (esTipoDato(lexema))
                            {
                                agregaToken(lexema, TIPO);
                                estado = INICIAL;
                                lexema = "";
                            }
                            else if (esReservada(lexema))
                            {
                                agregaToken(lexema, tipoReservada(lexema));
                                estado = INICIAL;
                                lexema = "";
                            }
                            else
                            {
                                agregaToken(lexema, IDENTIFICADOR);
                                estado = INICIAL;
                                lexema = "";
                            }
                        }
                        break;
                    case ENTERO:
                        if (Char.IsDigit(c))
                        {
                            estado = ENTERO;
                            lexema += c;
                        }
                        else if (c == '.')
                        {
                            if (hayPunto == false)
                            {
                                estado = REAL;
                                lexema += c;
                                hayPunto = true;

                            }
                            else
                            {
                                lexema += c;
                                agregaError(lexema);

                                estado = INICIAL;
                                lexema = "";
                            }
                        }
                        else
                        {
                            agregaToken(lexema, ENTERO);
                            estado = INICIAL;
                            lexema = "";
                            i--;
                        }
                        break;
                    case REAL:
                        if (Char.IsDigit(c))
                        {
                            estado = REAL;
                            lexema += c;
                        }
                        else if (c == '.')
                        {
                            if (hayPunto)
                            {
                                lexema += c;
                                agregaError(lexema);

                                estado = INICIAL;
                                lexema = "";
                            }
                        }
                        else
                        {
                            agregaToken(lexema, REAL);
                            estado = INICIAL;
                            lexema = "";
                        }
                        break;
                    case CADENA:
                        if (c == '"')
                        {
                            lexema += c;
                            agregaToken(lexema, CADENA);
                            estado = INICIAL;
                            lexema = "";
                        }
                        else {
                            estado = CADENA;
                            lexema += c;
                        }
                        break;
                    case OPRELAC:
                        if (c == '=')
                        {
                            lexema += c;

                            agregaToken(lexema, OPRELAC);
                            estado = INICIAL;
                            lexema = "";
                        }
                        else
                        {
                            agregaToken(lexema, OPRELAC);
                            estado = INICIAL;
                            lexema = "";
                        }
                        break;
                    case OPOR:
                        if(c == '|')
                        {
                            lexema += c;

                            agregaToken(lexema, OPOR);
                            estado = INICIAL;
                            lexema = "";
                        }
                        else
                        {
                            agregaToken(lexema, OPOR);
                            estado = INICIAL;
                            lexema = "";
                        }
                        break;
                    case OPAND:
                        if (c == '&')
                        {
                            lexema += c;

                            agregaToken(lexema, OPAND);
                            estado = INICIAL;
                            lexema = "";
                        }
                        else
                        {
                            agregaToken(lexema, OPAND);
                            estado = INICIAL;
                            lexema = "";
                        }
                        break;
                    case OPIGUALDAD:
                        lexema += c;

                        agregaToken(lexema, OPIGUALDAD);
                        estado = INICIAL;
                        lexema = "";
                        break;
                    default:
                        break;
                }
            }
            //Termina el automata
        }

        public Boolean esTipoDato(String lexema)
        {
            for (int i = 0; i < tipoDatos.Length; i++)
            {
                if (tipoDatos[i].Equals(lexema))
                {
                    return true;
                }
            }
            return false;
        }


        public Boolean esReservada(String lexema)
        {
            for (int i = 0; i < reservadas.Length; i++)
            {
                if (reservadas[i].Equals(lexema))
                {
                    return true;
                }
            }
            return false;
        }

        public int tipoReservada(String lexema)
        {
            switch (lexema)
            {
                case "if":
                    return IF;
                case "while":
                    return WHILE;
                case "return":
                    return RETURN;
                case "else":
                    return ELSE;
                default:
                    return ERROR;
            }
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
