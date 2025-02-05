namespace exercicio_novo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o preço do produto: R$");
            double precoProduto = Convert.ToDouble(Console.ReadLine());


            // Calculo do desconto
            double desconto = precoProduto * 0.05;

            double novoPreco = precoProduto - desconto;

            Console.WriteLine($"O preço do produto com 5% de desconto é: R$ {novoPreco:F2}");
        }
    }
}
