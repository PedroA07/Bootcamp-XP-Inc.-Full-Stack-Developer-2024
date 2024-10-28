using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxe_e_Identação.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {idade} anos!");
        }
    }
}