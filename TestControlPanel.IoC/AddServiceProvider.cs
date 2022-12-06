using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TestControlPanel.Infra.Context;

namespace TestControlPanel.IoC
{
    public static class AddServiceProvider
    {
        public static void AddDatabaseContext(this IServiceCollection service, IConfiguration configuration)
        {
            string? dbConnectionString = configuration?.GetConnectionString("TestControlPanelDBConnection");
            service.AddDbContext<TestControlPanelDBContext>(options =>
            {
                options.UseSqlServer(dbConnectionString);
            });
        }
    }
}