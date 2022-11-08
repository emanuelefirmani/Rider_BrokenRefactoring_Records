using System;
using Xunit;

namespace RefactorOfRecords;

public class Tests
{
    [Fact]
    void class_uses_the_same_instance()
    {
        var c1 = new TimeWindowClass(DateTime.MinValue, DateTime.MaxValue);
        var c2 = c1;
        
        c2.StartedAt = DateTime.Today;
        
        Assert.Equal(DateTime.Today, c1.StartedAt);
    }

    [Fact]
    void record_does_not_use_the_same_instance_1()
    {
        var c1 = new TimeWindowRecord(DateTime.MinValue, DateTime.MaxValue);
        var c2 = new TimeWindowRecord(c1.StartedAt, c1.EndedAt);

        Assert.Equal(DateTime.MinValue, c1.StartedAt);
    }

    [Fact]
    void record_does_not_use_the_same_instance_2()
    {
        var c1 = new TimeWindowRecord(DateTime.MinValue, DateTime.MaxValue);
        var c2 = c1 with { StartedAt = DateTime.Today };

        Assert.Equal(DateTime.MinValue, c1.StartedAt);
        Assert.Equal(DateTime.Today, c2.StartedAt);
    }

    [Fact]
    void calculates_next_TimeWindow()
    {
        var tw = new TimeWindowRecord(new DateTime(2001, 2, 3, 4, 5, 6), new DateTime(2005, 6, 7, 8, 9, 10));

        var actual = TimeWindowCalculator.GetNextWindow(tw);
        
        Assert.Equal(new DateTime(2005, 6, 7, 8, 9, 10), actual.StartedAt);
        Assert.Equal(new DateTime(2005, 6, 7, 9, 9, 10), actual.EndedAt);
    }
}