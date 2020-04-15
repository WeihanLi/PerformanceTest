using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using WeihanLi.Npoi;

namespace PerformanceTest.ExcelTest
{
    [Config(typeof(Config))]
    public class FluentFormatterTest
    {
        private class Config : ManualConfig
        {
            public Config()
            {
                var baseJob = Job.MediumRun;

                AddJob(baseJob.WithNuGet("WeihanLi.Npoi", "1.9.0-preview-20200413-122712").WithId("1.9.0-pre"));
                AddJob(baseJob.WithNuGet("WeihanLi.Npoi", "1.8.2").WithId("1.8.2"));
            }
        }

        private readonly IReadOnlyCollection<TestEntity> _testEntities;

        public FluentFormatterTest()
        {
            var setting = ExcelHelper.SettingFor<TestEntity>();

            setting.Property(x => x.Id)
                .HasColumnTitle("Id");
            setting.Property(x => x.Name)
                .HasColumnOutputFormatter(x => x?.ToUpper());
            setting.Property("XXX")
                .HasOutputFormatter((x, val) => $"{x.Name}xxx");
            setting.Property("YYY")
                .HasOutputFormatter((x, val) => $"{x.Name}YYY");

            _testEntities = new[]
            {
                new TestEntity() {Id = 1, Name = "1212133"},
                new TestEntity() {Id = 2, Name = "1212133"},
                new TestEntity() {Id = 3, Name = "1212133"},
                new TestEntity() {Id = 4, Name = "1212133"},
                new TestEntity() {Id = 5, Name = "1212133"},

                new TestEntity() {Id = 6, Name = "1212133"},
                new TestEntity() {Id = 7, Name = "1212133"},
                new TestEntity() {Id = 8, Name = "1212133"},
                new TestEntity() {Id = 9, Name = "1212133"},
                new TestEntity() {Id = 10, Name = "1212133"},
            };
        }

        private class TestEntity
        {
            public string Name { get; set; }

            public int Id { get; set; }
        }

        [Benchmark]
        public byte[] FluentFormatter()
        {
            return _testEntities.ToExcelBytes(ExcelFormat.Xls);
        }
    }
}
