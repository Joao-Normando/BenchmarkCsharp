using BenchmarkDotNet.Attributes;

public class FactorialBenchmark
{
    private const int N = 10;

    [Benchmark]

    public long FactorialCsharp()
    {
        long result = 1;
        for (int i = 2; i <= N; i++)
        {
            result *= i;
        }
        return result;
    }
}