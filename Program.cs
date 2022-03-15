using System;
using System.Text;

namespace Ludus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Total Value
            var  generator = new RandomGenerator();
            var totalGanhos = generator.RandomNumber(5, 100);
            int valorObtido = 0;
            int valorGanho = 0;
            Console.WriteLine("Total ganhos = " + totalGanhos);

            //Nmro de Jogadas
            var nmrJogadas = generator.RandomNumber(1,4);
            Console.WriteLine("Nmro jogadas = " + nmrJogadas);

            //array global com 10  posiçoes
            int[] jogadasRealizadas = new int[10];
            Array.Fill(jogadasRealizadas, -1);

            Console.WriteLine(jogadasRealizadas[3]);

            //digo o nmro de vezes que repito o ciclo com o nmro de jogadas
            //tenho que fazer moneytotal-jogada1 = j1; j1-jogada2 = j2; ...
            
            //Se o nmro de Jogadas for 1, o ganho tem de ser obrigatoriamente igual ao valor gerado
            if(nmrJogadas == 1)
            {
                jogadasRealizadas[0] = totalGanhos;
                Console.WriteLine("Array[0] = " + totalGanhos);
            }
            else if (nmrJogadas == 2){
                var valorGerado = generator.RandomNumber(1,(totalGanhos-1));
                valorObtido = totalGanhos - valorGerado;

                if(valorObtido >= 21)
                {
                    jogadasRealizadas[0] = valorGerado;
                    jogadasRealizadas[1] = 0;
                    jogadasRealizadas[2] = valorObtido;

                    Console.WriteLine("Array[0] = " + jogadasRealizadas[0] + "Array[1] = " + jogadasRealizadas[1] + "Array[2] = " + jogadasRealizadas[2]);
                }
                else
                {
                    jogadasRealizadas[0] = valorGerado;
                    jogadasRealizadas[1] = valorObtido;

                    Console.WriteLine("Array[0] = " + jogadasRealizadas[0] + "Array[1] = " + jogadasRealizadas[1]);
                }
            }else
            {
                Console.WriteLine("not yet done");
            }
        }
    }
    public class RandomGenerator{
        
        private readonly Random _random = new Random();  

        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }

}