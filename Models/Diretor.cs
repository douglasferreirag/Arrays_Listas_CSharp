using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratas_Interfaces.Models
{
    public class Diretor: Professor
    {

             public sealed override  void Apresentar() {

                        Console.WriteLine($"Diretor);

             }

        
    }
}