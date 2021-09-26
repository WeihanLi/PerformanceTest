using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace PerformanceTest.SerializerTest
{
    public class JsonPrettifyTest
    {
        const string TestJsonString = @"[{""Name"":""Ming"",""Age"":10}]";


        [Benchmark]
        public string SystemJson_JsonDocument()
        {
            using var doc = JsonDocument.Parse(TestJsonString);
            using var ms = new MemoryStream();
            using var jsonWriter = new Utf8JsonWriter(ms, new JsonWriterOptions() { Indented = true });
            doc.WriteTo(jsonWriter);
            jsonWriter.Flush();

            var formattedJson = Encoding.UTF8.GetString(ms.ToArray());
            return formattedJson;
        }

        [Benchmark]
        public string JsonNet_ReaderWriter()
        {
            using var stringReader = new StringReader(TestJsonString);
            using var stringWriter = new StringWriter();
            using var jsonReader = new JsonTextReader(stringReader);
            using var jsonWriter = new JsonTextWriter(stringWriter)
            {
                Formatting = Formatting.Indented
            };
            jsonWriter.WriteToken(jsonReader);
            jsonWriter.Flush();

            var formattedJson = stringWriter.ToString();
            return formattedJson;
        }

        [Benchmark(Baseline = true)]
        public string JsonNet_JTokenToString()
        {
            var formattedJson = JToken.Parse(TestJsonString).ToString(Formatting.Indented);
            return formattedJson;
        }
    }
}
