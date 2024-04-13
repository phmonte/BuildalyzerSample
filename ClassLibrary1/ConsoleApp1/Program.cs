using Buildalyzer;

var manager = new AnalyzerManager();
var analyzer = manager.GetProject(@"../../../../ClassLibrary1/ClassLibrary1.csproj");

Console.WriteLine("1");

_ = analyzer.Build();

Console.WriteLine("2");