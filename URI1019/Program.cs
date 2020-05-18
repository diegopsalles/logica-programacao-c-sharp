using System;

namespace URI1019
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, Horas, Resto, Minutos, Segundos;

            N = int.Parse(Console.ReadLine());

            Horas = N / 3600;
            Resto = N % 3600;
            Minutos = Resto / 60;
            Segundos = Resto % 60;

            Console.WriteLine(Horas + ":" + Minutos + ":" + Segundos);



            Console.ReadKey();
        }
    }
}
