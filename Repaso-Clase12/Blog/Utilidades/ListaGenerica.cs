using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class ListaGenerica<TElemento>:IEnumerable<TElemento>
    {

        private class Nodo 
        {
            public TElemento Data { get; set; }
            public Nodo Siguiente { get; set; }
            public Nodo(TElemento elemento)
            {
                Data = elemento;
                Siguiente = null;
            }
        }

        private Nodo referencia;

        public ListaGenerica()
        {
            referencia = null;
        }

        public void Agregar(TElemento nuevoElemento)
        {
            Nodo nodo = new Nodo(nuevoElemento);
            nodo.Siguiente = referencia;
            referencia = nodo;
        }

        public IEnumerator<TElemento> GetEnumerator()
        {
            Nodo actual = referencia;
            while (actual != null)
            {
                yield return actual.Data;
                actual = actual.Siguiente;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
