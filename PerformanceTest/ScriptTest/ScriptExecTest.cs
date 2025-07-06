// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the MIT license.

using WeihanLi.Common.Helpers;

namespace PerformanceTest.ScriptTest;

[ShortRunJob]
public class ScriptExecTest
{
    [Benchmark(Baseline = true)]
    public int DotnetScriptSimple()
    {
        return CommandExecutor.ExecuteCommand("dotnet-script ./assets/hello.csx");
    }
    
    [Benchmark]
    public int DotnetExecSimple()
    {
        return CommandExecutor.ExecuteCommand("dotnet-exec ./assets/hello.csx");
    }
    
    [Benchmark]
    public int DotnetScriptReference()
    {
        return CommandExecutor.ExecuteCommand("dotnet-script ./assets/reference.csx");
    }
    
    [Benchmark]
    public int DotnetExecReference()
    {
        return CommandExecutor.ExecuteCommand("dotnet-exec ./assets/reference.csx");
    }
}
