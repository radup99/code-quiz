using CodeQuizApi.Database;
using CodeQuizApi.Entities;
using CodeQuizApi.Models;
using CodeQuizApi.Repositories;
using CodeQuizApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ProblemGetResponseModel> GetById(int id)
        {
            return await _problemService.GetById(id);
        }

        [HttpPost(Name = "Post")]
        public async Task Post(ProblemPostRequestModel postReq)
        {
            await _problemService.AddProblem(postReq);
        }
    }
}
