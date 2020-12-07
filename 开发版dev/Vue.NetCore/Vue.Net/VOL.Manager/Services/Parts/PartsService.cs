/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下PartsService与IPartsService中编写
 */
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using VOL.Manager.IRepositories;
using VOL.Manager.IServices;

namespace VOL.Manager.Services
{
    public partial class PartsService : ServiceBase<Parts, IPartsRepository>
    , IPartsService, IDependency
    {
    public PartsService(IPartsRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IPartsService Instance
    {
      get { return AutofacContainerModule.GetService<IPartsService>(); } }
    }
 }
