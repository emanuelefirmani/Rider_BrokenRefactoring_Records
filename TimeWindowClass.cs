using System;

namespace RefactorOfRecords;

class TimeWindowClass
{
    public DateTime StartedAt { get; set; }
    public DateTime EndedAt { get; set; }

    public TimeWindowClass(DateTime startedAt, DateTime endedAt)
    {
        StartedAt = startedAt;
        EndedAt = endedAt;
    }
}