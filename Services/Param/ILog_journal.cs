using automotiveApi.Models;

namespace automotiveApi.Services.Param
{
    public interface ILog_journal
    {   
       IEnumerable<Log_journal> getLog_journals();
        Log_journal? findById(int id);

    }
}