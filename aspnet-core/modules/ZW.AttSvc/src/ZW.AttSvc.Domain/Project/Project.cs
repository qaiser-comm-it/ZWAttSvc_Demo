using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace ZW.AttSvc
{
    public class Project : Entity<Guid>
    {
        public string Name { get; set; }
    }
}
