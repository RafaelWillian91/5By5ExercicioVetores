Console.WriteLine("Exercicio Vetor Par e Impar");
int[] vetor = new int[5];
int[] vetorInverso = new int[5];
int[] vetorPar = new int[5]; 
int[] vetorImpar = new int[5];

void preencherVetor()
{
    Console.WriteLine("Entre com 5 numeros inteiros: ");
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine($"Entre com o {i} numero inteiro: ");
        vetor[i] = int.Parse(Console.ReadLine());
    }

}

void preencherVetorOrdemInversa()
{
    Console.WriteLine("-------------------Invertido--------------------------");
    for (int i = 0; i < vetor.Length; i++)
    {
        vetorInverso[i] = vetor[vetor.Length -1 - i];
        Console.WriteLine(vetorInverso[i]);
    }
    Console.WriteLine("------------------------------------------------------");
}

void preencherVetorPar()
{
    int posicaoPar = 0;
    Console.WriteLine("-------------------Vetor Par--------------------------");
    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] % 2 == 0)
        {
            vetorPar[posicaoPar] = vetor[i];
            Console.WriteLine($"impressao Vetor: {vetorPar[posicaoPar]}");
            posicaoPar++;

        }
    }
    Console.WriteLine("------------------------------------------------------");
}

void preencherVetorImpar()
{
    Console.WriteLine("-------------------Vetor Impar--------------------------");
    for (int i = 0; i < vetor.Length; i++)
    {
        if (!(vetor[i] % 2 == 0))
        {
            vetorImpar[i] = vetor[i];
            Console.WriteLine($"impressao Vetor: {vetorImpar[i]}");

        }
    }
    Console.WriteLine("------------------------------------------------------");
}

preencherVetor();
preencherVetorOrdemInversa();
preencherVetorPar();
preencherVetorImpar();