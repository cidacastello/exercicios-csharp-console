using System;

namespace Ex_01_Circunferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das variáveis
            double raio, area, comprimento;
            Console.Write("Informe o valor do raio: ");

            //valor do PI 3.14159
            raio = Convert.ToDouble( Console.ReadLine());

            area = 3.14159 * raio * raio;

            comprimento = 2 * 3.14159 * raio;

            Console.WriteLine($"Area = {area} e comprimento = {comprimento}");
            Console.WriteLine("Pressione uma tecla para sair");
            Console.ReadKey(true);

        }
    }
}
