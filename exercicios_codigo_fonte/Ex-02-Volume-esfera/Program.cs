using System;

namespace Ex_02_Volume_esfera
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaração das variáveis
            double volume, raio;
            Console.Write("Informe o valor do raio: ");

            raio = Convert.ToDouble(Console.ReadLine());

            volume = 4.0/3.0 * 3.14159 * raio * raio * raio;

            Console.WriteLine($"Volume da esfera: {volume}");

            Console.WriteLine("Digite uma tecla para continuar!");

            Console.ReadKey(true);

        }
    }
}
