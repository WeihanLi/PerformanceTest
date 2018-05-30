using System;
using Newtonsoft.Json;

namespace PerformanceTest.SerializerTest
{
    public class JsonSerializerHelper
    {
        public static readonly JsonSerializerSettings DefaultJsonSerializerSettings = new JsonSerializerSettings
        {
            DateFormatString = "yyyy-MM-dd HH:mm:ss",
            NullValueHandling = NullValueHandling.Ignore,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        public static Lazy<JsonSerializer> DefaultJsonSerializer = new Lazy<JsonSerializer>(()=> JsonSerializer.Create(DefaultJsonSerializerSettings));
    }
}