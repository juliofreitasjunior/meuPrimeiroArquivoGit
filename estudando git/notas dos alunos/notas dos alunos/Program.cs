using System;

namespace notas_dos_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que capture o nome e 2 notas do aluno, no final do programa de o nome do aluno e a média, ou seja, para cada aluno mostre o seu nome e a sua média.



            int n = 0;

            Console.WriteLine("Informe qual o numero deseja a tabuada");
            int numero = Convert.ToInt32(Console.ReadLine());
            int res;

            while (n <= 10)
            {
                res = numero * n;
                Console.Write(n+ " * " + numero + " = " + res + "\n");
                
                n++;
            }
           


            Console.ReadKey();

            
        }
    }
}
