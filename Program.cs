using System;

namespace Aula25Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
           Fibonacci fibona = new Fibonacci();
           fibona.SequenciaFibonacci(0,1,15);
           System.Console.WriteLine(fibona.GerarFatorial(5));


           
        }
    }
}
