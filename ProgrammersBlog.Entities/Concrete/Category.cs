using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Concrete
{
    public class Category:EntityBase,IEntity
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public ICollection<Article> Articles { get; set; }//Bir kategorinin birden fazla Article(Makalesi) olabilir
    }
}
