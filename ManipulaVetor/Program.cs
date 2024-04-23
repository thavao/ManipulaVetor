/*
  2 - faça um programa que leia 10 numeros inteiros e faça:
    - imprima o vetor lido
    - Imprima o vetor invertido
    - imprima até a metade do vetor
    - Guarde o valores pares e impares em um outros vetores (sem o valores 0) e imprima*/

int qtdPares = 0, qtdImpares = 0;
int i = 0, contadorPar = 0, contadorImpar = 0, maximo = 5;
int[] vetorNumeros = new int[maximo];


do
{
    Console.Write($"Digite o {i + 1}º número: ");
    vetorNumeros[i] = int.Parse(Console.ReadLine());


    if (vetorNumeros[i] % 2 == 0)
        qtdPares++;

    else
        qtdImpares++;

    i++;
} while (i < maximo);

Console.Write("Vetor: ");
for (i = 0; i < maximo; i++)
{
    Console.Write(vetorNumeros[i] + " ");
}

Console.WriteLine();

Console.Write("Vetor invertido: ");
for (i = maximo - 1; i >= 0; i--)
{
    Console.Write(vetorNumeros[i] + " ");
}

Console.WriteLine();

Console.Write("Metade do vetor: ");
for (i = maximo; i < maximo/2; i--)
{
    Console.Write(vetorNumeros[i] + " ");
}


int[] vetorPares = new int[qtdPares];
int[] vetorImpares = new int[qtdImpares];

i = 0;
while (i < maximo)
{

    if (vetorNumeros[i] % 2 == 0)
    {
        vetorPares[contadorPar] = vetorNumeros[i];
        contadorPar++;
    }

    else
    {
        vetorImpares[contadorImpar] = vetorNumeros[i];
        contadorImpar++;
    }

    i++;
}

Console.Write("Pares: ");
for (i = 0; i < qtdPares; i++)
{
    Console.Write($" {vetorPares[i]} ");
}

Console.WriteLine();

Console.Write("Impares: ");
for (i = 0; i < qtdImpares; i++)
{
    Console.Write($" {vetorImpares[i]} ");
}

Console.WriteLine();

Console.WriteLine("Pressione Enter para encerrar...");
Console.ReadLine();