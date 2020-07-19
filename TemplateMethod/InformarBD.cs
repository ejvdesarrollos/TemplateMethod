using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class InformarBD : IAcciones
    {
        public void Accion()
        {
            Console.Write("Informar a BD");
        }
    }
}
