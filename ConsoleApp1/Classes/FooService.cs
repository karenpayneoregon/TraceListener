using ConsoleApp1.Interfaces;
using Microsoft.Extensions.Logging;

namespace ConsoleApp1.Classes
{
    public class FooService : ICommonService
    {
        private readonly ILogger _logger;

        public FooService(ILogger<FooService> logger)
        {
            _logger = logger;
        }

        public void Execute()
        {
            _logger.LogInformation($"Doing work in {nameof(Execute)}");
            EventId eventId = new EventId(1, "KP1");
            _logger.LogCritical(eventId, "Message");
        }
    }
}