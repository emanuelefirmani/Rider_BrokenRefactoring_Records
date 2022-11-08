namespace RefactorOfRecords;

static class TimeWindowCalculator
{
    internal static TimeWindowRecord GetNextWindow(TimeWindowRecord current) => 
        current with { EndedAt = current.EndedAt.AddHours(1) };
}