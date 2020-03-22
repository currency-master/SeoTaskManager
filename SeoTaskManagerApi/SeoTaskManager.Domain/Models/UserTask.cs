using System.ComponentModel.DataAnnotations;

namespace SeoTaskManager.Domain.Models
{
    public class UserTask
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; } // or GUID as u wish
        public string GoodName { get; set; }
        public string KeyWord { get; set; }
        public bool Finished { get; set; }
        public int? WordRank { get; set; }
        public int? AdsCount { get; set; }
    }
}