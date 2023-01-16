using System;
using System.Collections.Generic;




/*
 * 1. Validar si es usuario existente o si se debe registrar y generar un louin
 * 2. El usuario debe darle la bienvenida si es usuario existente
 * 3. El programa debe bluquearse hasta que se registren las 10 personas
 */


/* Mejoras para realizar
 * 1.  Agregar un Switch para validar al final de ejecutar el codido la persona desea confirmar la reseva O CANCELARLA
 * 1.1 Si cancela se borra el array , si acepta se mantiene la info
 */
namespace Restaurante10TableReservations {

    class ProgramaClase {

        static void Main(string[] args)
        {
            
            string nombre;
            int indice,validacion,totalReservas;

            bool isNumber = false;

            Console.WriteLine("Bienvenido.\nCon el animo de garatixzar una grtata experiencia, por favor hacer el registro con numero de cedula.\nPara cuantas personas es su reserva:");
            totalReservas = Convert.ToInt16(Console.ReadLine());
            string[] comensales = new string[totalReservas];



            for (int i = 0;i < totalReservas; i++)
            {
                Console.WriteLine($"Ingrese documento de identidad {i+1}");
              
                nombre = Console.ReadLine();
                isNumber = int.TryParse(nombre, out indice);


                if (nombre =="")
                {
                    Console.WriteLine("Recuerda que para reserver debes ingresar numero de documento");

                    i--;
                    Console.ReadKey();
                    Console.Clear();


                }else if (indice == 0)
                {
                    Console.WriteLine("Recuerda que para reserver debes ingresar numero de documento");

                    i--;
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    validacion = Array.IndexOf(comensales, nombre);
                    



                    if (validacion == -1)
                    {
                        comensales[i] = nombre;
                        Console.WriteLine("** Reserva exitosa **");
                        
                       // Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine($"El documento de identidad {nombre} ya cuenta con una reserva");
                        Console.WriteLine(" Ingrese un nuevo numero de documento");

                        i--;
                        Console.ReadKey();
                        Console.Clear();

                    };



                };



            };

            Console.WriteLine("Se ha confirmado la reserva para las siguientes personas : ");

            foreach (string persona in comensales)
            {


                Console.WriteLine($"Visitante:{persona}");

            };

            Console.ReadKey();

        }
    }

}
