namespace Benchmarks
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Jobs;
    using BenchmarkDotNet.Running;
    using WpfClassLibrary;

    internal class Program
    {
        static void Main(string[] args)
        {
            var results = BenchmarkRunner.Run<WpfClassBenchmarks>();
        }
    }

    //[SimpleJob(RuntimeMoniker.Net48)]
    //[SimpleJob(RuntimeMoniker.Net60)]
    public class WpfClassBenchmarks
    {
        [Benchmark]
        public void WpfClass()
        {
            _ = new WpfClass();
        }
    }
}