/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹PartsController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Manager.IServices;
namespace VOL.Manager.Controllers
{
    [Route("api/Parts")]
    [PermissionTable(Name = "Parts")]
    public partial class PartsController : ApiBaseController<IPartsService>
    {
        public PartsController(IPartsService service)
        : base(service)
        {
        }
    }
}

