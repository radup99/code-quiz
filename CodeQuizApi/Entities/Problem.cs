using CodeQuizApi.Models.ProblemModels;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeQuizApi.Entities
{
    public class Problem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string InOutDataString { get; set; }

        [NotMapped]
        public List<InOutData> InOutDataList { get; set; }

        public Problem() { }

        public Problem(CreateProblemModel crProblem)
        {
            this.Title = crProblem.Title;
            this.Text = crProblem.Text;
            this.InOutDataString = crProblem.InOutDataString;
        }
    }
}
