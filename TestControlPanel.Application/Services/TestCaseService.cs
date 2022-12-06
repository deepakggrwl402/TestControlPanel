using AutoMapper;

using Microsoft.Extensions.Logging;

using TestControlPanel.Application.Interfaces;

namespace TestControlPanel.Application.Services
{
    public class TestCaseService : BaseService<TestCaseService>, ITestCaseService
    {
        #region Fields, Properties & Construtor
        public TestCaseService(IMapper mapper, ILogger<TestCaseService> logger) : base(mapper, logger)
        {
        }

        #endregion

        #region Tasks & Methods

        #endregion
    }
}