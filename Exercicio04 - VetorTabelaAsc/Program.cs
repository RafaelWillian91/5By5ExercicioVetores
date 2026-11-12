Console.WriteLine("******** Exercício Vetor ASCII ********");

string[] vetor = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

string[] vetorAsc = new string[20];

void PreencherVetorAscii()
{
    for (int i = 0; i < vetor.Length; i++)
    {
        int posicao = i * 2;

        vetorAsc[posicao] = vetor[i];

        //// vetor[i] acessa a string na posição i do array.
        // [0] acessa o primeiro caractere dessa string.
        // (int) converte o caractere para seu valor numérico (ASCII para letras comuns).
        int codigoAscii = (int)vetor[i][0];

        vetorAsc[posicao + 1] = codigoAscii.ToString();
    }
}

void MostrarVetor()
{
    Console.WriteLine("******** Vetor Original e ASCII ********");

    for (int i = 0; i < vetorAsc.Length; i += 2)
    {
        Console.WriteLine(
            $"Caractere: {vetorAsc[i]} | ASCII: {vetorAsc[i + 1]}"
        );
    }
}

PreencherVetorAscii();
MostrarVetor();