using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = menúprincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = menúprincipal();
                        break;
                    case 1:
                        opcion = mphone();
                        break;
                    case 2:
                        opcion = mpad();
                        break;
                    case 3:
                        opcion = MAPBrook();
                        break;
                    case 4:
                        opcion = mWatch();
                        break;
                }
            } while (opcion!=5);



            
        }
        private static int menúprincipal()
        {
            Console.Clear();
            Console.Write("" +
            "==============================\n" +
            "Productos de mPhone\n" +
            "==============================\n" +
            "1: Ventas de mPhone 3000\n" +
            "2: Ventas de mPad 3500\n" +
            "3: Ventas de MAPBrook 3800\n" +
            "4: Ventas de mWatch 8000\n" +
            "5: Salir\n" +
            "==============================\n" +
            "Ingrese una opción:");
            return getopcion();
        }

        private static int mphone()
        {
            Console.Clear();
            Console.Write("" +
                         "================================\n" +
                         "Registrar Venta de mPhone 3000\n" +
                         "================================\n" +
                         "1: Registrar Venta\n" +
                         "2: Registrar Devolución\n" +
                         "3: Menu Principal\n" +
                         " ================================\n " +
                         "Ingrese una opción:");
            int opcion = getopcion();
            if(opcion==1) return venta1();
            if (opcion == 2) return devolucion1();
            if(opcion==3) return 0;
            return opcion;
            
        }
        private static int mpad()
        {
                Console.Clear();
            Console.Write("" +
                         "================================\n" +
                         "Registrar Venta de mpad 3500\n" +
                         "================================\n" +
                         "1: Registrar Venta\n" +
                         "2: Registrar Devolución\n" +
                         "3: Menu Principal\n" +
                         " ================================\n " +
                         "Ingrese una opción:");
            int opcion = getopcion();
            if (opcion == 1) return venta2();
            if (opcion == 2) return devolucion2();
            if (opcion == 3) return 0;
            return opcion;
        }
        private static int MAPBrook()
        {
            Console.Clear();
            Console.Write("" +
                         "================================\n" +
                         "Registrar Venta de MAPBrook 3800\n" +
                         "================================\n" +
                         "1: Registrar Venta\n" +
                         "2: Registrar Devolución\n" +
                         "3: Menu Principal\n" +
                         " ================================\n " +
                         "Ingrese una opción:");
            int opcion = getopcion();
            if (opcion == 1) return venta3();
            if (opcion == 2) return devolucion3();
            if (opcion == 3) return 0;
            return opcion;
        }
        private static int mWatch()
        {
            Console.Clear();
            Console.Write("" +
                         "================================\n" +
                         "Registrar Venta de mWatch 8000\n" +
                         "================================\n" +
                         "1: Registrar Venta\n" +
                         "2: Registrar Devolución\n" +
                         "3: Menu Principal\n" +
                         " ================================\n " +
                         "Ingrese una opción:");
            int opcion = getopcion();
            if (opcion == 1) return venta4();
            if (opcion == 2) return devolucion4();
            if (opcion == 3) return 0;
            return opcion;
        }
        private static int venta1()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la venta de un mPhone 3000 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            return getopcion();
        }
        private static int devolucion1()
        {
            Console.Clear();
            Console.WriteLine("================================ ");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la devolución de un mPhone 3000 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No ");
            Console.WriteLine("================================ ");
            Console.WriteLine("Ingrese una opción:");
            return getopcion();
        }
        private static int venta2()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la venta de un mPad 3500  ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            return getopcion();
        }
        private static int devolucion2()
        {
            Console.Clear();
            Console.WriteLine("================================ ");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la devolución de un mPad 3500 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No ");
            Console.WriteLine("================================ ");
            Console.WriteLine("Ingrese una opción:");
            return getopcion();
        }
        private static int venta3()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la venta de un MAPBrook 3800 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            return getopcion();
        }
        private static int devolucion3()
        {
            Console.Clear();
            Console.WriteLine("================================ ");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la devolución de un MAPBrook 3800 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No ");
            Console.WriteLine("================================ ");
            Console.WriteLine("Ingrese una opción:");
            return getopcion();
        }
        private static int venta4()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la venta de un mWatch 8000 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            return getopcion();
        }
        private static int devolucion4()
        {
            Console.Clear();
            Console.WriteLine("================================ ");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================ ");
            Console.WriteLine("Se va a registrar la devolución de un mWatch 8000 ");
            Console.WriteLine("¿Desea Continuar ? ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No ");
            Console.WriteLine("================================ ");
            Console.WriteLine("Ingrese una opción:");
            return getopcion();
        }


        private static int getopcion()
        {
            string opciontexto = Console.ReadLine();
            return int.Parse(opciontexto);
        }
    }
}
