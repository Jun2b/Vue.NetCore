/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹CardsController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Manager.IServices;
namespace VOL.Manager.Controllers
{
    [Route("api/Cards")]
    [PermissionTable(Name = "Cards")]
    public partial class CardsController : ApiBaseController<ICardsService>
    {
        public CardsController(ICardsService service)
        : base(service)
        {
        }
    }
}

