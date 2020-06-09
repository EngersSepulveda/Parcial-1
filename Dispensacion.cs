using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_Atm
{
    class Dispensacion
    {
        enum OpcionesMenuDispensacion
        {
            DISP200Y1000 = 1,
            DISP100Y500,
            DISPEFICIENTE,

        }

        public void MenuDispensacion()
        {
            Menucajero menucajero = new Menucajero();
            
            int InstanciaRetiro = Convert.ToInt32(Console.ReadLine());
            VariableRetiro.MetodoRetiro.OpcionRetiro = InstanciaRetiro;
            try
            {

                int OpcionDispensacion = InstanciaRetiro;
                switch (OpcionDispensacion)
                {
                    case (int)OpcionesMenuDispensacion.DISP200Y1000:
                        Console.Clear();
                        Console.WriteLine("Ha seleccionado el metodo de dispensacion de 200 y 1000 \n.Presione una tecla para volver al menu anteriror");
                        Console.ReadKey();
                        Console.Clear();
                        menucajero.MenuPrincipal();
                        break;
                    case (int)OpcionesMenuDispensacion.DISP100Y500:
                        Console.Clear();
                        Console.WriteLine("Ha seleccionado el metodo de dispensacion de 100 y 500 \n.Presione una tecla para volver al menu anteriror");
                        Console.ReadKey();
                        Console.Clear();
                        menucajero.MenuPrincipal();
                        break;
                    case (int)OpcionesMenuDispensacion.DISPEFICIENTE:
                        Console.Clear();
                        Console.WriteLine("Ha seleccionado el metodo de dispensacion de eficiente \n.Presione una tecla para volver al menu anteriror");
                        Console.ReadKey();
                        Console.Clear();
                        menucajero.MenuPrincipal();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Seleccione una opcion Valida");
                        Console.Clear();
                        MenuDispensacion();
                        break;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opcion Valida");
                Console.Clear();
                MenuDispensacion();
                throw;
            }

            
           
        }

        
    }
}
