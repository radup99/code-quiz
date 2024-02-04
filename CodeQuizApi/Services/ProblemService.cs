using CodeQuizApi.Entities;
using CodeQuizApi.Models.ProblemModels;
using CodeQuizApi.Repositories;

namespace CodeQuizApi.Services
{
    public class ProblemService
    {
        private readonly ProblemRepository _problemRepository;

        public ProblemService(ProblemRepository problemRepository)
        {
            _problemRepository = problemRepository;
        }

        public async Task<GetProblemModel?> GetById(int id)
        {
            var problem = await _problemRepository.GetById(id);
            if (problem == null)
                return null;
            var responseProblem = new GetProblemModel(problem);
            return responseProblem;
        }

        public async Task CreateProblem(CreateProblemModel postReq)
        {
            var problem = new Problem(postReq);
            await _problemRepository.Add(problem);
        }
    }
}