using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ProcesarInformacion
    {
        public void Procesar(IAcciones metodo, string origen)
        {
            Console.WriteLine("Texto de origen: " + origen);
            //métodos internos...

            //En algún momento llamo a uno o varios métodos de IAcciones
            metodo.Accion();

            //Pero el algoritmo está en TemplateMethod, y se aplican las pertitence acciones particulares según
            //la case que se instancie y se mande en metodo.

            return;
        }
    }
}
