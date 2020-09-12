using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_pdv_uth_v1
{
    public class DatosParaActualizar
    {
        public string campo;
        public string valor;

        public DatosParaActualizar(string campo, string valor)
        {
            this.campo = campo;
            this.valor = valor;
        }
    }
}
