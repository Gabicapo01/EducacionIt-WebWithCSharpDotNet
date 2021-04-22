using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Bolsa<TElementoBolsa>
    {
        private TElementoBolsa elementoBolsa;

        public Bolsa(TElementoBolsa elementoContenido)
        {
            elementoBolsa = elementoContenido;
        }

        public TElementoBolsa ReemplazarElemento(TElementoBolsa nuevoElemento)
        {
            TElementoBolsa aux = elementoBolsa;
            elementoBolsa = nuevoElemento;
            return aux;
        }

        public TElementoBolsa VaciarBolsa()
        {
            TElementoBolsa aux = elementoBolsa;
            elementoBolsa = default(TElementoBolsa);
            return aux;
        }

    }
}
