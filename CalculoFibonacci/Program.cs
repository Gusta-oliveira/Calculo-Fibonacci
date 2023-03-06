internal class Program
{
    private static void Main(string[] args)
    {
        int digit_u =0, ant = 1, prox = 0, atual = 1;

        Console.WriteLine("Informe o número para o cálculo ");
        digit_u = int.Parse(Console.ReadLine());
        Console.Write($"A sequencia fibonacci de {digit_u} é: ");
        for (int count = 0; count < digit_u; count++) {
            Console.Write(ant + " ");
            prox = atual + ant;
            ant = atual;
            atual = prox;
        }
    }
}