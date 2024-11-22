/*
Diseñar un ejercicio en donde se le soliciten al usuario una cantidad de 10 números
diferentes y la aplicación ordene los números ingresados según los métodos de
ordenamiento. El ejercicio se debe desarrollar teniendo en cuenta las excepciones y
aplicar los métodos de ordenamiento (Burbuja, Shell, Selección, Inserción).
Adicionalmente cada ejercicio tendrá la posibilidad de generar la salida a través del
manejo de archivos.


 Autor: Maicol David Siachoque Cubides
 cc:1007445168
 Grupo:82

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa_4_Maicol_Siachoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
        menu:
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Bienvenido a la aplicacion de ordenamiento");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Seleccione una de las siguientes opciones:");
            
            Console.WriteLine("1. Metodo de burbuja");
            Console.WriteLine("2. Metodo de insercion");
            Console.WriteLine("3. Metodo de seleccion");
            Console.WriteLine("4. Metodo Shell");
            Console.WriteLine("5. Salir");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Ingrese su opcion: ");
            string opcion = Console.ReadLine();

            try 
            {
                int opcionNro = int.Parse(opcion);

                if(opcionNro >=1 && opcionNro <=5) 
                {
                    switch (opcion)
                    {
                        case "1":
                            Burbuja burbuja = new Burbuja();
                            burbuja.cargarNumerosVector();
                            burbuja.ordenarVector();
                            Console.WriteLine("El vector ordenado por el metodo burbuja es: ");
                            burbuja.mostrarNumerosVector();
                            burbuja.guardarVectorArchivo();
                            goto menu;
                        case "2":
                            Insercion insercion = new Insercion();
                            insercion.cargarNumerosVector();
                            insercion.ordenarVector();
                            Console.WriteLine("El vector ordenado por el metodo insercion es: ");
                            insercion.mostrarNumerosVector();
                            insercion.guardarVectorArchivo();
                            goto menu;
                        case "3":
                            Seleccion seleccion= new Seleccion();
                            seleccion.cargarNumerosVector();
                            seleccion.ordenarVector();
                            Console.WriteLine("El vector ordenado por el metodo burbuja es: ");
                            seleccion.mostrarNumerosVector();
                            seleccion.guardarVectorArchivo();
                            goto menu;
                        case "4":
                            Shell shell = new Shell();
                            shell.cargarNumerosVector();
                            shell.ordenarVector();
                            Console.WriteLine("El vector ordenado por el metodo burbuja es: ");
                            shell.mostrarNumerosVector();
                            shell.guardarVectorArchivo();
                            goto menu;
                        case "5":
                            Console.WriteLine("Gracias por utilizar la aplicacion de ordenamiento");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Se ingreso una opcion no valida del manu");
                            Console.ReadKey();
                            Console.Clear();
                            goto menu;

                    }

                }
                else 
                {
                    Console.WriteLine(" No se ingreso una opcion numerica valida entre 1 y 5, por lo tanto el´programa no continua");
                    Console.ReadKey();
                    Console.Clear();
                    goto menu;

                }

            }
            catch (Exception) 
            {
                Console.WriteLine("No se ingreso una opcion numerica valida entre 1 y 5");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }
            

        }
    }
}
