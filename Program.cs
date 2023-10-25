using Lab10.funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string objeto = "";
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = funcionesPrograma.menuPrincipal();
                        switch (opcion)
                        {
                            case 1: objeto = "mPhone 3000"; opcion = 1; break;
                            case 2: objeto = "mPad 3500"; opcion = 1; break;
                            case 3: objeto = "MAPBrook 3800"; opcion = 1; break;
                            case 4: objeto = "mWatch 8000"; opcion = 1; break;
                            case 5: opcion = 6; break;
                        }
                        break;
                    case 1:
                        opcion = funcionesPrograma.registrarObjeto(objeto);
                        break;
                    case 2:
                        opcion = funcionesPrograma.ObjetoDevolucion(objeto);
                        break;
                    case 3:
                        opcion = funcionesPrograma.ObjetoVenta(objeto);
                        break;
                }
            } while (opcion != 6);
            funcionesPrograma.salir();

        }
    }
}