using System;
using Primeiro;
using Classes;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Julia;
            Pessoas pessoa3 = (Pessoas)4;

            Animal animal = new Animal();

            animal.Nome = "Olaf";
            animal.NomeDono = "Elaine";
            animal.Especie = "Cachorro";

            Pessoa person = new Pessoa();

            person.Nome = "Esmeraldo";
            person.Idade = 40;
            person.Estado = "PE";

            var person2 = new Pessoa();

            person2.Nome = "Enzo";
            person2.Idade = 07;
            person2.Estado = "SP";           

            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine(pessoa3);
        }
    }
}

      