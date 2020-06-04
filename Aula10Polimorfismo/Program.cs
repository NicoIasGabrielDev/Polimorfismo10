using System;

namespace Aula09Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Neymar neymar = new Neymar();
            Console.WriteLine("Neymar");
            neymar.Chutar();
            neymar.Driblar();

            CR7 cr7 = new CR7();
            Console.WriteLine("Cristiano Ronaldo");
            cr7.Chutar();
            cr7.Driblar();
        }
    }
}
