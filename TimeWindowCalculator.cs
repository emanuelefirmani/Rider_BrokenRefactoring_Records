namespace RefactorOfRecords;

static class TimeWindowCalculator
{
    internal static TimeWindowRecord GetNextWindow(TimeWindowRecord current) => 
        new(current.EndedAt, current.EndedAt.AddHours(1));
}