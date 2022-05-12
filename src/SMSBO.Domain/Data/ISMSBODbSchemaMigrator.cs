using System.Threading.Tasks;

namespace SMSBO.Data;

public interface ISMSBODbSchemaMigrator
{
    Task MigrateAsync();
}
