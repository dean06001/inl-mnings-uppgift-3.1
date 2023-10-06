using System;
namespace inlämningsuppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej hur gammal är du?");
            int boose = int.Parse(Console.ReadLine());
            if (boose >= 16 && boose <=19)
            {
                Console.WriteLine("Grattis du får vara med i tävlingen");
            }
            else if (boose > 19)
            {
                Console.WriteLine("du är för gammal");
            }
            else
            {
                Console.WriteLine("du är för ung");
            }
            Console.ReadKey();
        }
    }
}