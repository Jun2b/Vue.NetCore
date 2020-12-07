/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Sku_detailsController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Manager.IServices;
namespace VOL.Manager.Controllers
{
    [Route("api/Sku_details")]
    [PermissionTable(Name = "Sku_details")]
    public partial class Sku_detailsController : ApiBaseController<ISku_detailsService>
    {
        public Sku_detailsController(ISku_detailsService service)
        : base(service)
        {
        }
    }
}

