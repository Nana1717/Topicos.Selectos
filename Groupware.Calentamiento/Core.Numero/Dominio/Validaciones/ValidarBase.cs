using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarBase
    {
        public bool LaBaseEstaEnElIntervaloCorrecto (int laBase)
        {
            bool resultado;
            resultado = (2 <= laBase) & (laBase <= 16);
                return (resultado);
        }

        public bool LasDosBasesSonIguales (Numero elPrimerNumero, Numero elSegundoNumero)
        {
            bool resultado;
            resultado = (elPrimerNumero.laBase == elSegundoNumero.laBase);
            return resultado;
        }
    }
}
