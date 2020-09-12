using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_pdv_uth_v1
{
    public class CriteriosBusqueda
    {
        public string campo;
        public OperadorDeConsulta operadorIntermedio;
        public string valor;
        public OperadorDeConsulta operadorFinal;

        /// <summary>
        /// Devuelve el texto SQL que corresponde a la consulta del criterio de búsqueda aplicado
        /// </summary>
        /// <returns>String del operado empleado (=, LIKE, menorMayor, !=)</returns>
        public string opIntermedioSql()
        {
            string res = "";
            switch (operadorIntermedio)
            {
                case OperadorDeConsulta.IGUAL: res = "="; break;
                case OperadorDeConsulta.LIKE: res = "LIKE"; break;
                case OperadorDeConsulta.DIFERENTE: res = "<>"; break;
                case OperadorDeConsulta.NO_IGUAL: res = "!="; break;
                default: res = ""; break;
            }
            return res;
        }
        /// <summary>
        /// Texto SQL del operador que requiere unir otra condicion en los criterios de búsqueda, que será AND ú OR.
        /// </summary>
        /// <returns>AND, OR o "" </returns>
        public string opFinalSql()
        {
            string res = "";
            switch (this.operadorFinal)
            {
                case OperadorDeConsulta.AND: res = "AND"; break;
                case OperadorDeConsulta.OR: res = "OR"; break;
                default: res = ""; break;
            }
            return res;
        }
    }

}
