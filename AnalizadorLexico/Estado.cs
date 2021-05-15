using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class Estado
    {
        private int _intnumeroEstado;

        public int NumeroEstado
        {
            get { return _intnumeroEstado; }
            set { _intnumeroEstado = value; }
        }
        private int _intsiguienteEstado;

        public int SiguienteEstado
        {
            get { return _intsiguienteEstado; }
            set { _intsiguienteEstado = value; }
        }

    }
}
