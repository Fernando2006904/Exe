namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tabuada do {0}", numero);
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"{i} * {numero} = {i * numero}");
            }

            

        }
    }
}
