using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Concrete
{
    public class Article:EntityBase,IEntity
    {
        public String Title { get; set; }
        public String Content { get; set; }
        public String Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewsCount { get; set; }
        public int CommentCount { get; set; }
        public String SeoAuthor { get; set; }
        public String SeoDescription { get; set; }
        public String SeoTags { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
