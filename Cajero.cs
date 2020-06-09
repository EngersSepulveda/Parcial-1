using System;

namespace Cajero_Atm
{
    class Cajero
    {

        public static void Main(string[] args)
        {
            Menucajero menucajero = new Menucajero();
            menucajero.MenuPrincipal();
            
        }

       

        public void Retiro()
        {

            Console.Clear();
            Console.WriteLine("Por favor inserte el monto que desea retirar");
            int Monto = Convert.ToInt32(Console.ReadLine());
            int retiro = VariableRetiro.MetodoRetiro.OpcionRetiro;
            Menucajero menucajero = new Menucajero();
            Dispensacion dispensacion = new Dispensacion();



            if (retiro == 1)
            {
                if (Monto % 100 == 0)
                {


                    int Mil = Monto / 1000;
                    Monto %= 1000;
                    int Doscientos = Monto / 200;
                    Monto %= 200;

                    Console.WriteLine("se han retirado " + Mil + " billetes de mil");
                    Console.WriteLine("se han retirado " + Doscientos + " billetes de doscientos");
                    Console.WriteLine();
                    Console.WriteLine("Como desea proceder\n1.Salir del cajero\n2.Retirar otro monto\n3.Ir al menu principal");
                    int Descicion1 = Convert.ToInt32(Console.ReadLine());

                    try
                    {


                        switch (Descicion1)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Pase buen dia");
                                break;
                            case 2:
                                Console.Clear();
                                Retiro();
                                break;
                            case 3:
                                Console.Clear();
                                menucajero.MenuPrincipal();
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine("Ha seleccionado una opcion incorrecta sera enviado al menu principal");
                                menucajero.MenuPrincipal();
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Ha seleccionado una opcion incorrecta sera enviado al menu principal");
                        menucajero.MenuPrincipal();
                        throw;
                    }

                    Console.ReadKey();
                }

                Console.Clear();
                Console.WriteLine("El monto insertado no es valido, debe ser igual o mayor que 200 y multiplo de 200nPor favor seleccione el metodo de retiro adecuado");
                Console.ReadKey();
                dispensacion.MenuDispensacion();
            }

            else if(retiro == 2)
            {
                if (Monto % 100 == 0)
                {


                    int Quinientos = Monto / 500;
                    Monto %= 500;
                    int Cien = Monto / 100;
                    Monto %= 100;

                    Console.WriteLine("se han retirado " + Quinientos + " billetes de quinientos");
                    Console.WriteLine("se han retirado " + Cien + " billetes de cien");
                    Console.WriteLine();
                    Console.WriteLine("Como desea proceder\n1.Salir del cajero\n2.Retirar otro monto\n3.Ir al menu principal");
                    int Descicion2 = Convert.ToInt32(Console.ReadLine());

                    try
                    {


                        switch (Descicion2)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Pase buen dia");
                                break;
                            case 2:
                                Console.Clear();
                                Retiro();
                                break;
                            case 3:
                                Console.Clear();
                                menucajero.MenuPrincipal();
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine("Ha seleccionado una opcion incorrecta sera enviado al menu principal");
                                menucajero.MenuPrincipal();
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Ha seleccionado una opcion incorrecta sera enviado al menu principal");
                        menucajero.MenuPrincipal();
                        throw;
                    }

                    Console.ReadKey();
                }

                Console.Clear();
                Console.WriteLine("El monto insertado no es valido, debe ser mayor o igual que 100 y multiplo de 100\nPor favor seleccione el metodo de retiro adecuado");
                Console.ReadKey();
                dispensacion.MenuDispensacion();
            }

            else if (retiro == 3)
            {
                
                if (Monto % 100 == 0)
                {

                    int Mil = Monto / 1000;
                    Monto %= 1000;
                    int Quinientos = Monto / 500;
                    Monto %= 500;
                    int Doscientos = Monto / 200;
                    Monto %= 200;
                    int Cien = Monto / 100;
                    Monto %= 100;

                    Console.WriteLine("se han retirado " + Mil + " billetes de mil");
                    Console.WriteLine("se han retirado " + Quinientos + " billetes de quinientos");
                    Console.WriteLine("se han retirado " + Doscientos + " billetes de doscientos");
                    Console.WriteLine("se han retirado " + Cien + " billetes de cien");
                    Console.WriteLine();
                    Console.WriteLine("Como desea proceder\n1.Salir del cajero\n2.Retirar otro monto\n3.Ir al menu principal");
                    int Descicion3 = Convert.ToInt32(Console.ReadLine());
                    try
                    {

                    
                    switch (Descicion3)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Pase buen dia");
                            break;
                        case 2:
                            Console.Clear();
                            Retiro();
                            break;
                        case 3:
                            Console.Clear();
                            menucajero.MenuPrincipal();
                            break;

                        default:
                                Console.Clear();
                                Console.WriteLine("Ha seleccionado una opcion incorrecta sera enviado al menu principal");
                                menucajero.MenuPrincipal();
                                break;
                    }
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Ha seleccionado una opcion incorrecta sera enviado al menu principal");
                        menucajero.MenuPrincipal();
                        throw;
                    }

                    Console.ReadKey();
                }

                Console.Clear();
                Console.WriteLine("El monto insertado no es valido, debe ser mayor de 100 y multiplo de 100");
                Console.ReadKey();
                dispensacion.MenuDispensacion();
            }
        }
        
        
         
    }
}
