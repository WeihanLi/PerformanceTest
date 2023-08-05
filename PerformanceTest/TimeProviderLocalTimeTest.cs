// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the MIT license.

namespace PerformanceTest;

[MemoryDiagnoser]
public class TimeProviderLocalTimeTest
{
    private static readonly long s_minDateTicks = DateTime.MinValue.Ticks;
    private static readonly long s_maxDateTicks = DateTime.MaxValue.Ticks;
    
    [Benchmark(Baseline = true)]
    public DateTimeOffset GetLocalNow() 
    {
        var utcDateTime = DateTimeOffset.UtcNow; 
        var zoneInfo = TimeZoneInfo.Utc;
        var offset = zoneInfo.GetUtcOffset(utcDateTime); 
  
        var localTicks = utcDateTime.Ticks + offset.Ticks; 
        if ((ulong)localTicks > (ulong)s_maxDateTicks) 
        { 
            localTicks = localTicks < s_minDateTicks ? s_minDateTicks : s_maxDateTicks; 
        } 
  
        return new DateTimeOffset(localTicks, offset); 
    }
    
    [Benchmark]
    public DateTimeOffset GetLocalNow_Update() 
    { 
        var utcDateTime = DateTimeOffset.UtcNow; 
        var zoneInfo = TimeZoneInfo.Utc;
        var offset = zoneInfo.GetUtcOffset(utcDateTime);
        if (offset.Ticks is 0) return utcDateTime;
  
        var localTicks = utcDateTime.Ticks + offset.Ticks; 
        if ((ulong)localTicks > (ulong)s_maxDateTicks) 
        { 
            localTicks = localTicks < s_minDateTicks ? s_minDateTicks : s_maxDateTicks; 
        }
        return new DateTimeOffset(localTicks, offset); 
    }
}
