using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeQuizApi.Entities
{
    public class Problem
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string InOutDataString { get; set; }

        [NotMapped]
        public List<InOutData> InOutDataList { get; set; }
    }
}
