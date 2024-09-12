using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using BenchmarkVs.Versus;

Console.WriteLine("######## BenchmarkVs ########");

var config = DefaultConfig.Instance;
var summary = BenchmarkRunner.Run<AversusB>(config, args);
