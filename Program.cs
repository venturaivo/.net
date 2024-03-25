class Program
{
    static void Main(string[] args)
    {
        // Solicitar ao usuário dois números inteiros
        Console.Write("Por favor, insira o primeiro número inteiro: ");
        int primeiroNumero = int.Parse(Console.ReadLine());

        Console.Write("Por favor, insira o segundo número inteiro: ");
        int segundoNumero = int.Parse(Console.ReadLine());

        // Verificar se o segundo número é diferente de zero para evitar uma divisão por zero
        if (segundoNumero != 0)
        {
            // Calcular e apresentar o resultado da divisão do primeiro pelo segundo
            double resultadoDivisao = (double)primeiroNumero / segundoNumero;
            Console.WriteLine($"O resultado da divisão de {primeiroNumero} por {segundoNumero} é: {resultadoDivisao}");
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero. Por favor, insira um segundo número diferente de zero.");
        }
    }
}