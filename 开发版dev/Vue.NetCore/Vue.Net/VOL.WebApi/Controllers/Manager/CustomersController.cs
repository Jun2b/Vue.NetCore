/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹CustomersController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Manager.IServices;
namespace VOL.Manager.Controllers
{
    [Route("api/Customers")]
    [PermissionTable(Name = "Customers")]
    public partial class CustomersController : ApiBaseController<ICustomersService>
    {
        public CustomersController(ICustomersService service)
        : base(service)
        {
        }
    }
}

