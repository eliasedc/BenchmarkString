using BenchmarkDotNet.Running;
using TesteBanchMark;

Console.WriteLine("### Using BenchmarkDotNet  ###\r\n");
Console.WriteLine("Press Enter to start\r\n");
Console.ReadLine();
var resultado =  BenchmarkRunner.Run<BenchmarkStringTest>();
Console.WriteLine("Finished");
Console.ReadLine();