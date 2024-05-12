// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the MIT license.

using BenchmarkDotNet.Running;
using PerformanceTest.DummyTests;

// BenchmarkRunner.Run<RandomListPerfTest>();
// BenchmarkRunner.Run<NewInstanceTest>();
// BenchmarkRunner.Run<RedisSetMembersTest>();
// BenchmarkRunner.Run<EnumerableEmptyTest>();
// BenchmarkRunner.Run<DelegateInvokeTest>();
// BenchmarkRunner.Run<ConcurrentSetTest>();
// BenchmarkRunner.Run<JsonPrettifyTest>();
// BenchmarkRunner.Run<DummyTests.StopwatchPerfTest>();
// BenchmarkRunner.Run<EnumerableChuckTest>();
        
// BenchmarkRunner.Run<TimeProviderLocalTimeUtcTest>();
// BenchmarkRunner.Run<TimeProviderLocalTimeNonUtcTest>();

// BenchmarkRunner.Run<ScriptExecTest>();
BenchmarkSwitcher.FromAssembly(typeof(ToHexStringTest).Assembly).Run(args);
