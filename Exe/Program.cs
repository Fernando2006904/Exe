namespace Exe
{
    internal class Program
    {
        static void Main(string[] args)
        {



            {
                static void Main()
                {
                    // Leitura do valor em metros
                    Console.Write("Digite o valor em metros: ");
                    double metros = Convert.ToDouble(Console.ReadLine());

                    // Conversão para centímetros e milímetros
                    double centimetros = metros * 100;
                    double milimetros = metros * 1000;

                    // Exibição dos resultados
                    Console.WriteLine($"{metros} metros equivalem a {centimetros} centímetros ou {milimetros} milímetros.");
                }
            }
        }
    }
}