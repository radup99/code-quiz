using CodeQuizApi.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeQuizApi.Models
{
    public class ProblemGetResponseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public ProblemGetResponseModel(Problem problem)
        {
            Id = problem.Id;
            Title = problem.Title;
            Text = problem.Text;
        }
    }
}
