using Program;
using Xunit;

namespace tests;

public class RunnerTests
{
    [Fact]
    public void Run_it()
    {
        var runner = new Runner();
        runner.Run();
    }
}