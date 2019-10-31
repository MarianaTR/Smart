using System;
using System.Collections.Generic;
using System.Text;

namespace probando1
{
    class Class1
    {

        Dictionary<string, List<string>> hola = new Dictionary<string, List<string>>();
        List<string> lista;
        public Class1()
        {
            HELLO();
        }

        public Dictionary<string, List<string>> Hola { get => hola; set => hola = value; }
        

        public void HELLO()
        {
            hola["hola:Imagen1"] = new List<string>() { "julian", "pedro", "jose", "ignacio" };
            hola["barbie:Imagen2"] = new List<string>() { "gabriel", "kati" };
            hola["hola:Imagen3"] = new List<string>() { "julian", "pedro", "jose", "ignacio", "julian", "pedro", "jose", "ignacio" };
            hola["barbie:Imagen4 and name:julian"] = new List<string>() { "gabriel", "kati" };
            hola["hola:Imagen5"] = new List<string>() { "julian", "pedro", "jose", "ignacio" , "gabriel", "kati" , "gabriel", "kati" ,"gabriel", "kati" };
            hola["barbie:Imagen6"] = new List<string>() { "gabriel", "kati", "julian", "pedro", "jose", "ignacio" };
            hola["hola:Imagen7"] = new List<string>() { "julian", "pedro", "jose", "ignacio" };
            hola["barbie:Imagen8"] = new List<string>() { "gabriel", "kati" };
        }

        public void Generar(List<string> li)
        {
            lista = li;
        }

        public delegate void BottomEventHandler(object source, ListEvenArgs args);

        public event BottomEventHandler bottom;

        protected virtual void OnBottom()
        {
            //3.1- Revisar si existen suscriptores
            if (bottom != null)
            {
                //3.2- Se dispara el evento. La fuente es este objeto y EventArgs.Empty ya que no queremos pasar parametros adicionales
                bottom(this, new ListEvenArgs(this.lista));
            }
        }
    }
}
