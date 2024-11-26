// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the MIT license.

namespace PerformanceTest.DummyTests;

[MemoryDiagnoser]
[SimpleJob]
public class SubStringTest
{
    private const string LanguageCode = "en-US";
    private const string SetName = "Keys-en-US-US";

    [Benchmark(Baseline = true)]
    public string SubString()
    {
        var languageIndex = SetName.IndexOf(LanguageCode, StringComparison.Ordinal);
        var countryIndex = languageIndex + LanguageCode.Length + 1;
        var country = string.Empty;
        if (SetName.Length > countryIndex)
        {
            country = SetName[countryIndex..];
        }
        return country;
    }
    
    [Benchmark]
    public string SpanString()
    {
        var setNameSpan = SetName.AsSpan();
        var languageIndex = setNameSpan.IndexOf(LanguageCode.AsSpan(), StringComparison.Ordinal);
        var countryIndex = languageIndex + LanguageCode.Length + 1;
        var country = string.Empty;
        if (setNameSpan.Length > countryIndex)
        {
            country = new string(setNameSpan[countryIndex..]);
        }
        return country;
    }
}
