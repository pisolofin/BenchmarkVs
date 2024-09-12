using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace BenchmarkVs.Versus;

[MemoryDiagnoser]
[SimpleJob(RunStrategy.ColdStart, iterationCount: 3)]
[RPlotExporter]
public class AversusB
{
    public AversusB()
    {

    }

    [GlobalSetup]
    public void GlobalSetup()
    {

    }

    [Benchmark]
    public void ScenarioA()
    {
        
    }

    [Benchmark]
    public void ScenarioB()
    {

    }
}
