using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace ZW.AttSvc
{
    public class ProjectDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }

}
