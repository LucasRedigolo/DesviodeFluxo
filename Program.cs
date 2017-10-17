using System;

namespace DesviodeFluxo
{
    class Program
    {
        static void Main(string[] args)
        {

            int salario = 1000;
            while (salario<5000){ // repete o comando abaixo sempre que for TRUE

                salario*=100; // *= substitui "salario = salario * 100"
                System.Console.WriteLine("Meu salário ainda é de " + salario);
            }    

            int valor ;

            System.Console.WriteLine("Digite um numero para ver sua tabuada:");
            valor = Int16.Parse(Console.ReadLine()); // parse usado para converter para a variavel desejada (por default um comando READ sempre le string)

            int i;
            for (i = 0; i <= 10; i++)
            {
               System.Console.WriteLine(valor + " x " + i + " = " +(valor * i)); 
            }

            string[] alunos ={"Lucas", "Viviane", "shablau"};

            for (i = 0; i < alunos.Length; i++)
            {
                System.Console.WriteLine("Nome: " + alunos [i]);
            }

            }
        }
    }
