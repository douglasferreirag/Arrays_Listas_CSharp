using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassesAbstratas_Interfaces.Interfaces;

namespace OperadoresAritmeticosCSharp.Models
{
    public class Calculadora : ICalculadora
    {
        
                public int Somar(int x, int y){

                        return x + y;

                }

                   public int Subtrair(int x, int y){

                        return x - y;

                }

                public int Multiplicar(int x, int y){

                        return x * y;

                }

                public int Dividir(int x, int y){

                        return x / y;

                }

                public void Potencia(int x, int y){

                        double pot = Math.Pow(x,y);
                        Console.WriteLine($"{x} ^{y} = {pot}");

                }

                public void Seno(double angulo){

                       double radiano = angulo * Math.PI / 180;
                        double seno = Math.Sin(radiano);
                        Console.WriteLine($"Seno de {angulo}  = {Math.Round(seno,4)}");

                }

                 public void Cosseno(double angulo){

                       double radiano = angulo * Math.PI / 180;
                        double cosseno = Math.Cos(radiano);
                        Console.WriteLine($"Cosseno de {angulo}  = {Math.Round(cosseno,4)}");

                }

                 public void Tangente(double angulo){

                       double radiano = angulo * Math.PI / 180;
                        double tangente = Math.Tan(radiano);
                        Console.WriteLine($"Tangente de {angulo}  = {Math.Round(tangente,4)}");

                }

                 public void RaizQuadrada(double x){

                       double raiz = Math.Sqrt(x);
                        Console.WriteLine($"Raíz quadrada de {x}  = {raiz}");

                }

             
  }
}