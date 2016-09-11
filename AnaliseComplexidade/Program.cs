using System;
using System.Diagnostics;

namespace AnaliseComplexidade
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Incremental
            var n10 = Fatorial(10);
            var n100 = Fatorial(100);
            var n1000 = Fatorial(1000);
            var n10000 = Fatorial(10000);
            var n100000 = Fatorial(100000);
            var n1000000 = Fatorial(1000000); 

            //Recursivos
            var watch = new Stopwatch();
            watch.Start();
            FatRecursivo(10);
            watch.Stop();
            var ts = watch.ElapsedMilliseconds;
            var recA10 = "Com 10 entradas no algoritmo recursivo, o tempo de execução foi: " + ts + " ms.";

            watch.Reset();
            watch.Start();
            FatRecursivo(100);
            watch.Stop();
            ts = watch.ElapsedMilliseconds;
            var recA100 = "Com 100 entradas no algoritmo recursivo, o tempo de execução foi: " + ts + " ms.";

            watch.Reset();
            watch.Start();
            FatRecursivo(1000);
            watch.Stop();
            ts = watch.ElapsedMilliseconds;
            var recA1000 = "Com 1000 entradas no algoritmo recursivo, o tempo de execução foi: " + ts + " ms.";

            watch.Reset();
            watch.Start();
            FatRecursivo(10000);
            watch.Stop();
            ts = watch.ElapsedMilliseconds;
            var recA10000 = "Com 10000 entradas no algoritmo recursivo, o tempo de execução foi: " + ts + " ms.";

            var recA1000000 = "Com  100.000 e 1.000.000 entradas no algoritmo recursivo, deu erro de loop infinito";



            Console.WriteLine(n10 + "\n");
            Console.WriteLine(n100 + "\n");
            Console.WriteLine(n1000 + "\n");
            Console.WriteLine(n10000 + "\n");
            Console.WriteLine(n100000 + "\n");
            Console.WriteLine(n1000000 + "\n");
            Console.WriteLine(recA10 + "\n");
            Console.WriteLine(recA100 + "\n");
            Console.WriteLine(recA1000 + "\n");
            Console.WriteLine(recA10000 + "\n");

            Console.ReadLine(); 

        }

        public static string Fatorial(int n)
        {
            var watch = new Stopwatch();
            watch.Start();

            var x = n;

            for (int i = 1; i < n; i++)
            {
                n = n * i;
                i++;
            }

            watch.Stop();
            var ts = watch.ElapsedMilliseconds;

            return "Com " + x + " entradas no algoritmo incremental, o tempo de execução foi: " + ts + " ms.";
        }

        public static int FatRecursivo(int n)
        {
            if (n == 1)
                return 1;
            else
                return (n * FatRecursivo(n - 1));
        }

    }
}
