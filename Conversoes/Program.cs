using System;
using System.Threading;

namespace Conversoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dAtual = "29/06/1991";
            DateTime dataAtual = DateTime.Parse(dAtual);
            Console.WriteLine(dataAtual.ToString("dd/MM/yy"));
            Console.WriteLine(dataAtual.ToString("dd/MM/yyy"));
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyyy"));
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyy (ddd)"));
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyy (dddd)"));
            Console.WriteLine(dataAtual.ToString("dd/MMM/yyyy"));
            Console.WriteLine(dataAtual.ToString("dd/MMMM/yyyy"));
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss-ffff"));

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss-fff"));

                Thread.Sleep(500);
            }
        }
    }
}
