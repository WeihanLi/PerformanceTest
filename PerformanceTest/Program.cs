﻿// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the MIT license.

using BenchmarkDotNet.Running;
using PerformanceTest.CollectionTest;

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
// BenchmarkRunner.Run<FrozenSetTest>();

BenchmarkSwitcher.FromAssembly(typeof(FrozenSetTest).Assembly).Run(args);
