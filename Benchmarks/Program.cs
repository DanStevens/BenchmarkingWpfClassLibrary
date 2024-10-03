namespace Benchmarks
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Environments;
    using BenchmarkDotNet.Jobs;
    using BenchmarkDotNet.Running;
    using WpfClassLibrary;

    internal class Program
    {
        static void Main(string[] args)
        {
            var config = DefaultConfig.Instance
                .AddJob(Job.Default.WithId("net60"))
                .AddJob(Job.Default.WithRuntime(ClrRuntime.Net48).WithId("net48"));
            var results = BenchmarkRunner.Run<WpfClassBenchmarks>(config);
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