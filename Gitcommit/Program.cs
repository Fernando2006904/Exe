namespace Gitcommit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final = 70;
            string resultado = "Aprovado";

            if (nota_final >= 60)
            {
                resultado = "Aprovado";
            }
            else if (nota_final >= 40)
            resultado = "Recuperação";
            else
            {
                resultado = "Reprovado";
            }
            
            Console.WriteLine("O aluno foi {0}.", resultado);
            

            


        }

    }
}
