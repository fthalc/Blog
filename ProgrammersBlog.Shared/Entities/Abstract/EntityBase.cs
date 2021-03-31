using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Entities.Abstract
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;// override CreatedDate = new DateTime(2021/03/31)
        public virtual DateTime ModifiedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual String CreatedByName { get; set; } = "Admin";
        public virtual String ModifiedByName { get; set; } = "Admin";
        public virtual String Note { get; set; }

    }
}
