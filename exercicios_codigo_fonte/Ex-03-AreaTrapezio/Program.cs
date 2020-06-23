using System;

namespace Ex_03_AreaTrapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das variáveis
            double baseMenor, baseMaior, altura, area;

            //entrada de dados
            Console.Write("Informe o valor da base maior: ");
            baseMaior = Convert.ToDouble(Console.ReadLine());

             Console.Write("Informe o valor da base menor: ");
            baseMenor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor da altura: ");
            altura=Convert.ToDouble(Console.ReadLine());

            //processamento
            area = ( (baseMaior + baseMenor)/2)*altura;

            //saída - resposta do problema
            Console.WriteLine("Area do trapezio: " +   area);

            Console.WriteLine("Digite uma tecla para continuar!");

            Console.ReadKey(true);
            
        }
    }
}
