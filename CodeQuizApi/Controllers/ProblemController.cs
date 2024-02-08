using CodeQuizApi.Models.ProblemModels;
using CodeQuizApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeQuizApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProblemController : ControllerBase
    {

        private readonly ILogger<ProblemController> _logger;
        private readonly ProblemService _problemService;

        public ProblemController(ILogger<ProblemController> logger, ProblemService problemService)
        {
            _logger = logger;
            _problemService = problemService;
        }

        [HttpGet(Name = "GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var getProblemModel = await _problemService.GetById(id);
            if (getProblemModel == null)
                return NotFound($"No problem with ID={id} found.");
            return Ok(getProblemModel);
        }

        [HttpPost(Name = "Post")]
        public async Task Post(CreateProblemModel problemModel)
        {
            await _problemService.CreateProblem(problemModel);
        }
    }
}