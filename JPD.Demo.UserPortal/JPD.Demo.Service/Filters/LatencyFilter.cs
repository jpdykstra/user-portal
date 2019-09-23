using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace JPD.Demo.Service.Filters
{
    public class LatencyFilter : IAsyncActionFilter
    {
        private int _simulatedLatency;

        public LatencyFilter(IConfiguration configuration)
        {
            _simulatedLatency = configuration.GetValue<int>("SimulatedAPILatencyDurationInMs", 0);
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!_simulatedLatency.Equals(0))
            {
                await Task.Delay(_simulatedLatency);
            }

            await next();
        }
    }
}
