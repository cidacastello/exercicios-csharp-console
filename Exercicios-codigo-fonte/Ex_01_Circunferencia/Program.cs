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
            
            //entrada de dados - raio recebe o valor digitado
           raio = Convert.ToDouble( Console.ReadLine());
            //valor do PI 3.14159
           area = 3.14159 * raio * raio;
           comprimento = 2 * 3.14159 * raio;

           Console.WriteLine($"Area = {area} e Comprimento = {comprimento}");
            Console.WriteLine("Digite uma tecla para continuar");
           Console.ReadKey(true);


        }
    }
}
