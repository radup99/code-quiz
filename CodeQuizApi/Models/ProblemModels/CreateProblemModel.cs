using System.ComponentModel.DataAnnotations.Schema;

namespace CodeQuizApi.Models.ProblemModels
{
    public class CreateProblemModel
    {

        public string Title { get; set; }

        public string Text { get; set; }

        public string InOutDataString { get; set; }

    }
}