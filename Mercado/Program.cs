using System;
using System.Collections.Generic;

namespace Mercado
{
    public class Program
    {
        static void Main(string[] args)
        {
            var chama = new Mercado();

            chama.Nome = "Chama Super Mercados";
            chama.Id = 237;
            chama.Funcionarios = new List<Funcionario>();

            chama.Funcionarios.Add(new Funcionario { Id = 1, Nome = "Bob", Idade = 48 });
            chama.Funcionarios.Add(new Funcionario { Id = 2, Nome = "Angela", Idade = 37 });
            chama.Funcionarios.Add(new Funcionario { Id = 3, Nome = "Tim", Idade = 23 });
            chama.Funcionarios.Add(new Funcionario { Id = 4, Nome = "Marcelo", Idade = 50 });

            string nome = chama.Funcionarios[3].Nome;

            Console.WriteLine(nome);
        }
    }
}
