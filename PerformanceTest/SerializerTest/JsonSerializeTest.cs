using System;
using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace PerformanceTest.SerializerTest
{
    public class JsonSerializeTest
    {
        private readonly TestEntity _abc = new TestEntity();

        [Benchmark]
        public byte[] SerializeToString()
        {
            return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(_abc, JsonSerializerHelper.DefaultJsonSerializerSettings));
        }

        [Benchmark]
        public byte[] SerializeToStream()
        {
            using (var ms = new MemoryStream())
            {
                using (var writer = new StreamWriter(ms, Encoding.UTF8))
                {
                    using (var jsonWriter = new JsonTextWriter(writer))
                    {
                        JsonSerializerHelper.DefaultJsonSerializer.Value.Serialize(jsonWriter, _abc);
                    }
                }
                return ms.ToArray();
            }
        }

        private class TestEntity
        {
            public string Abc { get; set; } = "abcdefg";

            public int Aaa { get; set; } = 100;

            public DateTime Time { get; set; } = DateTime.Now;
        }
    }
}