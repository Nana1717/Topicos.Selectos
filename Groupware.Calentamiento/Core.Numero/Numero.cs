using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero
{
    public class Numero
    {
        public string elNumero { get; set; }
        public int laBase { get; set; }

        public bool esBaseDiez
        {
            get
            {
                return laBase == 10;
            }
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            Numero other = obj as Numero;
            if (other == null)
            {
                return false;
            }
            return (this.elNumero == other.elNumero) &&
                (this.laBase == other.laBase);
        }

        public double elNumeroEnDecimal
        {
            get
            {
                return double.Parse(elNumero);
            }
        }

        public Numero(string elNumero, int laBase)
        {
            //instancie una validacion del numero
            var validacionBase = new Dominio.Validaciones.ValidarBase();
            var validacionNumero = new Dominio.Validaciones.ValidarNumero();
            if (validacionBase.LaBaseEstaEnElIntervaloCorrecto(laBase) &
                validacionNumero.ElNumeroEsValidoEnLaBase(elNumero, laBase))
            {
                this.laBase = laBase;
                this.elNumero = elNumero;
            }
            else
            {
            }

        }
    }
}
