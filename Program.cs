using System;

namespace DesviodeFluxo
{
    class Program
    {
        static void Main(string[] args)
        {

            int salario = 1000;
            while (salario<5000){

                salario*=100;
                System.Console.WriteLine("Meu salário ainda é de " + salario);
            }    

            }
        }
    }
