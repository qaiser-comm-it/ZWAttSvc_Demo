using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ZW.Data;

/* This is used if database provider does't define
 * IZWDbSchemaMigrator implementation.
 */
public class NullZWDbSchemaMigrator : IZWDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
