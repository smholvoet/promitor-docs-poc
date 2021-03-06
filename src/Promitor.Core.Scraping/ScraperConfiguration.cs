using GuardNet;
using Microsoft.Extensions.Logging;
using Promitor.Core.Metrics;
using Promitor.Core.Metrics.Sinks;
using Promitor.Integrations.AzureMonitor;

namespace Promitor.Core.Scraping
{
    public class ScraperConfiguration
    {
        /// <summary>
        ///     Client to interact with Azure Monitor
        /// </summary>
        public AzureMonitorClient AzureMonitorClient { get; }

        /// <summary>
        ///     Writer to send metrics to all configured sinks
        /// </summary>
        public MetricSinkWriter MetricSinkWriter { get; }

        /// <summary>
        ///     Logger used for telemetry
        /// </summary>
        public ILogger Logger { get; }

        /// <summary>
        ///     Collector to send metrics related to the runtime
        /// </summary>
        public IRuntimeMetricsCollector RuntimeMetricsCollector { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="azureMonitorClient">Client to communicate with Azure Monitor</param>
        /// <param name="metricSinkWriter">Writer to send metrics to all configured sinks</param>
        /// <param name="runtimeMetricsCollector">Collector to send metrics related to the runtime</param>
        /// <param name="logger">General logger</param>
        public ScraperConfiguration(AzureMonitorClient azureMonitorClient, MetricSinkWriter metricSinkWriter, IRuntimeMetricsCollector runtimeMetricsCollector, ILogger logger)
        {
            Guard.NotNull(azureMonitorClient, nameof(azureMonitorClient));
            Guard.NotNull(logger, nameof(logger));
            Guard.NotNull(metricSinkWriter, nameof(metricSinkWriter));
            Guard.NotNull(runtimeMetricsCollector, nameof(runtimeMetricsCollector));

            AzureMonitorClient = azureMonitorClient;
            Logger = logger;
            MetricSinkWriter = metricSinkWriter;
            RuntimeMetricsCollector = runtimeMetricsCollector;
        }
    }
}