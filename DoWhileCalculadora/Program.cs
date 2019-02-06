using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {               
            

            float valor1, valor2, opcion;
            string linea;

            do

            {


                Console.WriteLine("MENÚ");
                Console.WriteLine("");
                Console.WriteLine("Opción 1 - Suma 2 números");
                Console.WriteLine("Opción 2 - Resta 2 números");
                Console.WriteLine("Opción 3 - Multiplica 2 números");
                Console.WriteLine("Opción 4 - Divide 2 números");
                Console.WriteLine("Cualquier número fuera de las opciones - Salir");
                Console.WriteLine("");
                Console.WriteLine("Elige una opción");

                linea = Console.ReadLine();
                opcion = float.Parse(linea);
            
            
             
                if (opcion == 1)
                {
                    Console.WriteLine("Haz elegido la opción {0}", opcion);
                    Console.WriteLine("");
                    Console.WriteLine("Ingresa el primer número");
                    linea = Console.ReadLine();
                    valor1 = float.Parse(linea);
                    Console.WriteLine("Ingresa el segundo número");
                    linea = Console.ReadLine();
                    valor2 = float.Parse(linea);
                    Console.WriteLine("");
                    Console.WriteLine("La suma de ambos números es: ");
                    Console.WriteLine(valor1 + valor2);
                    Console.WriteLine("");
                }

                else
                {
                    if (opcion == 2)

                    {
                        Console.WriteLine("Haz elegido la opción {0}", opcion);
                        Console.WriteLine("");
                        Console.WriteLine("Ingresa el primer número");
                        linea = Console.ReadLine();
                        valor1 = float.Parse(linea);
                        Console.WriteLine("Ingresa el segundo número");
                        linea = Console.ReadLine();
                        valor2 = float.Parse(linea);
                        Console.WriteLine("");
                        Console.WriteLine("La resta de ambos números es: ");
                        Console.WriteLine(valor1 - valor2);
                        Console.WriteLine("");
                    }
                    else
                    {

                        if (opcion == 3)

                        {
                            Console.WriteLine("Haz elegido la opción {0}", opcion);
                            Console.WriteLine("");
                            Console.WriteLine("Ingresa el primer número");
                            linea = Console.ReadLine();
                            valor1 = float.Parse(linea);
                            Console.WriteLine("Ingresa el segundo número");
                            linea = Console.ReadLine();
                            valor2 = float.Parse(linea);
                            Console.WriteLine("");
                            Console.WriteLine("La multiplicación de ambos números es: ");
                            Console.WriteLine(valor1 * valor2);
                            Console.WriteLine("");
                        }

                        else
                        {
                            if (opcion == 4)

                            {
                                Console.WriteLine("Haz elegido la opción {0}", opcion);
                                Console.WriteLine("");
                                Console.WriteLine("Ingresa el primer número");
                                linea = Console.ReadLine();
                                valor1 = float.Parse(linea);
                                Console.WriteLine("Ingresa el segundo número");
                                linea = Console.ReadLine();
                                valor2 = float.Parse(linea);
                                Console.WriteLine("");
                                Console.WriteLine("La división de ambos números es: ");
                                Console.WriteLine(valor1 / valor2);
                                Console.WriteLine("");
                            }
                        }
                    }

                }

                {

                }
           
                    
            }

            while (opcion < 5);

            Console.WriteLine("Gracias por usar SUPER CALCULADORA");
            Console.ReadKey();
        }
    }
}
