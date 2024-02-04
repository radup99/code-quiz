using CodeQuizApi.Database;
using CodeQuizApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeQuizApi.Repositories
{
    public class ProblemRepository : IRepository<Problem>
    {
        private readonly MainDbContext _context;
        private readonly DbSet<Problem> _dbset;

        public ProblemRepository(MainDbContext context)
        {
            _context = context;
            _dbset = context.Set<Problem>();
        }

        public async Task<Problem?> GetById(int id)
        {
            return await _context.Problems.FindAsync(id);
        }

        public async Task Add(Problem problem)
        {
            await _dbset.AddAsync(problem);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveById(int id)
        {
            await _dbset.Where(p => p.Id == id).ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, Problem updatedProblem)
        {
            var problem = this.GetById(id).Result;
            problem.Title = updatedProblem.Title;
            problem.Text = updatedProblem.Text;
            problem.InOutDataString = updatedProblem.InOutDataString;
            await _context.SaveChangesAsync();
        }
    }
}