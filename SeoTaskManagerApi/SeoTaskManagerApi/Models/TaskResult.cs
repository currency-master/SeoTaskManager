namespace SeoTaskManagerApi.Models
{
    public class TaskResult
    {
        public int Id { get; set; }
        public string GoodName { get; set; }
        public string KeyWord { get; set; }
        public bool Finished { get; set; }
        public int? WordRank { get; set; }
        public int? AdsCount { get; set; }
    }
}