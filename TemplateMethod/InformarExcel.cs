using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class InformarExcel : IAcciones
    {
        public void Accion()
        {
            Console.Write("Escribo a un excel");
        }
    }
}
