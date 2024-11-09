using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<ContadorPalavras>();
    }
}