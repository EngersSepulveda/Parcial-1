using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_Atm
{
    enum OpcionesMenuCajero
    {
        DISPENSACION = 1,
        RETIRO,
        CERRAR,
    }

    class Menucajero
    {
       public void  MenuPrincipal()

        {
            Console.WriteLine("Menu de Cajero Automatico.\nPor favor elija la opcion que desea utilizar \n1.Modo de dispensacion de dinero \n2.Retiro de dinero \n3.Salir del Cajero");
            Cajero cajero = new Cajero();
            Dispensacion dispensacion = new Dispensacion();
            try
            {
                int OpcionMenu = Convert.ToInt32(Console.ReadLine());
                switch (OpcionMenu)
                {
                    case (int)OpcionesMenuCajero.DISPENSACION:
                        Console.Clear();
                        Console.WriteLine("Por favor Seleccione el metodo de dispensacion que desea utilizar \n1. Dispensacionde billetes de 200 y 500 \n2. Dispensacion billetes de 100 y 500 \n3. Dispensacion eficiente");
                        dispensacion.MenuDispensacion();
                        break;
                    case (int)OpcionesMenuCajero.RETIRO:
                        cajero.Retiro();
                        break;
                    case (int)OpcionesMenuCajero.CERRAR:
                        Console.Clear();
                        Console.WriteLine("Pase un buen dia");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Seleccione una opcion Valida");
                        MenuPrincipal();
                        break;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opcion Valida");
                MenuPrincipal();
            }
            
        }
    }
}
