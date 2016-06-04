using Core.Numero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcf.Calculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MiCalculadora : IMiCalculadora
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        Numero IMiCalculadora.RealizarOperacionBinaria(char elOperador, Numero elPrimerNumero, Numero elSegundoNumero)
        {
            throw new NotImplementedException();
        }

        Numero RealizarOperadorBinario(char elOperador, Numero elPrimerNumero, Numero elSegundoNumero)
        {
            var laReferencia = new Core.Numero.Dominio.Especificaciones.RealizarCalculo();
            Numero elResultado = laReferencia.OperadorBinario(elOperador, elPrimerNumero, elSegundoNumero);
            return (elResultado);
        }
    }
}
