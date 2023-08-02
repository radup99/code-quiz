using System.ComponentModel.DataAnnotations.Schema;

namespace CodeQuizApi.Models
{
    public class ProblemPostRequestModel
    {

        public string Title { get; set; }

        public string Text { get; set; }

        public string InOutDataString { get; set; }

    }
}
