using ZW.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ZW.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ZWController : AbpControllerBase
{
    protected ZWController()
    {
        LocalizationResource = typeof(ZWResource);
    }
}
