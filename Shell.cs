using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa_4_Maicol_Siachoque
{
    internal class Shell
    {
        private int[] vector;

        public Shell()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Vienvenido al metodo de ordenamiento Shell");
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
            for (int i = 0; i < this.vector.Length; i++)
            {
                Console.WriteLine("Numero en la posicion" + (i + 1) + ": " + this.vector[i].ToString());
            }
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadKey();
        }
        public void ordenarVector()
        {
            int salto = 0;
            int a =0;
            int auxi = 0;
            int e = 0;
            salto = this.vector.Length / 2;
            while(salto > 0) 
            {
                a = 1;
                while(a !=0) 
                {
                    a = 0;
                    e = 1;
                    while(e <=(this.vector.Length - salto)) 
                    {
                        if (this.vector[e - 1] > this.vector[(e - 1) + salto]) 
                        {
                            auxi = this.vector[(e - 1)+ salto];
                            this.vector[(e - 1) + salto] = this.vector[e - 1];
                            this.vector[(e - 1)] = auxi;
                            a = 1;

                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
            
            
            Console.WriteLine("Los numeros fueron ordenados correctamente - Presione ENTER para continuar");
            Console.ReadKey();
        }
        public void guardarVectorArchivo()
        {
            string nombreArchivo = "Shell.txt";
            StreamWriter writer = File.AppendText(nombreArchivo);

            for (int i = 0; i < this.vector.Length; i++)
            {
                writer.WriteLine(this.vector[i] + "  ");

            }

            writer.Close();
            Console.WriteLine("El vector ordenado por el metodo shell fue guardado correctamente en el archivo");
            Console.ReadKey();
        }
    }
}

