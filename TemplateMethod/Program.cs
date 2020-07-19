using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija un método");
            //se indica por un switch y se crea
            int i = 1;
            IAcciones formato = null;
            switch(i)
            {
                case 1: formato = new InformarBD(); break;
                case 2: formato = new InformarExcel(); break;
            }

            formato.Accion();
        }
    }
}
