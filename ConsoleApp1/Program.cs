using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(faixaEtaria(13));
        }
        public static string faixaEtaria(short idade)
        {
            if (idade < 12)
            {
                return "crianca";
            }
            else if (idade < 18)
            {
                return "adolescente";
            }
            else if (idade < 60)
            {
                return "adulto";
            }
            else
            {
                return "idoso";
            }
        }
    }

}

