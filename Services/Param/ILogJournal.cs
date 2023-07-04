using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Services.Param
{
    public interface ILogJournal
    {
        IEnumerable<Log_journal> getLog_journals();
        Log_journal? findById(int id);
    }
}