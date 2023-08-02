using CodeQuizApi.Database;
using CodeQuizApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeQuizApi.Repositories
{
    public class ProblemRepository: IRepository<Problem>
    {
        private MainDbContext _context;
        private DbSet<Problem> _dbset;

        public ProblemRepository(MainDbContext context)
        {
            _context = context;
            _dbset = context.Set<Problem>();
        }

        public async Task<Problem> GetById(int id)
        {
            return await _context.Problems.FindAsync(id);
        }

        public async Task Add(Problem problem)
        {
            await _dbset.AddAsync(problem);
            await _context.SaveChangesAsync();
        }
    }
}
