using BenchmarkDotNet.Running;
using Benchmarking;

var summary = BenchmarkRunner.Run<Benchmark>();
