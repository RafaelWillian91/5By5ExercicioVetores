Console.WriteLine("************* Exercício Fibonacci com Vetor*****************");

int numInformadoVetor = 0;
int[] vetor;

void preencherVetorFibonacci()
{
    Console.WriteLine("Entre com o tamanho do vetor:");
    numInformadoVetor = int.Parse(Console.ReadLine());

    vetor = new int[numInformadoVetor];

    vetor[0] = 0;
    vetor[1] = 1;


    for (int i = 2; i < vetor.Length; i++)
    {
        vetor[i] = vetor[i - 1] + vetor[i - 2];
    }

    Console.WriteLine("**** Sequência de Fibonacci ************");

    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine($"Posição {i}: {vetor[i]}");
    }
}

preencherVetorFibonacci();