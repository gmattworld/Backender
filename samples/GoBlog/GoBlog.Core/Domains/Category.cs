//This Class Is Auto Generated with Backender, For get more Information check https://github.com/MahdiHoseinpoor/Backender
using System.ComponentModel.DataAnnotations;
namespace GoBlog.Core.Domains
{
    public class Category:BaseEntity
    {
        [Required]
        public  string Title { get; set; }
        [Required]
        public  string Description { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}