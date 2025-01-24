namespace Exe009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoc;

            Console.Write("Digite o valor do lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");

            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");

            ladoc = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoc) && (ladoA < ladoB + ladoc) && (ladoc < ladoB + ladoc))
            {
                Console.WriteLine("Os valores informados formam um Triângulo.");
            }
            else
            {
                Console.WriteLine("Os valores informados não formam um Triângulo.");
            }

        }
    }
}