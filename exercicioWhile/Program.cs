using System;

namespace exercicioWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            RepetirNome("tiago");
        }
        
        public static void RepetirNome(string nome)
        {
            var contador = 1;
            while (contador  <= 1000)
            {
                Console.WriteLine(contador + " - " + nome);
                contador++;
            }

        }
    }
}