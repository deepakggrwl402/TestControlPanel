using AutoMapper;

using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestControlPanel.Application.Services
{
    public class BaseService<T>
    {
        #region Field, Properties & Constructor
        protected readonly IMapper mapper;
        protected readonly ILogger<T> logger;

        public BaseService(IMapper mapper, ILogger<T> logger)   
        {
            this.mapper = mapper;
            this.logger = logger;
        }

        #endregion
    }
}
