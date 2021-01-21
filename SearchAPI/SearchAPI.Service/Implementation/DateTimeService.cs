using SearchAPI.Service.Contract;
using System;

namespace SearchAPI.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}