
using System.Reflection;
using DepartmentStructure.Data.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DepartmentStructure.Data.EF.PostgreSQL
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDepartmentStructurePostgreSql(this IServiceCollection services,
            string connectionString)
        {
            services.AddDbContext<DepartmentStructureDbContext>(options =>
                options.UseNpgsql(connectionString,
                    x => x.MigrationsAssembly(Assembly.GetExecutingAssembly()
                        .GetName().Name)));

        }
    }
}
