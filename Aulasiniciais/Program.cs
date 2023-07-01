using System;
using System.Threading;

namespace Aulasiniciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite sua idade");
            var idade =int.Parse (Console.ReadLine());
            VerificarMaioridade(idade);
            Thread.Sleep(5000);
            
        }
        public static void VerificarMaioridade(int idade)
        {
            if (idade >= 18)
            {
                Console.WriteLine("É maior de idade");
            }
            else
            {
                Console.WriteLine("É menor de idade");
            }
        }
    }
}
