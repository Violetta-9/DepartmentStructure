using DepartmentStructure.Data.Shared;
using Microsoft.EntityFrameworkCore;

namespace DepartmentStructure.HostedService
{
    public class DatabaseHostedService : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;

        public DatabaseHostedService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {
           await Migrate<DepartmentStructureDbContext>(cancellationToken);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private async Task Migrate<T>(CancellationToken cancellationToken) where T : DbContext 
        {
            using var scope = _serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<T>();
            await dbContext.Database.MigrateAsync(cancellationToken);

        }
    }
}
