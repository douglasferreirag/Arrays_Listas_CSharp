using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassesAbstratas_Interfaces.Models;

namespace ClassesAbstratas_Interfaces.Models
{
    public class Professor : Pessoa
    {

            public decimal Salario { get; set; }

          public Professor() {
          } 

            public Professor(string nome) : base(nome)
            {
                


            }

            public override  void Apresentar() {

                        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos , sou um professor e ganho {Salario} ");

             }
        
    }
}