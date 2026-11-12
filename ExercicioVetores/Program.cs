Console.WriteLine("*********** Impressão Vetor de Caracter **************");


char[] vetor;
int cont = 0;

void InserirDados()
{

    bool validaQtd = true;
    int qtdCaracter = 0;

    while (validaQtd)
    {
        Console.Write("Quantos caracteres deseja inserir (1 a 6)? ");
        qtdCaracter = int.Parse(Console.ReadLine());

        if (qtdCaracter > 0 && qtdCaracter <= 6)
        {
            validaQtd = false;
        }
    }

    vetor = new char[qtdCaracter];

    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write($"Insira a posição {i} do array: ");
        vetor[i] = char.Parse(Console.ReadLine());
    }
   
}

void ImpressaoVetor()
{
    while (cont < vetor.Length)
    {
        Console.WriteLine($"Os valores inseridos são :  {vetor[cont]}");
        cont++;
    }
}

void ImpressaoOrdemInversa()
{
    cont = vetor.Length - 1;
    while (cont >= 0)
    {
        Console.WriteLine($"Os valores inseridos na ordem inversa :  {vetor[cont]}");
        cont--;
    }
}

InserirDados();
ImpressaoVetor();
ImpressaoOrdemInversa();