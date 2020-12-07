/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下SkusService与ISkusService中编写
 */
using VOL.Manager.IRepositories;
using VOL.Manager.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using VOL.Manager.IRepositories;

namespace VOL.Manager.Services
{
    public partial class SkusService : ServiceBase<Skus, ISkusRepository>
    , ISkusService, IDependency
    {
    public SkusService(ISkusRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ISkusService Instance
    {
      get { return AutofacContainerModule.GetService<ISkusService>(); } }
    }
 }
