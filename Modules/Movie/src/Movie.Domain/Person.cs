using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Movie
{
    public class Person : AuditedAggregateRoot<int>
    {
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Img { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public Country Country { get; set; }
        public bool IsActor { get; set; }
        public bool IsDirector { get; set; }

    }

}
