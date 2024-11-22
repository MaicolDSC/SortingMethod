using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa_4_Maicol_Siachoque
{
    internal class Burbuja
    {
        private int[] vector;

        public Burbuja() 
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Vienvenido al metodo de ordenamiento burbuja");
            Console.WriteLine("-----------------------------------------------");
        }

        public void cargarNumerosVector() 
        {
            Console.Write("Ingrese la cantidad de numeros a ordenar:");

            try 
            {
                int nroElementos = int.Parse(Console.ReadLine());

                if(nroElementos > 0) 
                {
                    this.vector = new int[nroElementos];
                    int valor = 0;

                    for(int i = 0; i < this.vector.Length; i++)
                    {
                        Console.Write(" Ingrese el numero "+(i+1)+": ");
                        valor = int.Parse(Console.ReadLine());
                        this.vector[i] = valor;
                        valor = 0;
                       
                    }
                    Console.WriteLine("Desea ver los numeros ingresados? (s/n):");
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
            for(int i = 0; i < this.vector.Length;i++) 
            {
                Console.WriteLine("Numero en la posicion"+ (i+1) + ": " + this.vector[i].ToString());
            }
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadKey ();
        }
        public void ordenarVector()
        {
            int t;
            for(int a = 1; a  < this.vector.Length;a++) 
            {
                for(int b = this.vector.Length - 1; b >= a; b--) 
                {
                    if (this.vector[b - 1] > this.vector[b]) 
                    {
                        t = this.vector[b - 1];
                        this.vector[b - 1] = this.vector[b];
                        this.vector[b] = t;
                    }
                }
            }
            Console.WriteLine("Los numeros fueron ordenados correctamente - Presione ENTER para continuar");
            Console.ReadKey ();
        }
        public void guardarVectorArchivo() 
        {
            string nombreArchivo = "Burbuja.txt";
            StreamWriter writer=File.AppendText(nombreArchivo);

            for(int i = 0; i < this.vector.Length; i++) 
            {
                writer.WriteLine(this.vector[i]+"  ");

            }

            writer.Close();
            Console.WriteLine("El vector ordenado por el metodo burbuja fue guardado correctamente en el archivo");
            Console.ReadKey ();
        }
    }
}
