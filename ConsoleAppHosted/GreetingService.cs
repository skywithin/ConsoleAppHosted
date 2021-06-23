using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleAppHosted
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> _logger;
        private readonly IConfiguration _config;

        public GreetingService(
            ILogger<GreetingService> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            _config = configuration;
        }

        public void Run()
        {
            var loopTimes = _config.GetValue<int>("LoopTimes");

            for (int i = 0; i < loopTimes; i++)
            {
                _logger.LogInformation("Run number {runNumber}", i);
            }
        }
    }

    public interface IGreetingService
    {
        void Run();
    }
}
