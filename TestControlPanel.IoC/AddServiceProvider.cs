using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using TestControlPanel.Infra.Context;

namespace TestControlPanel.IoC
{
    public static class AddServiceProvider
    {
        public static void AddDatabaseContext(IServiceCollection service, IConfiguration configuration)
        {
            string? dbConnectionString = configuration?.GetConnectionString("TestControlPanelDBConnection");
            service.AddDbContext<TestControlPanelDBContext>(options =>
            {
                options.UseSqlServer(dbConnectionString);
            });
        }
    }
}
