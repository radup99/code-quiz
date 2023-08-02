using CodeQuizApi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeQuizApi.Entities
{
    public class Problem
    {
        [Key]
        public int Id { get; set; }

        public string AuthorId { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string InOutDataString { get; set; }

        [NotMapped]
        public List<InOutData> InOutDataList { get; set; }

        public Problem(ProblemPostRequestModel postRec)
        {
            this.AuthorId = EntityConstants.DefaultAuthorId;
            this.Title = postRec.Title;
            this.Text = postRec.Text;
            this.InOutDataString = postRec.InOutDataString;
        }
    }
}
