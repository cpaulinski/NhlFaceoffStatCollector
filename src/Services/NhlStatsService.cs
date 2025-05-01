using NhlFaceoffStatCollector.Clients;
using NhlFaceoffStatCollector.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlFaceoffStatCollector.Services
{
    internal class NhlStatsService : INhlStatsService
    {
        private readonly ILogger<NhlStatsService> _logger;
        private readonly NhlStatsClient _client;

        public NhlStatsService(ILogger<NhlStatsService> logger, NhlStatsClient client)
        {
            _logger = logger;
            _client = client;
        }
    }
}
