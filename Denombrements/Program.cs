using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0) 
                { 
                    Environment.Exit(0);
                }

                if (c == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = "); 
                    // le nombre d'éléments à gérer
                    int n = int.Parse(Console.ReadLine()); 
                    long r = 1;
                    for (int k = 1; k <= n; k++)
                        r *= k;
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    if (c == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = "); 
                        // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        // le sous ensemble
                        int n = int.Parse(Console.ReadLine());
                        long r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        //resultat;
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    else
                    {
                        Console.Write("nombre total d'éléments à gérer = "); 
                        // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        // le sous ensemble
                        int n = int.Parse(Console.ReadLine()); 
                        // saisir le nombre
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r1 *= k;
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
                        //resulat;
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
