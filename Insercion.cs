using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa_4_Maicol_Siachoque
{
    internal class Insercion
    {
        private int[] vector;

        public Insercion()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Vienvenido al metodo de ordenamiento insercion");
            Console.WriteLine("-----------------------------------------------");
        }

        public void cargarNumerosVector()
        {
            Console.Write("Ingrese la cantidad de numeros a ordenar:");

            try
            {
                int nroElementos = int.Parse(Console.ReadLine());

                if (nroElementos > 0)
                {
                    this.vector = new int[nroElementos];
                    int valor = 0;

                    for (int i = 0; i < this.vector.Length; i++)
                    {
                        Console.Write(" Ingrese el numero " + (i + 1) + ": ");
                        valor = int.Parse(Console.ReadLine());
                        this.vector[i] = valor;
                        valor = 0;

                    }
                    Console.WriteLine("Desea ver los numeros ingresados? (s/n) :");
                    string opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        this.mostrarNumerosVector();
                    }
                }
                else
                {
                    Console.WriteLine("No se ingreso una cantidad valida, por lo tanto, el porgrama no continuara");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No se ingreso una cantidad valida, por lo tanto, el programa no continuara");
                Console.ReadKey();
            }
        }
        public void mostrarNumerosVector()
        {
            for (int i = 0; i < this.vector.Length; i++)
            {
                Console.WriteLine("Numero en la posicion" + (i + 1) + ": " + this.vector[i].ToString());
            }
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadKey();
        }
        public void ordenarVector()
        {
            int a;
            int j;
            for (int i = 0; i < this.vector.Length; i++)
            {
                a = this.vector[i];
                j = i - 1;
                while(j >= 0 && this.vector[j] > a) 
                {
                    this.vector[j+1] =  this.vector[j];
                    j--;
                }
                this.vector[j + 1] = a;
                
            }
            Console.WriteLine("Los numeros fueron ordenados correctamente - Presione ENTER para continuar");
            Console.ReadKey();
        }
        public void guardarVectorArchivo()
        {
            string nombreArchivo = "Insercion.txt";
            StreamWriter writer = File.AppendText(nombreArchivo);

            for (int i = 0; i < this.vector.Length; i++)
            {
                writer.WriteLine(this.vector[i] + "  ");

            }

            writer.Close();
            Console.WriteLine("El vector ordenado por el metodo insercion fue guardado correctamente en el archivo");
            Console.ReadKey();
        }
    }
}

