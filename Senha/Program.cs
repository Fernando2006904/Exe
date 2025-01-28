namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123"; // Senha correta
            string senhaDigitada; // Senha digitada do usuário
            int tentativas = 0; // Contador de tentativas

            // Loop para solicitar a senha ao usúario
            do
            {

                Console.Clear();
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++; // incrementa o contador de tentativas 

                // Verifica se a senha digitada é diferente da senha correta
                if (senhaDigitada != senha && tentativas > 3)
                {
                    Console.WriteLine("Senha Incorreta!");
                    Console.WriteLine("Você tem ainda" + (3 - tentativas) + "tentativa(s)");
                    Console.ReadKey();

                }
                else if(senhaDigitada != senha && tentativas == 3)
                {
                    Console.WriteLine("Senha incorreta! Seu acesso está bloqueado");
                    return;
                }




            }
            while (senhaDigitada != senha);
            Console.Clear() ;
            Console.WriteLine("Senha Correta! - tentativas: " + tentativas);

        }
    }
}
