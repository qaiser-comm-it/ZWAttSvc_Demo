using System;
using System.Collections.Generic;
using System.Text;
using ZW.Localization;
using Volo.Abp.Application.Services;

namespace ZW;

/* Inherit your application services from this class.
 */
public abstract class ZWAppService : ApplicationService
{
    protected ZWAppService()
    {
        LocalizationResource = typeof(ZWResource);
    }
}
