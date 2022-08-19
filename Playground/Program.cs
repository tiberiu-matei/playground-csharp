using BenchmarkDotNet.Running;
using Playground.Benchmark;
using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<TwoSum>();
            BenchmarkRunner.Run<CollectionsBenchmark>();
            // var x = new TwoSum();
            // Console.WriteLine(x.ArrayFilter().ToString());

            Console.ReadLine();
        }
    }
}
