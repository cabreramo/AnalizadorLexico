using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class Automata
    {
        int[,] MatrizTransicion = new int[5, 5];
        List<Estado> diagramaTransiciones = new List<Estado>();

        private Estado _intEstadoActual;
        public Estado EstadoActual
        {
            get { return _intEstadoActual; }
            set { _intEstadoActual = value; }
        }
        private bool _blntokenValido;

        public bool TokenValido
        {
            get { return _blntokenValido; }
            set { _blntokenValido = value; }
        }
        public Automata()
        {
            MatrizTransicion[1, 1] = 2;
            MatrizTransicion[2, 1] = 4;
            MatrizTransicion[3, 1] = 4;
            MatrizTransicion[4, 1] = 4;

            MatrizTransicion[1, 2] = 2;
            MatrizTransicion[2, 2] = 2;
            MatrizTransicion[3, 2] = 2;
            MatrizTransicion[4, 2] = 3;

            MatrizTransicion[1, 3] = 4;
            MatrizTransicion[2, 3] = 4;
            MatrizTransicion[3, 3] = 4;
            MatrizTransicion[4, 3] = 4;

            MatrizTransicion[1, 4] = 4;
            MatrizTransicion[2, 4] = 4;
            MatrizTransicion[3, 4] = 4;
            MatrizTransicion[4, 4] = 4;

            Estado estado1 = new Estado();
            estado1.NumeroEstado = 1;
            diagramaTransiciones.Add(estado1);

            Estado estado2 = new Estado();
            estado2.NumeroEstado = 2;
            diagramaTransiciones.Add(estado2);

            Estado estado3 = new Estado();
            estado3.NumeroEstado = 3;
            diagramaTransiciones.Add(estado3);

            Estado estado4 = new Estado();
            estado4.NumeroEstado = 4;
            diagramaTransiciones.Add(estado4);

            EstadoActual = new Estado();
            EstadoActual = estado1;

        }
        public int buscarSiguienteEstado(char caracterActual)
        {
            
            EstadoActual = diagramaTransiciones[MatrizTransicion[IdentificarExpresion(caracterActual), EstadoActual.NumeroEstado] - 1];
            return EstadoActual.NumeroEstado;
        }
        public int IdentificarExpresion(char caracter)
        {
            if (char.IsLetter(caracter))
            {
                return 1; //1 Representa letras
            }
            else if (char.IsDigit(caracter))
            {
                return 2; //2 Representa digitos
            }
            else if (caracter == '-')
            {
                return 3; //3 Representa guion 
            }
            else if (char.IsWhiteSpace(caracter))
            {
                return 4; //4 Representa FDC, en este caso espacio en blanco
            }
            else
            {
                return default;
            }
        }

    }
}
