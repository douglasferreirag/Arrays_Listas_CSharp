using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratas_Interfaces.Models
{
    public class Pessoa
    {

            public string? Nome { get; set; }
            public int Idade { get; set; }

            public Pessoa(){

            }

            public Pessoa(string nome){

                         Nome = nome;

                }

            public virtual  void Apresentar(){

                    Console.WriteLine($"Olá, meu nome é:  {Nome} , e tenho {Idade} anos");

            }

        
    }
}