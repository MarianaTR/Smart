using System;
using System.Collections.Generic;
using System.Text;

namespace probando1
{
    public class ListEvenArgs : EventArgs
    {
        public List<string> lista;

        public ListEvenArgs(List<string> lista)
        {
            this.lista = lista;
        }

       
    }
}
