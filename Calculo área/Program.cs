namespace Calculo_área
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================");
            Console.WriteLine("Controle de Terrenos");
            Console.WriteLine();

            Console.Write("Digite a Largura do Terreno (m) ;");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o comprimento do Terreno (m) ;");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }

        static void AreaTerreno(double l, double c)
        {
            double a= l * c;
            Console.WriteLine($"A área do terreno de {l}m x {c}m é de {a:F2}m².");
        }






    }

}
