using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Movie
{
    public class Category : AuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public Category? ParentCategory { get; set; }
        public IList<Category> Categorys { get; set; }
    }
}
