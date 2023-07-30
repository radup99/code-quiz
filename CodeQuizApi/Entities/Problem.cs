namespace CodeQuizApi.Entities
{
    public class Problem
    {
        public int Id { get; set; }

        public string AuthorId { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public List<InOutData> InOutDataList { get; set; }
    }
}
