
int N = 10;
int n = 1;



while(n <= N)
{
    int count = 1;

    while (count <= 10)
    {
        int result = n * count;
        Console.Write($"{result,4} |");
        count++;
    }
    Console.WriteLine();
    n++;
}