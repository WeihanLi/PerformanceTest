using System.Linq;
using BenchmarkDotNet.Attributes;
using StackExchange.Redis;

namespace PerformanceTest.RedisTest
{
    public class RedisSetMembersTest
    {
        private readonly IDatabase _redis;
        private readonly int _count = 10;

        private const string TestSetKey = "TestSet";

        public RedisSetMembersTest()
        {
            _redis = ConnectionMultiplexer.Connect("127.0.0.1")
                .GetDatabase();

            _redis.SetAdd(TestSetKey, Enumerable.Range(1, 100000).Select(c => (RedisValue)c).ToArray());
        }

        [Benchmark]
        public RedisValue[] SetRandomMembers()
        {
            return _redis.SetRandomMembers(TestSetKey, _count);
        }

        [Benchmark]
        public RedisValue[] SetScan()
        {
            return _redis.SetScan(TestSetKey, pageSize: _count).ToArray();
        }
    }
}
