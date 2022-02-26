using System.Threading.Tasks;

namespace ZW.Data;

public interface IZWDbSchemaMigrator
{
    Task MigrateAsync();
}
