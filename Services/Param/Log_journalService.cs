using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Services.Param
{
    public class Log_journalService : ILog_journal
    {
        private readonly AppDbContext _context;

        public Log_journalService(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Log_journal> getLog_journals()
        {
            var Log_journals = _context.log_journal.ToList();
            return Log_journals;
        }

        public Log_journal? findById(int id)
        {
            var log = _context.log_journal.Where(u => u.id == id).FirstOrDefault();
            return log;
        }
    }
}