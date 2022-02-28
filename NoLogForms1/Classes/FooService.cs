using Microsoft.Extensions.Logging;
using NLogForms1.Interfaces;

namespace NLogForms1.Classes
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

            _logger.LogWarning(eventId, "Message");

        }

        public void Worker()
        {
            _logger.LogInformation($"Doing work in {nameof(Worker)}");
            
            EventId eventId = new EventId(11, "KP2");

            _logger.LogCritical(eventId, "Message");
        }
    }
}