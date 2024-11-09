using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[MemoryDiagnoser]
public class ContadorPalavras
{
    private const string Arquivo = "C:\\Users\\joaon\\OneDrive\\Área de Trabalho\\Nova pastaTeste\\testeBenchmark.txt";

    [Benchmark]
    public void ContarPalavras()
    {
        var palavras = File.ReadAllLines(Arquivo)
            .SelectMany(linha => linha.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            .GroupBy(palavra => palavra.ToLower())
            .ToDictionary(grupo => grupo.Key, grupo => grupo.Count());
    }
}
