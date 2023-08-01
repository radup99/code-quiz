using CodeQuizApi.Entities;
using CodeQuizApi.Models;
using CodeQuizApi.Repositories;

namespace CodeQuizApi.Services
{
    public class ProblemService
    {
        private ProblemRepository _problemRepository;

        public ProblemService(ProblemRepository problemRepository)
        {
            _problemRepository = problemRepository;
        }

        public async Task<ProblemGetResponseModel> GetById(int id)
        {
            var problem = await _problemRepository.GetById(id);
            var responseProblem = new ProblemGetResponseModel(problem);
            return responseProblem;
        }
    }
}
