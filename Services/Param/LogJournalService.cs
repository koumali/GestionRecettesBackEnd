using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Services.Param
{
    public class LogJournalService : ILogJournal
    {
        private readonly AppDbContext _context;

        public LogJournalService(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Log_journal> getLog_journals()
        {
            var logJournals = _context.log_journal.ToList();
            return logJournals;
        }

        public Log_journal? findById(int id)
        {
            var log = _context.log_journal.FirstOrDefault(u => u.Id == id);
            return log;
        }
    }
}