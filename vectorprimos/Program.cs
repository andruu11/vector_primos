using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectorprimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una opcion [1] mostrar una determinada cantidad de primos");
            Console.WriteLine("Introduzca una opcion [2] mostrar primos segun un inicio y limite definido");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Introduzca la cantidad de primos que desea visualizar en el vector:");
                int x = Convert.ToInt32(Console.ReadLine());
                int[] primos = new int[x];
                int inicio = 0;
                int fin = 1000;
                int contador;
                int contadorprimos = 0;
                int interruptor = 0;
                while (interruptor != 1)
                {
                    for (int i = inicio; i <= fin; i++)
                    {
                        contador = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                contador = contador + 1;
                            }
                        }
                        if (contadorprimos == x)
                        {
                            interruptor = 1;
                        }
                        else
                        {
                            if (contador == 2)
                            {
                                for (int f = 0; f < 1; f++)
                                {
                                    primos[f] = i;
                                    Console.WriteLine("El " + (contadorprimos + 1) + " primo es:" + primos[f] + "");
                                    contadorprimos++;

                                }
                            }
                        }
                    }
                }
            }
            else {
                int inicio, fin, contador;
                Console.WriteLine("inicio");
                inicio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("fin");
                fin = Convert.ToInt32(Console.ReadLine());
                int[] primos = new int[50];
                for (int i = inicio; i <= fin; i++)
                {
                    contador = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            contador = contador + 1;
                        }
                    }
                    if (contador == 2)
                    {
                        for (int f = 0; f < 1; f++)
                        {
                            primos[f] = i;
                            Console.WriteLine("El " + " primo es:" + primos[f] + "");
                           

                        }
                    }
                    
                }
            
            
            }
            Console.ReadKey();
            
        }
    }
}
