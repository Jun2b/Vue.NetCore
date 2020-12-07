/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Sku_detailsService与ISku_detailsService中编写
 */
using VOL.Manager.IRepositories;
using VOL.Manager.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using VOL.Manager.IRepositories;

namespace VOL.Manager.Services
{
    public partial class Sku_detailsService : ServiceBase<Sku_details, ISku_detailsRepository>
    , ISku_detailsService, IDependency
    {
    public Sku_detailsService(ISku_detailsRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ISku_detailsService Instance
    {
      get { return AutofacContainerModule.GetService<ISku_detailsService>(); } }
    }
 }
