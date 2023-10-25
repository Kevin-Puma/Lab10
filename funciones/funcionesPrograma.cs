using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.funciones
{
    public class funcionesPrograma
    {
        static int mPhonevent = 0;
        static int mPadvent = 0;
        static int MAPvent = 0;
        static int mWvent = 0;
        public static int menuPrincipal()
        {
            Console.Clear();
            Console.Write("================================\n" +
                          "Productos de mPhone\n" +
                          "================================\n" +
                          "1: Ventas de mPhone 3000\n" +
                          "2: Ventas de mPad 3500\n" +
                          "3: Ventas de MAPBrook 3800\n" +
                          "4: Ventas de mWatch 8000\n" +
                          "5: Salir\n");
            return getOpcion();
        }


        public static int registrarObjeto(string obj)
        {
            Console.Clear();
            Console.Write("================================\n" +
                          "Registrar Venta de " + obj + "\n" +
                          "================================\n" +
                          "1: Registrar Venta\n" +
                          "2: Registrar Devolución\n" +
                          "3: Menu Principal\n");
            int opcion = getOpcion();
            if (opcion == 1) return 3;
            if (opcion == 2) return 2;
            if (opcion == 3) return 0;
            return opcion;
        }
        public static int ObjetoVenta(string obj)
        {
            Console.Clear();
            Console.Write("================================\n" +
                "Registrar venta de:\n" +
                "================================\n" +
                "Se va a registrar la venta de un " + obj + " ¿Desea Continuar?\n" +
                "1: Sí\n" +
                "2: No\n");
            int opcion = getOpcion();
            if (opcion == 1)
            {
                switch (obj)
                {
                    case "mPhone 3000": mPhonevent++; break;
                    case "mPad 3500": mPadvent++; break;
                    case "MAPBrook 3800": MAPvent++; break;
                    case "mWatch 8000": mWvent++; break;
                }
            }
            return 1;
        }
        public static int ObjetoDevolucion(string obj)
        {
            Console.Clear();
            Console.Write("================================\n" +
                "Registrar devolución de:\n" +
                "================================\n" +
                "Se va a registrar la devolución de un " + obj + " ¿Desea Continuar?\n" +
                "1: Sí\n" +
                "2: No\n");
            int opcion = getOpcion();
            if (opcion == 1)
            {
                switch (obj)
                {
                    case "mPhone 3000": mPhonevent--; break;
                    case "mPad 3500": mPadvent--; break;
                    case "MAPBrook 3800": MAPvent--; break;
                    case "mWatch 8000": mWvent--; break;
                }
            }
            return 1;
        }
        public static void salir()
        {
            Console.WriteLine("================================\n" +
                               "Reporte Final\n" +
                               "================================\n" +
                               "Productos Vendidos | Cantidad\n" +
                               "--------------------------------\n" +
                               $"mPhones            | {mPhonevent}\n" +
                               $"mPads              | {mPadvent}\n" +
                               $"MAPBrooks          | {MAPvent}\n" +
                               $"mWatches           | {mWvent}\n" +
                               "--------------------------------\n" +
                               "Total              | " +
                               (mPhonevent + mPadvent + MAPvent + mWvent) +
                               "\n================================\n¡Hasta Luego!\nDiseñado Por: Jhon Kevin Puma Luis");
            Console.ReadKey();
        }

        public static int getOpcion()
        {
            Console.Write("================================\n" +
                          "Ingrese una opción: ");
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }
    }
}
